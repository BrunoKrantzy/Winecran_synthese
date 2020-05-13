using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;


namespace WinecranFormsApp
{
    static class Program
    {
        // Gestion de la licence.
        public const string KEY_WINECRAN = "Software\\BDWESoft";
        public static bool LicenceInvalide = true;
        public static bool LicenceInvalideExit = false;

        // Pour permettre l'accès aux champs et fonctions du formulaire.
        public static FormAccueil formAccueil;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test de l'existence d'une licence (dans HKEY_CURRENT_USER).
            RegistryKey rKey = Registry.CurrentUser;
            RegistryKey winKey = rKey.OpenSubKey(KEY_WINECRAN);

            // Si winKey != null, une installation a déjà eu lieu.
            if (winKey != null)
            { 
                string sUsr = (string) winKey.GetValue("Usr");

                // Sans licence enregistrée sUsr == BDWESoft depuis l"installation.
                if (sUsr == "BDWESoft")
                {
                    DateTime installDate = Convert.ToDateTime(winKey.GetValue("DInstall"), new CultureInfo("fr-FR"));
                    TimeSpan diffDate = DateTime.Now - installDate;
                    if (diffDate.Days > 30)
                    {
                        MessageBox.Show("Votre période d'évaluation est terminée,\nvous devez acquérir une licence d'utilisation de Winecran", "Absence de licence");
                        LicenceInvalide = true;
                    }
                    else
                    {
                        int nbJours = 30 - diffDate.Days;
                        if (nbJours < 8)
                        {
                            MessageBox.Show(String.Format(new CultureInfo("fr-FR"), "Il vous reste {0} jours d'évaluation", nbJours), "Période d'évaluation");
                        }
                        LicenceInvalide = false;
                    }
                }
                else
                // tester la validité de la clé.
                {
                    string sLic = (string) winKey.GetValue("Lic");
                    bool licenceOK = verifieLicence(sUsr, sLic);
                    if (!licenceOK)
                    {
                        MessageBox.Show("Clé de licence non valide", "Absence de licence");
                        LicenceInvalide = true;
                    }
                    else
                    {
                        LicenceInvalide = false;
                    }
                }
                winKey.Close();
            }
            else
            // Si winKey == null, installer le système de licence dans le registre.
            {
                winKey = rKey.CreateSubKey(KEY_WINECRAN, true);
                winKey.OpenSubKey(KEY_WINECRAN, true);
                winKey.SetValue("DInstall", DateTime.Now);
                winKey.SetValue("Usr", "BDWESoft");
                winKey.SetValue("Lic", "BDWESoft");
                winKey.Close();
                LicenceInvalide = false;
            }

            // Si la licence est invalide.
            if (LicenceInvalide == true)
            {
                LicenceInvalideExit = true;
                using (FormAbout formAbout = new FormAbout())
                {
                    formAbout.ShowDialog();
                }

                // Enregistrement d'une éventuelle licence.
                using (FormLicenceWinecran formLicence = new FormLicenceWinecran())
                {
                    formLicence.ShowDialog();
                }
            }
            
            formAccueil = new FormAccueil();
            Application.Run(formAccueil);
        }


        public static bool verifieLicence(string User, string Licence)
        {
            int valKey = 0;
            int valLic;

            // On fabrique une chaine avec la clé secrète et le User.
            string sKey = "16071955" + User;
            string sLic = "";

            sKey = sKey.ToLower(new CultureInfo("fr-FR"));
            sKey = sKey.Trim();

            int lgKey = sKey.Length;
            for (int i = 0; i < lgKey; i++)
            {
                char c = sKey[i];
                // On supp. les espaces et 4 caractères pour compliquer le prob.
                if (c != 9 && c != 32 && c != 160 && c != 100 && c != 110 && c != 115 && c != 120)
                    valKey += c;
            }

            // De la licence on ne conserve que les chiffres dont on fait un entier.
            Licence = Licence.Trim();
            lgKey = Licence.Length;
            for (int i = 0; i < lgKey; i++)
            {
                char c = Licence[i];
                if (c >= 48 && c <= 57)
                    sLic += Licence[i];
            }

            // Vérifier que la licence est numérique.
            try
            {
                valLic = Convert.ToInt32(sLic, new CultureInfo("fr-FR"));
            }
            catch
            {
                return false;
            }

            // Les 2 entiers doivent être égaux.
            if (valKey == valLic)
                return true;
            else
                return false;
        }
    }
}
