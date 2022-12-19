namespace appWin_liguev2
{
    partial class FormAjouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouter));
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.listViewJoueur = new System.Windows.Forms.ListView();
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonAjouterJoueur = new System.Windows.Forms.Button();
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.textBoxNomEquipe = new System.Windows.Forms.TextBox();
            this.buttonComplet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(721, 232);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(124, 23);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Supprimer un joueur";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Attaquant",
            "Gardien"});
            this.comboBoxPosition.Location = new System.Drawing.Point(404, 74);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPosition.TabIndex = 25;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(401, 47);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(91, 13);
            this.labelPosition.TabIndex = 24;
            this.labelPosition.Text = "Position du joueur";
            // 
            // listViewJoueur
            // 
            this.listViewJoueur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numero,
            this.position,
            this.prenom,
            this.nom});
            this.listViewJoueur.HideSelection = false;
            this.listViewJoueur.Location = new System.Drawing.Point(277, 130);
            this.listViewJoueur.Name = "listViewJoueur";
            this.listViewJoueur.Size = new System.Drawing.Size(407, 168);
            this.listViewJoueur.TabIndex = 23;
            this.listViewJoueur.UseCompatibleStateImageBehavior = false;
            this.listViewJoueur.View = System.Windows.Forms.View.Details;
            this.listViewJoueur.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // numero
            // 
            this.numero.Text = "Numéro";
            this.numero.Width = 51;
            // 
            // position
            // 
            this.position.Text = "Position";
            this.position.Width = 59;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.Width = 139;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 150;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(274, 47);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(91, 13);
            this.labelNum.TabIndex = 22;
            this.labelNum.Text = "Numéro du joueur";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(277, 74);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 21;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(665, 47);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(90, 13);
            this.labelPrenom.TabIndex = 20;
            this.labelPrenom.Text = "Prénom du joueur";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(668, 74);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 19;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(530, 47);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 13);
            this.labelNom.TabIndex = 18;
            this.labelNom.Text = "Nom du joueur";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(533, 74);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 17;
            // 
            // buttonAjouterJoueur
            // 
            this.buttonAjouterJoueur.Location = new System.Drawing.Point(721, 160);
            this.buttonAjouterJoueur.Name = "buttonAjouterJoueur";
            this.buttonAjouterJoueur.Size = new System.Drawing.Size(124, 23);
            this.buttonAjouterJoueur.TabIndex = 16;
            this.buttonAjouterJoueur.Text = "Ajouter un joueur";
            this.buttonAjouterJoueur.UseVisualStyleBackColor = true;
            this.buttonAjouterJoueur.Click += new System.EventHandler(this.buttonAjouterJoueur_Click);
            // 
            // labelNomEquipe
            // 
            this.labelNomEquipe.AutoSize = true;
            this.labelNomEquipe.Location = new System.Drawing.Point(49, 47);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(83, 13);
            this.labelNomEquipe.TabIndex = 15;
            this.labelNomEquipe.Text = "Nom de l\'équipe";
            // 
            // textBoxNomEquipe
            // 
            this.textBoxNomEquipe.Location = new System.Drawing.Point(52, 75);
            this.textBoxNomEquipe.Name = "textBoxNomEquipe";
            this.textBoxNomEquipe.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomEquipe.TabIndex = 14;
            // 
            // buttonComplet
            // 
            this.buttonComplet.Location = new System.Drawing.Point(52, 232);
            this.buttonComplet.Name = "buttonComplet";
            this.buttonComplet.Size = new System.Drawing.Size(124, 23);
            this.buttonComplet.TabIndex = 27;
            this.buttonComplet.Text = "Compléter la création";
            this.buttonComplet.UseVisualStyleBackColor = true;
            this.buttonComplet.Click += new System.EventHandler(this.buttonComplet_Click);
            // 
            // FormAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 402);
            this.Controls.Add(this.buttonComplet);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.listViewJoueur);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonAjouterJoueur);
            this.Controls.Add(this.labelNomEquipe);
            this.Controls.Add(this.textBoxNomEquipe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjouter";
            this.Text = "Ajouter une équipe";
            this.Load += new System.EventHandler(this.FormAjouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ListView listViewJoueur;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonAjouterJoueur;
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.TextBox textBoxNomEquipe;
        private System.Windows.Forms.Button buttonComplet;
        private System.Windows.Forms.ColumnHeader nom;
    }
}