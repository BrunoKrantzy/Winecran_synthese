namespace WinecranFormsApp
{
    partial class FormSauvegardeCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomEcran = new System.Windows.Forms.Label();
            this.labelPrefixe = new System.Windows.Forms.Label();
            this.labelBonneRep = new System.Windows.Forms.Label();
            this.labelMauvaiseRep = new System.Windows.Forms.Label();
            this.textBoxNomEcran = new System.Windows.Forms.TextBox();
            this.textBoxPrefixe = new System.Windows.Forms.TextBox();
            this.textBoxBonneRep = new System.Windows.Forms.TextBox();
            this.textBoxMauvaiseRep = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.saveEcranCZS = new System.Windows.Forms.SaveFileDialog();
            this.labelSelectionWav = new System.Windows.Forms.Label();
            this.selectFileWav = new System.Windows.Forms.OpenFileDialog();
            this.buttonNomEcran = new System.Windows.Forms.Button();
            this.buttonPlayMR = new System.Windows.Forms.Button();
            this.buttonPlayBR = new System.Windows.Forms.Button();
            this.buttonPlayIQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomEcran
            // 
            this.labelNomEcran.AutoSize = true;
            this.labelNomEcran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEcran.Location = new System.Drawing.Point(83, 41);
            this.labelNomEcran.Name = "labelNomEcran";
            this.labelNomEcran.Size = new System.Drawing.Size(133, 16);
            this.labelNomEcran.TabIndex = 0;
            this.labelNomEcran.Text = "Nom de l\'écran (.czs)";
            // 
            // labelPrefixe
            // 
            this.labelPrefixe.AutoSize = true;
            this.labelPrefixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefixe.Location = new System.Drawing.Point(32, 148);
            this.labelPrefixe.Name = "labelPrefixe";
            this.labelPrefixe.Size = new System.Drawing.Size(145, 16);
            this.labelPrefixe.TabIndex = 1;
            this.labelPrefixe.Text = "Préfixe des questions  :";
            // 
            // labelBonneRep
            // 
            this.labelBonneRep.AutoSize = true;
            this.labelBonneRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonneRep.Location = new System.Drawing.Point(68, 205);
            this.labelBonneRep.Name = "labelBonneRep";
            this.labelBonneRep.Size = new System.Drawing.Size(106, 16);
            this.labelBonneRep.TabIndex = 2;
            this.labelBonneRep.Text = "Bonne réponse :";
            // 
            // labelMauvaiseRep
            // 
            this.labelMauvaiseRep.AutoSize = true;
            this.labelMauvaiseRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMauvaiseRep.Location = new System.Drawing.Point(48, 268);
            this.labelMauvaiseRep.Name = "labelMauvaiseRep";
            this.labelMauvaiseRep.Size = new System.Drawing.Size(126, 16);
            this.labelMauvaiseRep.TabIndex = 3;
            this.labelMauvaiseRep.Text = "Mauvaise réponse :";
            // 
            // textBoxNomEcran
            // 
            this.textBoxNomEcran.Location = new System.Drawing.Point(270, 40);
            this.textBoxNomEcran.Name = "textBoxNomEcran";
            this.textBoxNomEcran.Size = new System.Drawing.Size(265, 20);
            this.textBoxNomEcran.TabIndex = 4;
            this.textBoxNomEcran.TextChanged += new System.EventHandler(this.textBoxNomEcran_TextChanged);
            // 
            // textBoxPrefixe
            // 
            this.textBoxPrefixe.Location = new System.Drawing.Point(183, 148);
            this.textBoxPrefixe.Name = "textBoxPrefixe";
            this.textBoxPrefixe.Size = new System.Drawing.Size(352, 20);
            this.textBoxPrefixe.TabIndex = 5;
            this.textBoxPrefixe.TextChanged += new System.EventHandler(this.textBoxPrefixe_TextChanged);
            // 
            // textBoxBonneRep
            // 
            this.textBoxBonneRep.Location = new System.Drawing.Point(183, 205);
            this.textBoxBonneRep.Name = "textBoxBonneRep";
            this.textBoxBonneRep.Size = new System.Drawing.Size(352, 20);
            this.textBoxBonneRep.TabIndex = 6;
            this.textBoxBonneRep.TextChanged += new System.EventHandler(this.textBoxBonneRep_TextChanged);
            // 
            // textBoxMauvaiseRep
            // 
            this.textBoxMauvaiseRep.Location = new System.Drawing.Point(183, 267);
            this.textBoxMauvaiseRep.Name = "textBoxMauvaiseRep";
            this.textBoxMauvaiseRep.Size = new System.Drawing.Size(352, 20);
            this.textBoxMauvaiseRep.TabIndex = 7;
            this.textBoxMauvaiseRep.TextChanged += new System.EventHandler(this.textBoxMauvaiseRep_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(218, 325);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 32);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(389, 325);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 32);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // saveEcranCZS
            // 
            this.saveEcranCZS.Filter = "Fichier CZS|*.czs";
            this.saveEcranCZS.InitialDirectory = "./ecrans";
            this.saveEcranCZS.Title = "Sauvegarder l\'écran créé";
            // 
            // labelSelectionWav
            // 
            this.labelSelectionWav.AutoSize = true;
            this.labelSelectionWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectionWav.Location = new System.Drawing.Point(115, 96);
            this.labelSelectionWav.Name = "labelSelectionWav";
            this.labelSelectionWav.Size = new System.Drawing.Size(425, 24);
            this.labelSelectionWav.TabIndex = 17;
            this.labelSelectionWav.Text = "Saisie des textes du mode question/réponse";
            // 
            // selectFileWav
            // 
            this.selectFileWav.Filter = "Fichier son|*.wav";
            // 
            // buttonNomEcran
            // 
            this.buttonNomEcran.Image = global::WinecranFormsApp.Properties.Resources.dossier;
            this.buttonNomEcran.Location = new System.Drawing.Point(229, 33);
            this.buttonNomEcran.Name = "buttonNomEcran";
            this.buttonNomEcran.Size = new System.Drawing.Size(32, 32);
            this.buttonNomEcran.TabIndex = 1;
            this.buttonNomEcran.UseVisualStyleBackColor = true;
            this.buttonNomEcran.Click += new System.EventHandler(this.buttonNomEcran_Click);
            // 
            // buttonPlayMR
            // 
            this.buttonPlayMR.Enabled = false;
            this.buttonPlayMR.Image = global::WinecranFormsApp.Properties.Resources.ecouter;
            this.buttonPlayMR.Location = new System.Drawing.Point(544, 260);
            this.buttonPlayMR.Name = "buttonPlayMR";
            this.buttonPlayMR.Size = new System.Drawing.Size(32, 32);
            this.buttonPlayMR.TabIndex = 7;
            this.buttonPlayMR.UseVisualStyleBackColor = true;
            this.buttonPlayMR.Click += new System.EventHandler(this.buttonPlayMR_Click);
            // 
            // buttonPlayBR
            // 
            this.buttonPlayBR.Enabled = false;
            this.buttonPlayBR.Image = global::WinecranFormsApp.Properties.Resources.ecouter;
            this.buttonPlayBR.Location = new System.Drawing.Point(544, 199);
            this.buttonPlayBR.Name = "buttonPlayBR";
            this.buttonPlayBR.Size = new System.Drawing.Size(32, 32);
            this.buttonPlayBR.TabIndex = 5;
            this.buttonPlayBR.UseVisualStyleBackColor = true;
            this.buttonPlayBR.Click += new System.EventHandler(this.buttonPlayBR_Click);
            // 
            // buttonPlayIQ
            // 
            this.buttonPlayIQ.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPlayIQ.Enabled = false;
            this.buttonPlayIQ.Image = global::WinecranFormsApp.Properties.Resources.ecouter;
            this.buttonPlayIQ.Location = new System.Drawing.Point(544, 143);
            this.buttonPlayIQ.Name = "buttonPlayIQ";
            this.buttonPlayIQ.Size = new System.Drawing.Size(32, 32);
            this.buttonPlayIQ.TabIndex = 3;
            this.buttonPlayIQ.UseVisualStyleBackColor = false;
            this.buttonPlayIQ.Click += new System.EventHandler(this.buttonPlayIQ_Click);
            // 
            // FormSauvegardeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.buttonAnnuler;
            this.ClientSize = new System.Drawing.Size(649, 392);
            this.ControlBox = false;
            this.Controls.Add(this.labelSelectionWav);
            this.Controls.Add(this.buttonNomEcran);
            this.Controls.Add(this.buttonPlayMR);
            this.Controls.Add(this.buttonPlayBR);
            this.Controls.Add(this.buttonPlayIQ);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxMauvaiseRep);
            this.Controls.Add(this.textBoxBonneRep);
            this.Controls.Add(this.textBoxPrefixe);
            this.Controls.Add(this.textBoxNomEcran);
            this.Controls.Add(this.labelMauvaiseRep);
            this.Controls.Add(this.labelBonneRep);
            this.Controls.Add(this.labelPrefixe);
            this.Controls.Add(this.labelNomEcran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormSauvegardeCreation";
            this.Text = "Sauvegarde de l\'écran";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormSauvegardeCreation_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomEcran;
        private System.Windows.Forms.Label labelPrefixe;
        private System.Windows.Forms.Label labelBonneRep;
        private System.Windows.Forms.Label labelMauvaiseRep;
        private System.Windows.Forms.TextBox textBoxNomEcran;
        private System.Windows.Forms.TextBox textBoxPrefixe;
        private System.Windows.Forms.TextBox textBoxBonneRep;
        private System.Windows.Forms.TextBox textBoxMauvaiseRep;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.SaveFileDialog saveEcranCZS;
        private System.Windows.Forms.Button buttonPlayIQ;
        private System.Windows.Forms.Button buttonPlayBR;
        private System.Windows.Forms.Button buttonPlayMR;
        private System.Windows.Forms.Button buttonNomEcran;
        private System.Windows.Forms.Label labelSelectionWav;
        private System.Windows.Forms.OpenFileDialog selectFileWav;
    }
}