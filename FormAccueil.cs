using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Text;
using System.Speech.Synthesis;
using System.Collections;


namespace WinecranFormsApp
{
    public partial class FormAccueil : Form
    {
        public EcranCZS ecranCZS
        {
            get => unEcran;
            set => unEcran = value;
        }
        private EcranCZS unEcran;

        public WinShape myShape
        {
            get => unShape;
            set => unShape = value;
        }
        private WinShape unShape;

        // Mode Question/Réponse.
        public bool flagQuestion = false;
        public int numTirage = -1;
        public int numReponse = -1;
        Queue QueueOldTirage = new Queue(6);

        // Score.
        public int valScore = 100;
        public int nbQuestions = 0;
        public int nbReponsesOK = 0;

        // Mode création.
        public bool flagCreation = false;
        public bool dessinActif = false;
        public List<WinShape> lstCreaShapes;
        int creaShapesID = 0;
        public string creaPicture = String.Empty;
        Rectangle rect;
        Point shapeOrigine;
        Point movePoint;


        public FormAccueil()
        {
            InitializeComponent();
            Program.LicenceInvalideExit = false;
        }


        private void chargerUnEcran_Click(object sender, System.EventArgs e)
        {
            if (Program.LicenceInvalide == true)
            {
                return;
            }

            // Alerter si l'on est en mode création.
            if (flagCreation == true)
            {
                FormAbandonCreation formAbandonCrea = new FormAbandonCreation();
                if (formAbandonCrea.ShowDialog() == DialogResult.Cancel)
                {
                    formAbandonCrea.Dispose();
                    return;
                }
                else
                {
                    formAbandonCrea.Dispose();
                }
            }
            flagCreation = false;

            // Ouverture d'un fichier .czs
            openFile_CZS.FileName = "";
            if (openFile_CZS.ShowDialog() == DialogResult.OK)
            {
                // Associe le fichier à un stream.
                var fileStream = openFile_CZS.OpenFile();

                // Lecture et découpage du fichier (ANSI 1252).
                StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding(1252));
                try
                {
                    string imageEcran = reader.ReadLine();
                    string wavEntete = reader.ReadLine();
                    string wavExact = reader.ReadLine();
                    string wavErreur = reader.ReadLine();
                    // Création d'un écran et affichage de son image.
                    ecranCZS = new EcranCZS(imageEcran, wavEntete, wavExact, wavErreur);
                    pictureBoxEcran.Image = ecranCZS.Picture;
                }
                catch
                {
                    MessageBox.Show("Le fichier .czs sélectionné n'est pas valide.\nERRFA101", "Charger un écran");
                    if (reader != null) reader.Dispose();
                    return;
                }

                // Supprimer les WinShapes d'un possible écran précédent.
                pictureBoxEcran.Controls.Clear();

                flagQuestion = false;
                numReponse = -1;

                labelScore.Visible = false;
                textBoxScore.Visible = false;
                valScore = 100;
                textBoxScore.Text = valScore.ToString(new CultureInfo("fr-FR")) + " %";
                nbQuestions = 0;
                nbReponsesOK = 0;

                // Découpage d'une ligne de fichier CZS.
                // 347$104$13$13$Le Havre

                int vTop;
                int vLeft;
                int vWidth;
                int vHeight;
                string shapeWav;

                // Le premier shapeID créé sera 0, aligné avec le premier index de listeShapes.
                int shapeID = -1;

                string aLine = string.Empty;
                while (aLine != null)
                {
                    aLine = reader.ReadLine();
                    if (aLine != null)
                    {
                        try
                        {
                            string[] split = aLine.Split(new Char[] { '$' });
                            IFormatProvider provider = new CultureInfo("fr-FR");
                            vTop = int.Parse(split[0], 0, provider);
                            vLeft = int.Parse(split[1], 0, provider);
                            vWidth = int.Parse(split[2], 0, provider);
                            vHeight = int.Parse(split[3], 0, provider);
                            shapeWav = split[4];
                        }
                        catch
                        {
                            MessageBox.Show("Le fichier .czs sélectionné contient des erreurs.\nERRFA149", "Charger un écran");
                            if (reader != null) reader.Dispose();
                            return;
                        }

                        // Identification du WinShape à créer.
                        shapeID++;

                        // Création et ajout du WinShape sur l'image d'écran et dans listeShapes.
                        myShape = new WinShape(vTop, vLeft, vWidth, vHeight, shapeWav, shapeID, false);
                        pictureBoxEcran.Controls.Add(myShape);
                        ecranCZS.ListeShapes.Add(myShape);
                        ecranCZS.NbShapes++;
                    }
                }

                // Plus besoin du StreamReader.
                if (reader != null) reader.Dispose();

                // Ne pas accepter d'écran contenant moins de 6 zones cliquables.
                if (ecranCZS.NbShapes < 6)
                {
                    MessageBox.Show("Cet écran contenant moins de 6 zones cliquables\nil ne fonctionnera pas.", "Charger un écran");
                    pictureBoxEcran.Controls.Clear();
                    return;
                }

                // MaJ menus, boutons.
                questRepMenuItem.Enabled = true;
                decouverteMenuItem.Enabled = false;

                questionnerButton.Enabled = true;
                decouverteButton.Enabled = false;

                sauverEcranButton.Enabled = false;
                sauvegarderMenuItem.Enabled = false; ;
            }
        }


