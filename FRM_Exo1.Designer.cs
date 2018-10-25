namespace Exo1
{
    partial class FRM_Exo1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Original = new System.Windows.Forms.Label();
            this.Lbl_Copie = new System.Windows.Forms.Label();
            this.Txt_Texte_Initial = new System.Windows.Forms.TextBox();
            this.Btn_Recopier = new System.Windows.Forms.Button();
            this.Btn_Effacer = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Lbl_Resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Original
            // 
            this.Lbl_Original.AutoSize = true;
            this.Lbl_Original.Location = new System.Drawing.Point(12, 14);
            this.Lbl_Original.Name = "Lbl_Original";
            this.Lbl_Original.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Original.TabIndex = 0;
            this.Lbl_Original.Text = "Original :";
            // 
            // Lbl_Copie
            // 
            this.Lbl_Copie.AutoSize = true;
            this.Lbl_Copie.Location = new System.Drawing.Point(12, 57);
            this.Lbl_Copie.Name = "Lbl_Copie";
            this.Lbl_Copie.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Copie.TabIndex = 1;
            this.Lbl_Copie.Text = "Copie :";
            // 
            // Txt_Texte_Initial
            // 
            this.Txt_Texte_Initial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Texte_Initial.Location = new System.Drawing.Point(111, 11);
            this.Txt_Texte_Initial.Name = "Txt_Texte_Initial";
            this.Txt_Texte_Initial.Size = new System.Drawing.Size(238, 20);
            this.Txt_Texte_Initial.TabIndex = 2;
            // 
            // Btn_Recopier
            // 
            this.Btn_Recopier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Recopier.Location = new System.Drawing.Point(383, 9);
            this.Btn_Recopier.Name = "Btn_Recopier";
            this.Btn_Recopier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Recopier.TabIndex = 3;
            this.Btn_Recopier.Text = "Recopier";
            this.Btn_Recopier.UseVisualStyleBackColor = true;
            this.Btn_Recopier.Click += new System.EventHandler(this.Btn_Recopier_Click);
            // 
            // Btn_Effacer
            // 
            this.Btn_Effacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Effacer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Effacer.Location = new System.Drawing.Point(383, 47);
            this.Btn_Effacer.Name = "Btn_Effacer";
            this.Btn_Effacer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Effacer.TabIndex = 4;
            this.Btn_Effacer.Text = "Effacer";
            this.Btn_Effacer.UseVisualStyleBackColor = true;
            this.Btn_Effacer.Click += new System.EventHandler(this.Btn_Effacer_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Quitter.Location = new System.Drawing.Point(383, 86);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(75, 24);
            this.Btn_Quitter.TabIndex = 5;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Lbl_Resultat
            // 
            this.Lbl_Resultat.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Resultat.Location = new System.Drawing.Point(108, 50);
            this.Lbl_Resultat.Name = "Lbl_Resultat";
            this.Lbl_Resultat.Size = new System.Drawing.Size(238, 20);
            this.Lbl_Resultat.TabIndex = 6;
            // 
            // FRM_Exo1
            // 
            this.AcceptButton = this.Btn_Recopier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Effacer;
            this.ClientSize = new System.Drawing.Size(487, 125);
            this.Controls.Add(this.Lbl_Resultat);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_Effacer);
            this.Controls.Add(this.Btn_Recopier);
            this.Controls.Add(this.Txt_Texte_Initial);
            this.Controls.Add(this.Lbl_Copie);
            this.Controls.Add(this.Lbl_Original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_Exo1";
            this.Text = "Recopier un champ dans un autre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Exo1_Form_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Original;
        private System.Windows.Forms.Label Lbl_Copie;
        private System.Windows.Forms.TextBox Txt_Texte_Initial;
        private System.Windows.Forms.Button Btn_Recopier;
        private System.Windows.Forms.Button Btn_Effacer;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.Label Lbl_Resultat;
    }
}

