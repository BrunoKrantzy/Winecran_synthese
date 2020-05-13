using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace WinecranFormsApp
{
    public partial class FormSauvegardeCreation : Form
    {
        public FormSauvegardeCreation()
        {
            InitializeComponent();
            // Proposer par défaut un nom d'écran .czs.
            string nomBMP = Path.GetFileNameWithoutExtension(Program.formAccueil.creaPicture);
            string nomPath = Path.GetDirectoryName(Program.formAccueil.creaPicture);
            string nomEcran = nomPath + "\\" + nomBMP + ".czs";
            textBoxNomEcran.Text = nomEcran;
        }


        private void buttonNomEcran_Click(object sender, EventArgs e)
        {
            if (saveEcranCZS.ShowDialog() == DialogResult.OK)
            {
                textBoxNomEcran.Text = saveEcranCZS.FileName;
            }
        }


        private void textBoxNomEcran_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNomEcran.Text))
            {
                textBoxNomEcran.Tag = true;
            }
            else
            {
                textBoxNomEcran.Tag = false;
            }
            testDesTags();
        }


        private void textBoxPrefixe_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPrefixe.Text))
            {
                textBoxPrefixe.Tag = true;
                buttonPlayIQ.Enabled = true;
            }
            else
            {
                textBoxPrefixe.Tag = false;
                buttonPlayIQ.Enabled = false;
            }
            testDesTags();
        }


        private void textBoxBonneRep_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBonneRep.Text))
            {
                textBoxBonneRep.Tag = true;
                buttonPlayBR.Enabled = true;
            }
            else
            {
                textBoxBonneRep.Tag = false;
                buttonPlayBR.Enabled = false;
            }
            testDesTags();
        }


        private void textBoxMauvaiseRep_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMauvaiseRep.Text))
            {
                textBoxMauvaiseRep.Tag = true;
                buttonPlayMR.Enabled = true;
            }
            else
            {
                textBoxMauvaiseRep.Tag = false;
                buttonPlayMR.Enabled = false;
            }
            testDesTags();
        }


        private void buttonPlayIQ_Click(object sender, EventArgs e)
        {
            using (SpeechSynthesizer SyntheseVocale = new SpeechSynthesizer())
            {
                try
                {
                    EmettreSpeech(SyntheseVocale, textBoxPrefixe.Text);
                }
                catch
                {
                    MessageBox.Show($"Le texte \"{textBoxPrefixe.Text}\" ne peut être lu par la synthèse vocale\nERRWS143\n\n", "Synthèse vocale");
                    textBoxPrefixe.Text = "";
                    textBoxPrefixe.Tag = false;
                    buttonPlayIQ.Enabled = false;
                    return;
                }
            }
        }


        private void buttonPlayBR_Click(object sender, EventArgs e)
        {
            using (SpeechSynthesizer SyntheseVocale = new SpeechSynthesizer())
            {
                try
                {
                    EmettreSpeech(SyntheseVocale, textBoxBonneRep.Text);
                }
                catch
                {
                    MessageBox.Show($"Le texte \"{textBoxBonneRep.Text}\" ne peut être lu par la synthèse vocale\nERRWS143\n\n", "Synthèse vocale");
                    textBoxBonneRep.Text = "";
                    textBoxBonneRep.Tag = false;
                    buttonPlayBR.Enabled = false;
                    return;
                }
            }
        }


        private void buttonPlayMR_Click(object sender, EventArgs e)
        {
            using (SpeechSynthesizer SyntheseVocale = new SpeechSynthesizer())
            {
                try
                {
                    EmettreSpeech(SyntheseVocale, textBoxMauvaiseRep.Text);
                }
                catch
                {
                    MessageBox.Show($"Le texte \"{textBoxMauvaiseRep.Text}\" ne peut être lu par la synthèse vocale\nERRWS184\n\n", "Synthèse vocale");
                    textBoxMauvaiseRep.Text = "";
                    textBoxMauvaiseRep.Tag = false;
                    buttonPlayMR.Enabled = false;
                    return;
                }
            }

        }


        private void testDesTags()
        {
            if (textBoxNomEcran.Tag is true && textBoxPrefixe.Tag is true
                && textBoxBonneRep.Tag is true && textBoxMauvaiseRep.Tag is true)
            {
                buttonOK.Enabled = true;
            }
            else
            {
                buttonOK.Enabled = false;
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string theShapes = String.Empty;

            // Associe le fichier à un stream.
            var fileStream = File.Create(textBoxNomEcran.Text);

            using (StreamWriter sw = new StreamWriter(fileStream, Encoding.GetEncoding(1252)))
            {
                try
                {
                    sw.WriteLine(Program.formAccueil.creaPicture);
                    sw.WriteLine(textBoxPrefixe.Text);
                    sw.WriteLine(textBoxBonneRep.Text);
                    sw.WriteLine(textBoxMauvaiseRep.Text);
                }
                catch
                {
                    MessageBox.Show("Erreur(s) lors de la sauvegarde de l'écran.\nERRFSC238", "Sauvegarder un écran");
                    return;
                }

                // Ecriture des données de chaque WinShape
                Program.formAccueil.lstCreaShapes.ForEach(writeShapesIn);

                // Fermeture du StreamWriter
                sw.Flush();
                sw.Close();

                // fonction locale utilisée par listeShapes.ForEach(Action <T>)
                void writeShapesIn(WinShape shape)
                {
                    try
                    {
                        IFormatProvider provider = new CultureInfo("fr-FR");
                        StringBuilder shapeLine = new StringBuilder(shape.PosX.ToString(provider) + '$');
                        shapeLine.Append(shape.PosY.ToString(provider) + '$');
                        shapeLine.Append(shape.ShapeWidth.ToString(provider) + '$');
                        shapeLine.Append(shape.ShapeHeight.ToString(provider) + '$');
                        shapeLine.Append(shape.SonWav);
                        sw.WriteLine(shapeLine);
                    }
                    catch
                    {
                        MessageBox.Show("Erreur(s) lors de la sauvegarde de l'écran.\nERRFSC264", "Sauvegarder un écran");
                        return;
                    }
                }
            }

            Program.formAccueil.flagCreation = false;
            MessageBox.Show("Votre écran a bien été sauvegardé.", "Sauvegarder un écran");
        }


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            return;
        }


        private void FormSauvegardeCreation_Layout(object sender, LayoutEventArgs e)
        {
            // Center the Form on the user's screen everytime it requires a Layout.
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
                this.Width, this.Height, BoundsSpecified.Location);
        }


        private void EmettreSpeech(SpeechSynthesizer SyntheseVocale, string texte)
        {
            SyntheseVocale.SetOutputToDefaultAudioDevice();
            SyntheseVocale.Rate = 1;
            SyntheseVocale.Speak(texte);
        }

    }
}

