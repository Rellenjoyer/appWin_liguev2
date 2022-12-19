namespace appWin_liguev2
{
    partial class FormStatistiques
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltre = new System.Windows.Forms.ComboBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxFiltre
            // 
            this.comboBoxFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltre.FormattingEnabled = true;
            this.comboBoxFiltre.Items.AddRange(new object[] {
            "Équipes",
            "Attaquants",
            "Gardiens"});
            this.comboBoxFiltre.Location = new System.Drawing.Point(54, 69);
            this.comboBoxFiltre.Name = "comboBoxFiltre";
            this.comboBoxFiltre.Size = new System.Drawing.Size(111, 21);
            this.comboBoxFiltre.TabIndex = 1;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Location = new System.Drawing.Point(54, 112);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(148, 23);
            this.buttonRecherche.TabIndex = 2;
            this.buttonRecherche.Text = "Actualiser";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Location = new System.Drawing.Point(51, 38);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(60, 13);
            this.labelRecherche.TabIndex = 5;
            this.labelRecherche.Text = "Recherche";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(237, 69);
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMin.TabIndex = 7;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(237, 38);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(81, 13);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "Minimum de but";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(389, 38);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(84, 13);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Maximum de but";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(389, 69);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 9;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(618, 112);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(148, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Nouvelle saison";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.comboBoxFiltre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormStatistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.FormStatistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxFiltre;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Button buttonReset;
    }
}