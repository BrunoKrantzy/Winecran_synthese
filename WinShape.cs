using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace WinecranFormsApp
{
    public class WinShape : Panel
    {
        private readonly bool modeCreation = false;

        public int ShapeID
        { get; set; } = -1;

        public string SonWav
        { get; set; }

        public int PosX
        { get; set; }

        public int PosY
        { get; set; }

        public int ShapeWidth
        { get; set; }

        public int ShapeHeight
        { get; set; }

        public WinShape(int x, int y, int w, int h, string aWav, int id, bool mode)
        {
            // Identifiant du WinShape
            ShapeID = id;

            // Encadrement si création
            modeCreation = mode;

            // Son associé au WinShape
            SonWav = aWav;

            PosX = x;
            PosY = y;
            ShapeWidth = w;
            ShapeHeight = h;

            // Positionne le WinShape.
            SetBounds(PosX, PosY, ShapeWidth, ShapeHeight);
            BackColor = Color.Transparent;

            // Associer une fonction dédiée à l'événement MouseClick.
            MouseClick += new MouseEventHandler(WinShape_MouseClick);
            // Associer une fonction dédiée à l'événement Paint.
            Paint += new PaintEventHandler(WinShape_Paint);

            // Pour contrer le problème de flickering en mode création
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            // Modification du curseur.
            Cursor = Cursors.Hand;
        }

        
        // Pour contrer le problème de flickering en mode création
        // (autre solution fonctionnelle).
        /*
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        */


        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Fixer la position et la taille du WinShape.
            base.SetBoundsCore(PosX, PosY, ShapeWidth, ShapeHeight, specified);
        }


        private void WinShape_MouseClick(Object sender, MouseEventArgs e)
        {
            // Sauvegarder le Clip du curseur.
            Rectangle SavedClip = Cursor.Clip;

            // Infos de position du formulaire d'application à l'écran.
            Point aP = new Point(Width / 2, Height + 3);
            Point bP = PointToScreen(aP);
            Cursor.Position = bP;

            // Gel de la position du curseur.
            Cursor.Clip = new Rectangle(Cursor.Position, new Size(1, 1));

            // Emission du son associé.
            using (SpeechSynthesizer SyntheseVocale = new SpeechSynthesizer())
            {
                SyntheseVocale.SetOutputToDefaultAudioDevice();

                try
                {
                    EmettreSpeech(SyntheseVocale, SonWav);
                }
                catch
                {
                    // Rétablissement du Clip du curseur.
                    Cursor.Clip = SavedClip;
                    MessageBox.Show($"Le texte \"{SonWav}\" ne peut être lu par la synthèse vocale\nERRWS143\n\n", "Synthèse vocale");
                    return;
                }

                // En mode Question/Réponse.
                if (Program.formAccueil.flagQuestion == true)
                {
                    Program.formAccueil.numReponse = ShapeID;

                    if (ShapeID != Program.formAccueil.numTirage)
                    {
                        try
                        {
                            EmettreSpeech(SyntheseVocale, Program.formAccueil.ecranCZS.SonErreur);
                        }
                        catch
                        {
                            // Rétablissement du Clip du curseur.
                            Cursor.Clip = SavedClip;
                            MessageBox.Show($"Le texte \"{Program.formAccueil.ecranCZS.SonErreur}\" ne peut être lu par la synthèse vocale\nERRWS164\n\n", "Synthèse vocale");
                            return;
                        }

                        // Réponse fausse, on repose la question.
                        Program.formAccueil.questionnerClick(this, new System.EventArgs());
                    }
                    else
                    {
                        Program.formAccueil.nbReponsesOK++;

                        try
                        {
                            EmettreSpeech(SyntheseVocale, Program.formAccueil.ecranCZS.SonExact);
                        }
                        catch
                        {
                            // Rétablissement du Clip du curseur.
                            Cursor.Clip = SavedClip;
                            MessageBox.Show($"Le texte \"{Program.formAccueil.ecranCZS.SonExact}\" ne peut être lu par la synthèse vocale\nERRWS185\n\n", "Synthèse vocale");
                            return;
                        }
                    // Réponse exacte, question suivante.
                    Program.formAccueil.numReponse = -1;
                    Program.formAccueil.questionnerClick(this, new System.EventArgs());
                    }
                }
            }

            // Rétablissement du Clip du curseur.
            Cursor.Clip = SavedClip;
        }


        // Encadrement du WinShape en mode création
        private void WinShape_Paint(object sender, PaintEventArgs e)
        {
            if (modeCreation == true)
            {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
        }

        
        private void EmettreSpeech(SpeechSynthesizer SyntheseVocale, string texte)
        {
            SyntheseVocale.Rate = 0;
            SyntheseVocale.Speak(texte);
        }

    }
}

