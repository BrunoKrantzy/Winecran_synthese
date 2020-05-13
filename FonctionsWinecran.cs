using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;


namespace WinecranFormsApp
{
    public partial class FormAccueil : Form
    {     
        // Fontions complémentaires.

        public void UpdateScore()
        {
            if (nbQuestions == 0)
            {
                valScore = 100;
                textBoxScore.Text = valScore.ToString(new CultureInfo("fr-FR")) + " %";
            }
            else
            {
                decimal i = 100 * nbReponsesOK / nbQuestions;
                valScore = Decimal.ToInt32(Math.Floor(i));
                textBoxScore.Text = valScore.ToString(new CultureInfo("fr-FR")) + " %";
            }
        }


        private Rectangle GetRect(Point a, Point b)
        {
            rect = new Rectangle();
            rect.X = Math.Min(a.X, b.X);
            rect.Y = Math.Min(a.Y, b.Y);
            rect.Width = Math.Abs(a.X - b.X);
            rect.Height = Math.Abs(a.Y - b.Y);

            return rect;
        }

    }
}


