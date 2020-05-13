using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinecranFormsApp
{
    public partial class FormLicenceWinecran : Form
    {
        public FormLicenceWinecran()
        {
            InitializeComponent();

            // Tester le registre.
            RegistryKey rKey = Registry.CurrentUser;
            RegistryKey winKey = rKey.OpenSubKey(Program.KEY_WINECRAN);

            if (winKey != null)
            {
                string sUsr = (string) winKey.GetValue("Usr");
                string sLic = (string) winKey.GetValue("Lic");
                winKey.Close();

                if (sUsr != "BDWESoft")
                {
                    if (Program.verifieLicence(sUsr, sLic))
                    {
                        textBoxUser.Text = sUsr;
                        textBoxLicence.Text = sLic;
                        textBoxUser.Enabled = false;
                        textBoxLicence.Enabled = false;
                        buttonOkLicence.Enabled = false;
                        Program.LicenceInvalide = false;
                    }
                    else
                    {
                        textBoxUser.Enabled = true;
                        textBoxLicence.Enabled = true;
                        Program.LicenceInvalide = true;
                    }
                }
            }
        }


        private void buttonOkLicence_Click(object sender, EventArgs e)
        {
            bool isKeyOK = false;

            // Tester la validité de la clé
            if (Program.verifieLicence(textBoxUser.Text, textBoxLicence.Text))
            {
                isKeyOK = true;
                Program.LicenceInvalide = false;
            }

            if (isKeyOK == true)
            {
                RegistryKey rKey = Registry.CurrentUser;
                RegistryKey winKey = rKey.OpenSubKey(Program.KEY_WINECRAN, true);

                if (winKey != null)
                {
                    winKey.SetValue("Usr", textBoxUser.Text);
                    winKey.SetValue("Lic", textBoxLicence.Text);
                    winKey.Close();
                }
                textBoxUser.Enabled = false;
                textBoxLicence.Enabled = false;
                buttonOkLicence.Enabled = false;
            }
            else
            {
                MessageBox.Show("Codes d'enregistrement non valides.\nVérifiez votre saisie.", "Gestionnaire de licence");
                if (Program.formAccueil != null)
                {
                    Program.formAccueil.licenceItem.Enabled = true;
                }                
            }
        }


        private void buttonAnnulerLicence_Click(object sender, EventArgs e)
        {
            if (Program.LicenceInvalideExit == false)
            {
                Program.formAccueil.licenceItem.Enabled = true;
            }
        }


        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUser.Text) && !string.IsNullOrWhiteSpace(textBoxLicence.Text))
                buttonOkLicence.Enabled = true;
            else
                buttonOkLicence.Enabled = false;
        }


        private void textBoxLicence_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUser.Text) && !string.IsNullOrWhiteSpace(textBoxLicence.Text))
                buttonOkLicence.Enabled = true;
            else
                buttonOkLicence.Enabled = false;
        }

        private void FormLicenceWinecran_Layout(object sender, LayoutEventArgs e)
        {
            // Center the Form on the user's screen everytime it requires a Layout.
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
                this.Width, this.Height, BoundsSpecified.Location);
        }
    }
}
