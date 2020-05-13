namespace WinecranFormsApp
{
    partial class FormLicenceWinecran
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
            this.pictureBoxLicence = new System.Windows.Forms.PictureBox();
            this.labelNomUser = new System.Windows.Forms.Label();
            this.labelNumLicence = new System.Windows.Forms.Label();
            this.labelTxtLicence = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxLicence = new System.Windows.Forms.TextBox();
            this.buttonOkLicence = new System.Windows.Forms.Button();
            this.buttonAnnulerLicence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicence)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLicence
            // 
            this.pictureBoxLicence.Image = global::WinecranFormsApp.Properties.Resources.about;
            this.pictureBoxLicence.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLicence.Name = "pictureBoxLicence";
            this.pictureBoxLicence.Size = new System.Drawing.Size(453, 80);
            this.pictureBoxLicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLicence.TabIndex = 0;
            this.pictureBoxLicence.TabStop = false;
            // 
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(9, 168);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(73, 18);
            this.labelNomUser.TabIndex = 1;
            this.labelNomUser.Text = "Utilisateur";
            // 
            // labelNumLicence
            // 
            this.labelNumLicence.AutoSize = true;
            this.labelNumLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumLicence.Location = new System.Drawing.Point(9, 212);
            this.labelNumLicence.Name = "labelNumLicence";
            this.labelNumLicence.Size = new System.Drawing.Size(95, 18);
            this.labelNumLicence.TabIndex = 2;
            this.labelNumLicence.Text = "N° de licence";
            // 
            // labelTxtLicence
            // 
            this.labelTxtLicence.AutoSize = true;
            this.labelTxtLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtLicence.Location = new System.Drawing.Point(40, 108);
            this.labelTxtLicence.Name = "labelTxtLicence";
            this.labelTxtLicence.Size = new System.Drawing.Size(388, 24);
            this.labelTxtLicence.TabIndex = 3;
            this.labelTxtLicence.Text = "Enregistrement de la licence d\'utilisation";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(111, 164);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(317, 26);
            this.textBoxUser.TabIndex = 4;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // textBoxLicence
            // 
            this.textBoxLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicence.Location = new System.Drawing.Point(111, 208);
            this.textBoxLicence.Name = "textBoxLicence";
            this.textBoxLicence.Size = new System.Drawing.Size(317, 26);
            this.textBoxLicence.TabIndex = 5;
            this.textBoxLicence.TextChanged += new System.EventHandler(this.textBoxLicence_TextChanged);
            // 
            // buttonOkLicence
            // 
            this.buttonOkLicence.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOkLicence.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkLicence.Enabled = false;
            this.buttonOkLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkLicence.Location = new System.Drawing.Point(148, 260);
            this.buttonOkLicence.Name = "buttonOkLicence";
            this.buttonOkLicence.Size = new System.Drawing.Size(75, 32);
            this.buttonOkLicence.TabIndex = 6;
            this.buttonOkLicence.Text = "OK";
            this.buttonOkLicence.UseVisualStyleBackColor = false;
            this.buttonOkLicence.Click += new System.EventHandler(this.buttonOkLicence_Click);
            // 
            // buttonAnnulerLicence
            // 
            this.buttonAnnulerLicence.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAnnulerLicence.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnulerLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerLicence.Location = new System.Drawing.Point(270, 260);
            this.buttonAnnulerLicence.Name = "buttonAnnulerLicence";
            this.buttonAnnulerLicence.Size = new System.Drawing.Size(75, 32);
            this.buttonAnnulerLicence.TabIndex = 7;
            this.buttonAnnulerLicence.Text = "Annuler";
            this.buttonAnnulerLicence.UseVisualStyleBackColor = false;
            this.buttonAnnulerLicence.Click += new System.EventHandler(this.buttonAnnulerLicence_Click);
            // 
            // FormLicenceWinecran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 314);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAnnulerLicence);
            this.Controls.Add(this.buttonOkLicence);
            this.Controls.Add(this.textBoxLicence);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelTxtLicence);
            this.Controls.Add(this.labelNumLicence);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.pictureBoxLicence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLicenceWinecran";
            this.Text = "Licence utilisateur";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormLicenceWinecran_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLicence;
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.Label labelNumLicence;
        private System.Windows.Forms.Label labelTxtLicence;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxLicence;
        private System.Windows.Forms.Button buttonOkLicence;
        private System.Windows.Forms.Button buttonAnnulerLicence;
    }
}