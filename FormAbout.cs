using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinecranFormsApp
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }


        private void buttonAboutOK_Click(object sender, EventArgs e)
        {
            if (Program.LicenceInvalideExit == false)
            {
                Program.formAccueil.aProposItem.Enabled = true;
            }
        }


        private void linkLabelAchat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://winecran.pagesperso-orange.fr/services/download.html");
        }


        private void linkLabelContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://winecran.pagesperso-orange.fr/index.html");
        }


        private void FormAbout_Layout(object sender, LayoutEventArgs e)
        {
            // Center the Form on the user's screen everytime it requires a Layout.
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
                this.Width, this.Height, BoundsSpecified.Location);
        }
    }
}