        public void questionnerClick(object sender, System.EventArgs e)
        {
            flagQuestion = true;
            flagCreation = false;

            // MaJ menus, boutons.
            questRepMenuItem.Enabled = false;
            questionnerButton.Enabled = false;

            decouverteMenuItem.Enabled = true;
            decouverteButton.Enabled = true;

            // Sauvegarder le Clip du curseur.
            Rectangle SavedClip = Cursor.Clip;

            // Positionner le curseur en haut et à gauche de l'écran.
            Point aP = new Point(1, 1);
            Point bP = PointToScreen(aP);
            Cursor.Position = bP;
            Cursor.Hide();

            // Gel de la position du curseur.
            Cursor.Clip = new Rectangle(Cursor.Position, new Size(1, 1));

            // Tirage au sort d'une question.
            if (numReponse == -1)
            {
                var rand = new Random();
                if (ecranCZS.NbShapes > 1)
                {
                    while (numTirage == -1 || QueueOldTirage.Contains(numTirage))
                    {
                        numTirage = rand.Next(ecranCZS.NbShapes);
                    }

                    QueueOldTirage.Enqueue(numTirage);
                    if (QueueOldTirage.Count > 5)
                        QueueOldTirage.Dequeue();
                }
                else
                {
                    numTirage = -1;
                }
            }

            // MaJ score.
            Program.formAccueil.UpdateScore();
            labelScore.Visible = true;
            textBoxScore.Visible = true;
            panelBoutons.Refresh();
            nbQuestions++;

            // Emission des sons question.
            using (SpeechSynthesizer SyntheseVocale = new SpeechSynthesizer())
            {
                SyntheseVocale.SetOutputToDefaultAudioDevice();

                try
                {
                    EmettreSpeech(SyntheseVocale, ecranCZS.SonEnteteQuestion);
                }
                catch
                {
                    // Rétablissement du Clip du curseur.
                    Cursor.Clip = SavedClip;
                    Cursor.Show();
                    MessageBox.Show($"Le texte \"{ecranCZS.SonEnteteQuestion}\" ne peut être lu par la synthèse vocale\nERRFA253\n\n", "Charger un écran");
                    return;
                }

                WinShape randShape = ecranCZS.ListeShapes[numTirage];
                try
                {
                    EmettreSpeech(SyntheseVocale, randShape.SonWav);
                }
                catch
                {
                    // Rétablissement du Clip du curseur.
                    Cursor.Clip = SavedClip;
                    Cursor.Show();
                    MessageBox.Show($"Le texte \"{randShape.SonWav}\" ne peut être lu par la synthèse vocale\nERRFA269\n\n", "Charger un écran");
                    return;
                }
            }

            // Rétablissement du Clip du curseur.
            Cursor.Clip = SavedClip;
            Cursor.Show();
        }


