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
    public partial class FormAbandonCreation : Form
    {
        public FormAbandonCreation()
        {
            InitializeComponent();
        }

        private void FormAbandonCreation_Layout(object sender, LayoutEventArgs e)
        {
            // Center the Form on the user's screen everytime it requires a Layout.
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
                this.Width, this.Height, BoundsSpecified.Location);
        }
    }
}
