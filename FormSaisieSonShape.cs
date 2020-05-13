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
    public partial class FormSaisieSonShape : Form
    {
        public string sonShape = String.Empty;

        public FormSaisieSonShape()
        {
            InitializeComponent();
        }

        private void textBoxSonShape_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSonShape.Text.Length != 0)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            sonShape = String.Empty;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            sonShape = textBoxSonShape.Text;
        }
    }
}
