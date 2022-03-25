using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour AddAdminWindow.xaml
    /// </summary>
    public partial class AddAdminWindow : Window
    {
        JeuEntities _context = JeuEntities.CreationContext();
        public AddAdminWindow()
        {
            InitializeComponent();
        }

        private void btn_RechercherParID_Click(object sender, RoutedEventArgs e)
        {
            int ID = 0;
            if (int.TryParse(txt_RechercherParID.Text, out ID))
            {
                if (_context.CompteJoueurs.Where(c => c.Id == ID).FirstOrDefault() != null)
                {
                    CompteJoueur c1 = _context.CompteJoueurs.Where(c => c.Id == ID).FirstOrDefault();
                    //txt_PseudoCompteRecherché.Text = c1.NomJoueur;
                    c1.TypeUtilisateur = 1;
                    _context.SaveChanges();
                    MessageBox.Show("Succès! Joueur trouvé! Le rôle d'administrateur à été alloué à ce compte!");
                }
                else
                {
                    MessageBox.Show("Compte inexistant!");
                }
            }
            else
            {
                MessageBox.Show("Erreur! L'entrée n'est pas un chiffre entier!");
            }
        }

        private void btn_RechercherParPseudo_Click(object sender, RoutedEventArgs e)
        {
            if (_context.CompteJoueurs.Where(c => c.NomJoueur == txt_RechercherParPseudo.Text).FirstOrDefault() != null)
            {
                CompteJoueur c1 = _context.CompteJoueurs.Where(c => c.NomJoueur == txt_RechercherParPseudo.Text).FirstOrDefault();
                //txt_PseudoCompteRecherché.Text = c1.NomJoueur;
                c1.TypeUtilisateur = 1;
                _context.SaveChanges();
                MessageBox.Show("Succès! Joueur trouvé! Le rôle d'administrateur à été alloué à ce compte!");
            }
            else
            {
                MessageBox.Show("Compte inexistant!");
            }
        }

        private void txt_RechercherParID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_RechercherParPseudo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
