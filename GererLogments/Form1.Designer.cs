namespace GererLogments
{
    partial class Form1
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
            this.BNouveau = new System.Windows.Forms.Button();
            this.BAjouter = new System.Windows.Forms.Button();
            this.BSauvegarder = new System.Windows.Forms.Button();
            this.BSupprimer = new System.Windows.Forms.Button();
            this.LB_IdBatiment = new System.Windows.Forms.Label();
            this.LB_Adresse = new System.Windows.Forms.Label();
            this.LB_Superficie = new System.Windows.Forms.Label();
            this.LB_Prix = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TB_Superficie = new System.Windows.Forms.TextBox();
            this.TB_Prix = new System.Windows.Forms.TextBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.LB_Type = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BDebut = new System.Windows.Forms.Button();
            this.Bdernier = new System.Windows.Forms.Button();
            this.BSuivant = new System.Windows.Forms.Button();
            this.BFin = new System.Windows.Forms.Button();
            this.BSupprimerLigne = new System.Windows.Forms.Button();
            this.BDeserialiser = new System.Windows.Forms.Button();
            this.BQuitter = new System.Windows.Forms.Button();
            this.BModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BNouveau
            // 
            this.BNouveau.Location = new System.Drawing.Point(396, 40);
            this.BNouveau.Name = "BNouveau";
            this.BNouveau.Size = new System.Drawing.Size(75, 23);
            this.BNouveau.TabIndex = 9;
            this.BNouveau.Text = "Nouveau";
            this.BNouveau.UseVisualStyleBackColor = true;
            this.BNouveau.Click += new System.EventHandler(this.BNouveau_Click);
            // 
            // BAjouter
            // 
            this.BAjouter.Location = new System.Drawing.Point(496, 40);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(75, 23);
            this.BAjouter.TabIndex = 11;
            this.BAjouter.Text = "Ajouter";
            this.BAjouter.UseVisualStyleBackColor = true;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BSauvegarder
            // 
            this.BSauvegarder.Location = new System.Drawing.Point(396, 124);
            this.BSauvegarder.Name = "BSauvegarder";
            this.BSauvegarder.Size = new System.Drawing.Size(175, 23);
            this.BSauvegarder.TabIndex = 13;
            this.BSauvegarder.Text = "Sauvegarder(sérialiser)";
            this.BSauvegarder.UseVisualStyleBackColor = true;
            this.BSauvegarder.Click += new System.EventHandler(this.BSauvegarder_Click);
            // 
            // BSupprimer
            // 
            this.BSupprimer.Location = new System.Drawing.Point(496, 85);
            this.BSupprimer.Name = "BSupprimer";
            this.BSupprimer.Size = new System.Drawing.Size(75, 25);
            this.BSupprimer.TabIndex = 12;
            this.BSupprimer.Text = "Supprimer";
            this.BSupprimer.UseVisualStyleBackColor = true;
            this.BSupprimer.Click += new System.EventHandler(this.BSupprimer_Click);
            // 
            // LB_IdBatiment
            // 
            this.LB_IdBatiment.AutoSize = true;
            this.LB_IdBatiment.Location = new System.Drawing.Point(65, 45);
            this.LB_IdBatiment.Name = "LB_IdBatiment";
            this.LB_IdBatiment.Size = new System.Drawing.Size(62, 13);
            this.LB_IdBatiment.TabIndex = 17;
            this.LB_IdBatiment.Text = "ID Batiment";
            // 
            // LB_Adresse
            // 
            this.LB_Adresse.AutoSize = true;
            this.LB_Adresse.Location = new System.Drawing.Point(65, 85);
            this.LB_Adresse.Name = "LB_Adresse";
            this.LB_Adresse.Size = new System.Drawing.Size(45, 13);
            this.LB_Adresse.TabIndex = 18;
            this.LB_Adresse.Text = "Adresse";
            // 
            // LB_Superficie
            // 
            this.LB_Superficie.AutoSize = true;
            this.LB_Superficie.Location = new System.Drawing.Point(65, 129);
            this.LB_Superficie.Name = "LB_Superficie";
            this.LB_Superficie.Size = new System.Drawing.Size(54, 13);
            this.LB_Superficie.TabIndex = 19;
            this.LB_Superficie.Text = "Superficie";
            // 
            // LB_Prix
            // 
            this.LB_Prix.AutoSize = true;
            this.LB_Prix.Location = new System.Drawing.Point(65, 204);
            this.LB_Prix.Name = "LB_Prix";
            this.LB_Prix.Size = new System.Drawing.Size(24, 13);
            this.LB_Prix.TabIndex = 21;
            this.LB_Prix.Text = "Prix";
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(144, 37);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(121, 20);
            this.TB_ID.TabIndex = 0;
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(144, 78);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(121, 20);
            this.TB_Adresse.TabIndex = 1;
            // 
            // TB_Superficie
            // 
            this.TB_Superficie.Location = new System.Drawing.Point(144, 122);
            this.TB_Superficie.Name = "TB_Superficie";
            this.TB_Superficie.Size = new System.Drawing.Size(121, 20);
            this.TB_Superficie.TabIndex = 2;
            // 
            // TB_Prix
            // 
            this.TB_Prix.Location = new System.Drawing.Point(144, 204);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(121, 20);
            this.TB_Prix.TabIndex = 4;
            // 
            // CB_Type
            // 
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Location = new System.Drawing.Point(144, 166);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(121, 21);
            this.CB_Type.TabIndex = 3;
            // 
            // LB_Type
            // 
            this.LB_Type.AutoSize = true;
            this.LB_Type.Location = new System.Drawing.Point(68, 173);
            this.LB_Type.Name = "LB_Type";
            this.LB_Type.Size = new System.Drawing.Size(31, 13);
            this.LB_Type.TabIndex = 20;
            this.LB_Type.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 152);
            this.dataGridView1.TabIndex = 1;
            // 
            // BDebut
            // 
            this.BDebut.Location = new System.Drawing.Point(87, 245);
            this.BDebut.Name = "BDebut";
            this.BDebut.Size = new System.Drawing.Size(40, 21);
            this.BDebut.TabIndex = 5;
            this.BDebut.Text = "<<";
            this.BDebut.UseVisualStyleBackColor = true;
            this.BDebut.Click += new System.EventHandler(this.BDebut_Click);
            // 
            // Bdernier
            // 
            this.Bdernier.Location = new System.Drawing.Point(204, 245);
            this.Bdernier.Name = "Bdernier";
            this.Bdernier.Size = new System.Drawing.Size(21, 21);
            this.Bdernier.TabIndex = 7;
            this.Bdernier.Text = ">";
            this.Bdernier.UseVisualStyleBackColor = true;
            this.Bdernier.Click += new System.EventHandler(this.Bdernier_Click);
            // 
            // BSuivant
            // 
            this.BSuivant.Location = new System.Drawing.Point(154, 245);
            this.BSuivant.Name = "BSuivant";
            this.BSuivant.Size = new System.Drawing.Size(18, 21);
            this.BSuivant.TabIndex = 6;
            this.BSuivant.Text = "<";
            this.BSuivant.UseVisualStyleBackColor = true;
            this.BSuivant.Click += new System.EventHandler(this.BSuivant_Click);
            // 
            // BFin
            // 
            this.BFin.Location = new System.Drawing.Point(267, 244);
            this.BFin.Name = "BFin";
            this.BFin.Size = new System.Drawing.Size(42, 22);
            this.BFin.TabIndex = 8;
            this.BFin.Text = ">>";
            this.BFin.UseVisualStyleBackColor = true;
            this.BFin.Click += new System.EventHandler(this.BFin_Click);
            // 
            // BSupprimerLigne
            // 
            this.BSupprimerLigne.Location = new System.Drawing.Point(396, 216);
            this.BSupprimerLigne.Name = "BSupprimerLigne";
            this.BSupprimerLigne.Size = new System.Drawing.Size(175, 23);
            this.BSupprimerLigne.TabIndex = 15;
            this.BSupprimerLigne.Text = "Supprimer Ligne DataGrid";
            this.BSupprimerLigne.UseVisualStyleBackColor = true;
            this.BSupprimerLigne.Click += new System.EventHandler(this.BSupprimerLigne_Click);
            // 
            // BDeserialiser
            // 
            this.BDeserialiser.Location = new System.Drawing.Point(396, 173);
            this.BDeserialiser.Name = "BDeserialiser";
            this.BDeserialiser.Size = new System.Drawing.Size(175, 23);
            this.BDeserialiser.TabIndex = 14;
            this.BDeserialiser.Text = "Deserialiser";
            this.BDeserialiser.UseVisualStyleBackColor = true;
            this.BDeserialiser.Click += new System.EventHandler(this.BDeserialiser_Click);
            // 
            // BQuitter
            // 
            this.BQuitter.Location = new System.Drawing.Point(444, 256);
            this.BQuitter.Name = "BQuitter";
            this.BQuitter.Size = new System.Drawing.Size(75, 23);
            this.BQuitter.TabIndex = 10;
            this.BQuitter.Text = "Quitter";
            this.BQuitter.UseVisualStyleBackColor = true;
            this.BQuitter.Click += new System.EventHandler(this.BQuitter_Click);
            // 
            // BModifier
            // 
            this.BModifier.Location = new System.Drawing.Point(396, 85);
            this.BModifier.Name = "BModifier";
            this.BModifier.Size = new System.Drawing.Size(75, 23);
            this.BModifier.TabIndex = 22;
            this.BModifier.Text = "Modifier";
            this.BModifier.UseVisualStyleBackColor = true;
            this.BModifier.Click += new System.EventHandler(this.BModifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(631, 479);
            this.Controls.Add(this.BModifier);
            this.Controls.Add(this.BQuitter);
            this.Controls.Add(this.BDeserialiser);
            this.Controls.Add(this.BSupprimerLigne);
            this.Controls.Add(this.BFin);
            this.Controls.Add(this.BSuivant);
            this.Controls.Add(this.Bdernier);
            this.Controls.Add(this.BDebut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LB_Type);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.TB_Prix);
            this.Controls.Add(this.TB_Superficie);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.LB_Prix);
            this.Controls.Add(this.LB_Superficie);
            this.Controls.Add(this.LB_Adresse);
            this.Controls.Add(this.LB_IdBatiment);
            this.Controls.Add(this.BSupprimer);
            this.Controls.Add(this.BSauvegarder);
            this.Controls.Add(this.BAjouter);
            this.Controls.Add(this.BNouveau);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNouveau;
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.Button BSauvegarder;
        private System.Windows.Forms.Button BSupprimer;
        private System.Windows.Forms.Label LB_IdBatiment;
        private System.Windows.Forms.Label LB_Adresse;
        private System.Windows.Forms.Label LB_Superficie;
        private System.Windows.Forms.Label LB_Prix;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.TextBox TB_Superficie;
        private System.Windows.Forms.TextBox TB_Prix;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.Label LB_Type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BDebut;
        private System.Windows.Forms.Button Bdernier;
        private System.Windows.Forms.Button BSuivant;
        private System.Windows.Forms.Button BFin;
        private System.Windows.Forms.Button BSupprimerLigne;
        private System.Windows.Forms.Button BDeserialiser;
        private System.Windows.Forms.Button BQuitter;
        private System.Windows.Forms.Button BModifier;
    }
}

