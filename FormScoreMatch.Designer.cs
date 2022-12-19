namespace appWin_liguev2
{
    partial class FormScoreMatch
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
            this.labelEquipe1 = new System.Windows.Forms.Label();
            this.labelEquipe2 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelVs = new System.Windows.Forms.Label();
            this.comboBoxNum1 = new System.Windows.Forms.ComboBox();
            this.comboBoxNum2 = new System.Windows.Forms.ComboBox();
            this.labelLocal2 = new System.Windows.Forms.Label();
            this.labelVisiteur2 = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisiteur = new System.Windows.Forms.Label();
            this.buttonVisiteur = new System.Windows.Forms.Button();
            this.buttonLocal = new System.Windows.Forms.Button();
            this.labelNom1 = new System.Windows.Forms.Label();
            this.labelPrenom1 = new System.Windows.Forms.Label();
            this.labelPrenom2 = new System.Windows.Forms.Label();
            this.labelNom2 = new System.Windows.Forms.Label();
            this.buttonFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEquipe1
            // 
            this.labelEquipe1.AutoSize = true;
            this.labelEquipe1.Location = new System.Drawing.Point(225, 71);
            this.labelEquipe1.Name = "labelEquipe1";
            this.labelEquipe1.Size = new System.Drawing.Size(49, 13);
            this.labelEquipe1.TabIndex = 0;
            this.labelEquipe1.Text = "Équipe 1";
            // 
            // labelEquipe2
            // 
            this.labelEquipe2.AutoSize = true;
            this.labelEquipe2.Location = new System.Drawing.Point(456, 71);
            this.labelEquipe2.Name = "labelEquipe2";
            this.labelEquipe2.Size = new System.Drawing.Size(49, 13);
            this.labelEquipe2.TabIndex = 1;
            this.labelEquipe2.Text = "Équipe 2";
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.Location = new System.Drawing.Point(238, 111);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(13, 13);
            this.labelScore1.TabIndex = 2;
            this.labelScore1.Text = "0";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Location = new System.Drawing.Point(469, 111);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(13, 13);
            this.labelScore2.TabIndex = 3;
            this.labelScore2.Text = "0";
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Location = new System.Drawing.Point(352, 88);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(21, 13);
            this.labelVs.TabIndex = 4;
            this.labelVs.Text = "VS";
            // 
            // comboBoxNum1
            // 
            this.comboBoxNum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNum1.FormattingEnabled = true;
            this.comboBoxNum1.Location = new System.Drawing.Point(68, 210);
            this.comboBoxNum1.Name = "comboBoxNum1";
            this.comboBoxNum1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNum1.TabIndex = 5;
            this.comboBoxNum1.SelectedIndexChanged += new System.EventHandler(this.comboBoxNum1_SelectedIndexChanged);
            // 
            // comboBoxNum2
            // 
            this.comboBoxNum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNum2.FormattingEnabled = true;
            this.comboBoxNum2.Location = new System.Drawing.Point(546, 210);
            this.comboBoxNum2.Name = "comboBoxNum2";
            this.comboBoxNum2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNum2.TabIndex = 6;
            this.comboBoxNum2.SelectedIndexChanged += new System.EventHandler(this.comboBoxNum2_SelectedIndexChanged);
            // 
            // labelLocal2
            // 
            this.labelLocal2.AutoSize = true;
            this.labelLocal2.Location = new System.Drawing.Point(108, 171);
            this.labelLocal2.Name = "labelLocal2";
            this.labelLocal2.Size = new System.Drawing.Size(33, 13);
            this.labelLocal2.TabIndex = 7;
            this.labelLocal2.Text = "Local";
            // 
            // labelVisiteur2
            // 
            this.labelVisiteur2.AutoSize = true;
            this.labelVisiteur2.Location = new System.Drawing.Point(584, 171);
            this.labelVisiteur2.Name = "labelVisiteur2";
            this.labelVisiteur2.Size = new System.Drawing.Size(41, 13);
            this.labelVisiteur2.TabIndex = 8;
            this.labelVisiteur2.Text = "Visiteur";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(210, 29);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(75, 13);
            this.labelLocal.TabIndex = 9;
            this.labelLocal.Text = "Équipe Locale";
            // 
            // labelVisiteur
            // 
            this.labelVisiteur.AutoSize = true;
            this.labelVisiteur.Location = new System.Drawing.Point(443, 29);
            this.labelVisiteur.Name = "labelVisiteur";
            this.labelVisiteur.Size = new System.Drawing.Size(76, 13);
            this.labelVisiteur.TabIndex = 10;
            this.labelVisiteur.Text = "Équipe visiteur";
            // 
            // buttonVisiteur
            // 
            this.buttonVisiteur.Location = new System.Drawing.Point(577, 328);
            this.buttonVisiteur.Name = "buttonVisiteur";
            this.buttonVisiteur.Size = new System.Drawing.Size(75, 23);
            this.buttonVisiteur.TabIndex = 11;
            this.buttonVisiteur.Text = "But Visiteur";
            this.buttonVisiteur.UseVisualStyleBackColor = true;
            this.buttonVisiteur.Click += new System.EventHandler(this.buttonVisiteur_Click);
            // 
            // buttonLocal
            // 
            this.buttonLocal.Location = new System.Drawing.Point(87, 328);
            this.buttonLocal.Name = "buttonLocal";
            this.buttonLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonLocal.TabIndex = 12;
            this.buttonLocal.Text = "But Local";
            this.buttonLocal.UseVisualStyleBackColor = true;
            this.buttonLocal.Click += new System.EventHandler(this.buttonLocal_Click);
            // 
            // labelNom1
            // 
            this.labelNom1.AutoSize = true;
            this.labelNom1.Location = new System.Drawing.Point(84, 280);
            this.labelNom1.Name = "labelNom1";
            this.labelNom1.Size = new System.Drawing.Size(0, 13);
            this.labelNom1.TabIndex = 13;
            // 
            // labelPrenom1
            // 
            this.labelPrenom1.AutoSize = true;
            this.labelPrenom1.Location = new System.Drawing.Point(84, 248);
            this.labelPrenom1.Name = "labelPrenom1";
            this.labelPrenom1.Size = new System.Drawing.Size(0, 13);
            this.labelPrenom1.TabIndex = 14;
            // 
            // labelPrenom2
            // 
            this.labelPrenom2.AutoSize = true;
            this.labelPrenom2.Location = new System.Drawing.Point(561, 248);
            this.labelPrenom2.Name = "labelPrenom2";
            this.labelPrenom2.Size = new System.Drawing.Size(0, 13);
            this.labelPrenom2.TabIndex = 16;
            // 
            // labelNom2
            // 
            this.labelNom2.AutoSize = true;
            this.labelNom2.Location = new System.Drawing.Point(561, 280);
            this.labelNom2.Name = "labelNom2";
            this.labelNom2.Size = new System.Drawing.Size(0, 13);
            this.labelNom2.TabIndex = 15;
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(299, 360);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(149, 50);
            this.buttonFin.TabIndex = 17;
            this.buttonFin.Text = "Fin de match";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // FormScoreMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.labelPrenom2);
            this.Controls.Add(this.labelNom2);
            this.Controls.Add(this.labelPrenom1);
            this.Controls.Add(this.labelNom1);
            this.Controls.Add(this.buttonLocal);
            this.Controls.Add(this.buttonVisiteur);
            this.Controls.Add(this.labelVisiteur);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelVisiteur2);
            this.Controls.Add(this.labelLocal2);
            this.Controls.Add(this.comboBoxNum2);
            this.Controls.Add(this.comboBoxNum1);
            this.Controls.Add(this.labelVs);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.labelEquipe2);
            this.Controls.Add(this.labelEquipe1);
            this.Name = "FormScoreMatch";
            this.Text = "Match en cours";
            this.Load += new System.EventHandler(this.FormScoreMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipe1;
        private System.Windows.Forms.Label labelEquipe2;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.ComboBox comboBoxNum1;
        private System.Windows.Forms.ComboBox comboBoxNum2;
        private System.Windows.Forms.Label labelLocal2;
        private System.Windows.Forms.Label labelVisiteur2;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelVisiteur;
        private System.Windows.Forms.Button buttonVisiteur;
        private System.Windows.Forms.Button buttonLocal;
        private System.Windows.Forms.Label labelNom1;
        private System.Windows.Forms.Label labelPrenom1;
        private System.Windows.Forms.Label labelPrenom2;
        private System.Windows.Forms.Label labelNom2;
        private System.Windows.Forms.Button buttonFin;
    }
}