        private void quitterItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void aideItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, ".//winecran.chm");
            }
            catch
            {
                MessageBox.Show("Le fichier d'aide n'est pas accessible,\nil a été supprimé ou déplacé.\nRéinstallez WinEcran.", "Aide WinEcran");
                return;
            }
        }


        private void aProposItem_Click(object sender, EventArgs e)
        {
            aProposItem.Enabled = false;

            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
            formAbout.Dispose();
        }


        private void StopQuestButton_Click(object sender, EventArgs e)
        {
            // MaJ menus, boutons, variables.

            flagQuestion = false;

            questRepMenuItem.Enabled = true;
            questionnerButton.Enabled = true;

            decouverteMenuItem.Enabled = false;
            decouverteButton.Enabled = false;

            labelScore.Visible = false;
            textBoxScore.Visible = false;
            nbQuestions = 0;
            nbReponsesOK = 0;

            numTirage = -1;
            numReponse = -1;
        }


        private void creerEcranButton_Click(object sender, EventArgs e)
        {
            if (Program.LicenceInvalide == true)
            {
                return;
            }

            // Alerter si l'on est en mode création.
            if (flagCreation == true)
            {
                using (FormAbandonCreation formAbandonCrea = new FormAbandonCreation())
                {
                    if (formAbandonCrea.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }

            // Ouverture d'un fichier .bmp
            openFileDialog_BMP.FileName = "";
            if (openFileDialog_BMP.ShowDialog() == DialogResult.OK)
            {
                creaShapesID = 0;
                pictureBoxEcran.Controls.Clear();
                pictureBoxEcran.Image.Dispose();

                try
                {
                    creaPicture = openFileDialog_BMP.FileName;
                    // Affichage de l'image sélectionnée et création d'une liste de WinShapes.
                    pictureBoxEcran.Image = new Bitmap(creaPicture);
                    lstCreaShapes = new List<WinShape>();
                }
                catch
                {
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
                    pictureBoxEcran.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEcran.Image", new CultureInfo("fr-FR"))));

                    // Reset menus, boutons et flags.
                    flagQuestion = false;
                    flagCreation = false;
                    dessinActif = false;
                    labelScore.Visible = false;
                    textBoxScore.Visible = false;
                    sauvegarderMenuItem.Enabled = false;
                    sauverEcranButton.Enabled = false;
                    questRepMenuItem.Enabled = false;
                    questionnerButton.Enabled = false;
                    decouverteMenuItem.Enabled = false;
                    decouverteButton.Enabled = false;

                    MessageBox.Show("Le fichier image sélectionné n'est pas valide.\nERRFA374", "Créer un écran");
                    return;
                }

                shapeOrigine = new Point(0, 0);
                movePoint = new Point(0, 0);

                // Mode création actif.
                flagQuestion = false;
                flagCreation = true;
                dessinActif = false;

                // MaJ menus, boutons.
                labelScore.Visible = false;
                textBoxScore.Visible = false;
                sauvegarderMenuItem.Enabled = true;
                sauverEcranButton.Enabled = true;
                questRepMenuItem.Enabled = false;
                questionnerButton.Enabled = false;
                decouverteMenuItem.Enabled = false;
                decouverteButton.Enabled = false;
            }
        }


        private void sauverEcranButton_Click(object sender, EventArgs e)
        {
            // On ne sauvegarde l'écran que s'il contient au moins 6 zones cliquables.
            if (creaShapesID > 5)
            {
                FormSauvegardeCreation formSauvegardeCreation = new FormSauvegardeCreation();
                formSauvegardeCreation.ShowDialog();
                formSauvegardeCreation.Dispose();
            }
            else
            {
                string message = String.Format(new CultureInfo("fr-FR"), "Impossible d'enregistrer un écran ne contenant que {0} zone(s) cliquable(s).\nLe minimum est de 6.", creaShapesID);
                MessageBox.Show(message, "Sauvegarder un écran");
                return;
            }
        }


        private void licenceItem_Click(object sender, EventArgs e)
        {
            licenceItem.Enabled = false;

            using (FormLicenceWinecran formLicence = new FormLicenceWinecran())
            {
                formLicence.ShowDialog();
            }
        }


        // En mode création, dessin du rectangle d'un WinShape.

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (flagCreation == true)
            {
                dessinActif = true;

                Control control = (Control)sender;
                shapeOrigine = control.PointToScreen(new Point(e.X, e.Y));

                movePoint = shapeOrigine;
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagCreation == true && dessinActif == true)
            {
                Rectangle creaRect;
                creaRect = GetRect(shapeOrigine, movePoint);
                ControlPaint.DrawReversibleFrame(creaRect, Color.Transparent, FrameStyle.Dashed);

                Control control = (Control)sender;
                movePoint = control.PointToScreen(new Point(e.X, e.Y));
                creaRect = GetRect(shapeOrigine, movePoint);
                ControlPaint.DrawReversibleFrame(creaRect, Color.Transparent, FrameStyle.Dashed);
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flagCreation == true && dessinActif == true)
            {
                dessinActif = false;

                Control control = (Control)sender;
                movePoint = control.PointToScreen(new Point(e.X, e.Y));

                // Taille minimale de WinShape acceptable.
                if ((movePoint.X <= shapeOrigine.X && movePoint.X > shapeOrigine.X - 10) || (movePoint.X >= shapeOrigine.X && movePoint.X < shapeOrigine.X + 10) ||
                    (movePoint.Y <= shapeOrigine.Y && movePoint.Y > shapeOrigine.Y - 10) || (movePoint.Y >= shapeOrigine.Y && movePoint.Y < shapeOrigine.Y + 10))
                {
                    Refresh();
                    return;
                }

                // Création et référencement du WinShape.
                using (FormSaisieSonShape formSonShape = new FormSaisieSonShape())
                {
                    if (formSonShape.ShowDialog() == DialogResult.OK)
                    {
                        string sonShape = formSonShape.sonShape;
                        Rectangle creaRect;
                        creaRect = GetRect(shapeOrigine, movePoint);
                        ControlPaint.DrawReversibleFrame(creaRect, Color.Transparent, FrameStyle.Dashed);

                        // Conversion en coordonnées client.
                        Point a = control.PointToClient(shapeOrigine);
                        Point b = control.PointToClient(movePoint);
                        creaRect = GetRect(a, b);

                        // Création d'un WinShape encadré.
                        creaShapesID++;
                        WinShape creaShape = new WinShape(creaRect.X, creaRect.Y, creaRect.Width, creaRect.Height, sonShape, creaShapesID, true);
                        pictureBoxEcran.Controls.Add(creaShape);
                        lstCreaShapes.Add(creaShape);
                    }
                }

            }
        }


        private void FormAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Alerter si l'on est en mode création.
            if (flagCreation == true)
            {
                using (FormAbandonCreation formAbandonCrea = new FormAbandonCreation())
                {
                    if (formAbandonCrea.ShowDialog() == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }


        private void FormAccueil_Layout(object sender, LayoutEventArgs e)
        {
            // Center the Form on the user's screen everytime it requires a Layout.
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
                this.Width, this.Height, BoundsSpecified.Location);
        }


        private void EmettreSpeech(SpeechSynthesizer SyntheseVocale, string texte)
        {
            SyntheseVocale.Rate = 0;
            SyntheseVocale.Speak(texte);
        }

    }
}
