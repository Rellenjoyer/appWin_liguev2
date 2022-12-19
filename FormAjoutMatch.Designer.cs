namespace appWin_liguev2
{
    partial class FormAjoutMatch
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
            this.comboBoxEquipe1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipe2 = new System.Windows.Forms.ComboBox();
            this.labelEquipe1 = new System.Windows.Forms.Label();
            this.labelEquipe2 = new System.Windows.Forms.Label();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEquipe1
            // 
            this.comboBoxEquipe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipe1.FormattingEnabled = true;
            this.comboBoxEquipe1.Location = new System.Drawing.Point(56, 92);
            this.comboBoxEquipe1.Name = "comboBoxEquipe1";
            this.comboBoxEquipe1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipe1.TabIndex = 0;
            // 
            // comboBoxEquipe2
            // 
            this.comboBoxEquipe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipe2.FormattingEnabled = true;
            this.comboBoxEquipe2.Location = new System.Drawing.Point(373, 92);
            this.comboBoxEquipe2.Name = "comboBoxEquipe2";
            this.comboBoxEquipe2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipe2.TabIndex = 1;
            // 
            // labelEquipe1
            // 
            this.labelEquipe1.AutoSize = true;
            this.labelEquipe1.Location = new System.Drawing.Point(90, 52);
            this.labelEquipe1.Name = "labelEquipe1";
            this.labelEquipe1.Size = new System.Drawing.Size(49, 13);
            this.labelEquipe1.TabIndex = 2;
            this.labelEquipe1.Text = "Équipe 1";
            // 
            // labelEquipe2
            // 
            this.labelEquipe2.AutoSize = true;
            this.labelEquipe2.Location = new System.Drawing.Point(399, 52);
            this.labelEquipe2.Name = "labelEquipe2";
            this.labelEquipe2.Size = new System.Drawing.Size(49, 13);
            this.labelEquipe2.TabIndex = 3;
            this.labelEquipe2.Text = "Équipe 2";
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Location = new System.Drawing.Point(214, 166);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(124, 40);
            this.buttonConfirmer.TabIndex = 4;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // FormAjoutMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 289);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.labelEquipe2);
            this.Controls.Add(this.labelEquipe1);
            this.Controls.Add(this.comboBoxEquipe2);
            this.Controls.Add(this.comboBoxEquipe1);
            this.Name = "FormAjoutMatch";
            this.Text = "Créer un match";
            this.Load += new System.EventHandler(this.FormAjoutMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEquipe1;
        private System.Windows.Forms.ComboBox comboBoxEquipe2;
        private System.Windows.Forms.Label labelEquipe1;
        private System.Windows.Forms.Label labelEquipe2;
        private System.Windows.Forms.Button buttonConfirmer;
    }
}