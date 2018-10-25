using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo1
{
    ///<summary>
    /// ce programme recopie à la demande le texte du champ txtOriginal
    /// vers le label lblResultat
    /// Ecrit le 23/10/2018, par Vladimir LECSEI
    ///</summary>
    public partial class FRM_Exo1 : Form
    {
        // variable de niveau classe utilisée par différentes procédures
        private String LeTexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FRM_Exo1()
        {
            InitializeComponent();
            // crée un Handler d'événement pour la prise de focus sur la textbox
            this.Txt_Texte_Initial.GotFocus += new EventHandler(Txt_Texte_Initial_GotFocus);
            // initialisation de la textbox.text
            this.LeTexte = "Entrer le texte initial";
            this.Txt_Texte_Initial.Text = LeTexte;
        }
        /// <summary>
        /// Remet à blanc le texte initial dès la prise de focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_Texte_Initial_GotFocus(object sender, EventArgs e)
        {
            /* Procédure événementielle entièrement écrite*/
            this.Txt_Texte_Initial.Text = "";
        }
        /// <summary>
        /// Recopie le contenu de la textbox dans le label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Recopier_Click(object sender, EventArgs e)
        {
            this.Lbl_Resultat.Text = this.Txt_Texte_Initial.Text;
        }
        /// <summary>
        /// Efface la textbox et le label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Effacer_Click(object sender, EventArgs e)
        {
            this.Txt_Texte_Initial.Text = LeTexte;
            this.Lbl_Resultat.ResetText();
        }
        /// <summary>
        /// Quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Méthode évenementielle appelée pendant la fermeture du form
        /// aussi bien par Application.Exit() que Alt+F4 ou case de fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_Exo1_Form_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;
            /*Cette variable contiendra la réponse de l'opérateur;
             *son type correspond au type de données fourni par un objet de classe MessageBox
             *l'affichage d'un message s'obtient par la méthode Show de la classe MessageBox
             * ses paramètres permettent de personnaliser la boite de dialogue standard :
             * ici, bouton Oui et Non et icone "?" 
             */
            rep = MessageBox.Show("Voulez-vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            /* après choix du bouton par l’opérateur,  
             * la classe MessageBox retourne des valeurs particulières 
             * qui sont nommées (ce qu’on appelle des constantes) 
             */
             if (rep == DialogResult.No)    // si l'arrêt est annulé par l'opérateur
            {
                e.Cancel = true;            //annuler l'événement en cours
            }
        }
    }
}
