using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MapEditor
{
    /// <summary>
    /// Logique d'interaction pour AddAccountWindow.xaml
    /// </summary>
    public partial class AddAccountWindow : Window
    {
        string _sMotDePasse1 = "";
        string _sMotDePasse2 = "";
        JeuEntities _context = JeuEntities.CreationContext();
        public AddAccountWindow()
        {
            InitializeComponent();
        }
        private void ValiderCréer()
        {
            if (_sMotDePasse1 == _sMotDePasse2 && txtPseudo.Text.Length > 0 && txtPrenom.Text.Length > 0 && txtNom.Text.Length > 0 && txtMotDePasse.Text.Length > 4 && txtMotDePasse_Copy.Text.Length > 4 && txtCourriel.Text.Length > 0)
            {
                btn_Ajouter.IsEnabled = true;
            }
            else
            {
                btn_Ajouter.IsEnabled = false;
            }

        }
        private void btn_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (_sMotDePasse1 == _sMotDePasse2 && (_context.CompteJoueurs.Where(c => c.NomJoueur == txtPseudo.Text).FirstOrDefault() == null))
            {

                string nomUltilisateur = txtPseudo.Text;
                string courriel = txtCourriel.Text;
                string prenom = txtPrenom.Text;
                string nom = txtNom.Text;
                string mdp = txtMotDePasse.Text;
                string sNom = "message";
                ObjectParameter message = new ObjectParameter(sNom, sNom.GetType());
                _context.CreerCompteJoueur(nomUltilisateur, courriel, prenom, nom, 1, mdp, message);
                _context.SaveChanges();
                txtMotDePasse.Clear();
                txtMotDePasse_Copy.Clear();
                txtPseudo.Clear();
                txtCourriel.Clear();
                txtPrenom.Clear();
                txtNom.Clear();
                MessageBox.Show("Succès! Utilisateur ajouté avec le rôle d'administrateur!");
                Close();
            }
            else if (_context.CompteJoueurs.Where(c => c.NomJoueur == txtPseudo.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Erreur! Le pseudo est déjà pris!");
                _sMotDePasse1 = "";
                _sMotDePasse2 = "";
                txtMotDePasse.Clear();
                txtMotDePasse_Copy.Clear();
                txtPseudo.Clear();
            }
            else
            {
                MessageBox.Show("Erreur! Le mot de passe et la confirmation de mot de passe ne correspondent pas!");
                _sMotDePasse1 = "";
                _sMotDePasse2 = "";
                txtMotDePasse.Clear();
                txtMotDePasse_Copy.Clear();
            }
        }

        private void btn_Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtPseudo_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValiderCréer();
        }

        private void txtMotDePasse_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            string sText = txtMotDePasse.Text;
            bool bÉtoileSeulement = true;
            for (int i = 0; i < sText.Length; i++)
            {
                if (bÉtoileSeulement && sText[i] != '*')
                {
                    bÉtoileSeulement = false;
                }
            }
            if (!bÉtoileSeulement)
            {

                string sPasswordTextBox = txtMotDePasse.Text;
                _sMotDePasse1 += sPasswordTextBox[sPasswordTextBox.Length - 1];
                int iLongueur = sPasswordTextBox.Length;
                //txt_Password.Clear();
                string sNewTxt = "";
                for (int i = 0; i < iLongueur; i++)
                {
                    sNewTxt += '*';
                }
                txtMotDePasse.Text = sNewTxt;
                txtMotDePasse.CaretIndex = txtMotDePasse.Text.Length;
            }
            else
            {
                if (_sMotDePasse1.Length > txtMotDePasse.Text.Length)
                {
                    string sNouveauMot = "";
                    for (int i = 0; i < _sMotDePasse1.Length - (_sMotDePasse1.Length - txtMotDePasse.Text.Length); i++)
                    {
                        sNouveauMot += _sMotDePasse1[i];
                    }
                    _sMotDePasse1 = sNouveauMot;
                }
            }
            ValiderCréer();
        }

        private void txtMotDePasse_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            string sText = txtMotDePasse_Copy.Text;
            bool bÉtoileSeulement = true;
            for (int i = 0; i < sText.Length; i++)
            {
                if (bÉtoileSeulement && sText[i] != '*')
                {
                    bÉtoileSeulement = false;
                }
            }
            if (!bÉtoileSeulement)
            {

                string sPasswordTextBox = txtMotDePasse_Copy.Text;
                _sMotDePasse2 += sPasswordTextBox[sPasswordTextBox.Length - 1];
                int iLongueur = sPasswordTextBox.Length;
                //txt_Password.Clear();
                string sNewTxt = "";
                for (int i = 0; i < iLongueur; i++)
                {
                    sNewTxt += '*';
                }
                txtMotDePasse_Copy.Text = sNewTxt;
                txtMotDePasse_Copy.CaretIndex = txtMotDePasse_Copy.Text.Length;
            }
            else
            {
                if (_sMotDePasse2.Length > txtMotDePasse_Copy.Text.Length)
                {
                    string sNouveauMot = "";
                    for (int i = 0; i < _sMotDePasse2.Length - (_sMotDePasse2.Length - txtMotDePasse_Copy.Text.Length); i++)
                    {
                        sNouveauMot += _sMotDePasse2[i];
                    }
                    _sMotDePasse2 = sNouveauMot;
                }
            }
            ValiderCréer();
        }

        private void txtCourriel_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValiderCréer();

        }

        private void txtPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValiderCréer();

        }

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValiderCréer();
            //MessageBox.Show("1: " + _sMotDePasse1);
        }
    }
}
