namespace WinecranFormsApp
{
    partial class FormAbandonCreation
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
            this.textBoxAbandon = new System.Windows.Forms.TextBox();
            this.buttonOKabandon = new System.Windows.Forms.Button();
            this.buttonAnnuleAbandon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAbandon
            // 
            this.textBoxAbandon.CausesValidation = false;
            this.textBoxAbandon.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxAbandon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbandon.Location = new System.Drawing.Point(17, 17);
            this.textBoxAbandon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAbandon.Multiline = true;
            this.textBoxAbandon.Name = "textBoxAbandon";
            this.textBoxAbandon.ReadOnly = true;
            this.textBoxAbandon.Size = new System.Drawing.Size(411, 106);
            this.textBoxAbandon.TabIndex = 0;
            this.textBoxAbandon.TabStop = false;
            this.textBoxAbandon.Text = "\r\nUn nouvel écran est en cours d\'édition\r\net il n\'a pas été sauvegardé.\r\n\r\nVoulez" +
    "-vous en abandonner les modifications ?\r\n";
            this.textBoxAbandon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOKabandon
            // 
            this.buttonOKabandon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOKabandon.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOKabandon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOKabandon.Location = new System.Drawing.Point(113, 148);
            this.buttonOKabandon.Name = "buttonOKabandon";
            this.buttonOKabandon.Size = new System.Drawing.Size(70, 32);
            this.buttonOKabandon.TabIndex = 1;
            this.buttonOKabandon.Text = "OUI";
            this.buttonOKabandon.UseVisualStyleBackColor = false;
            // 
            // buttonAnnuleAbandon
            // 
            this.buttonAnnuleAbandon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAnnuleAbandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuleAbandon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnuleAbandon.Location = new System.Drawing.Point(269, 148);
            this.buttonAnnuleAbandon.Name = "buttonAnnuleAbandon";
            this.buttonAnnuleAbandon.Size = new System.Drawing.Size(70, 32);
            this.buttonAnnuleAbandon.TabIndex = 1;
            this.buttonAnnuleAbandon.Text = "NON";
            this.buttonAnnuleAbandon.UseVisualStyleBackColor = false;
            // 
            // FormAbandonCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 201);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAnnuleAbandon);
            this.Controls.Add(this.buttonOKabandon);
            this.Controls.Add(this.textBoxAbandon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAbandonCreation";
            this.Text = "Écran en cours d\'édition";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormAbandonCreation_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbandon;
        private System.Windows.Forms.Button buttonOKabandon;
        private System.Windows.Forms.Button buttonAnnuleAbandon;
    }
}