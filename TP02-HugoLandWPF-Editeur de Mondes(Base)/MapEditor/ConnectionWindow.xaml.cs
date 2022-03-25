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
    /// Logique d'interaction pour ConnectionWindow.xaml
    /// </summary>
    public partial class ConnectionWindow : Window
    {
        private bool _bValide = false;
        string _sPassword = "";
        private JeuEntities _context = JeuEntities.CreationContext();
        public ConnectionWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void LogInWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // si variable à false fermer tout
            if (!_bValide)
            {
                Application.Current.Shutdown();
            }
            // sinon ne rien faire de différent
        }

        private void btn_Connexion_Click(object sender, RoutedEventArgs e)
        {
            // 1. faire la connexion
            string sMessage = "message";
            ObjectParameter message = new ObjectParameter(sMessage, sMessage.GetType());
            string sPseudo = txt_Username.Text;
            // 2. vérifier la connexion et mettre vrai si réussi et faux si non réussi
            // 3. si non réussi, réouvrir la page de connexion
            // 4. si réussi, ouvrir mainwindow
            int? iTypeCompte = _context.CompteJoueurs.Where(c => c.NomJoueur == sPseudo).Select(s => s.TypeUtilisateur).FirstOrDefault();
            _context.Connexion(sPseudo, _sPassword, message).ToString();
            //MessageBox.Show(message.Value.ToString());
            if (message.Value.ToString() == "SUCCESS" && iTypeCompte == 1)
            {
                _bValide = true;
                Close();
            }
            else
            {
                if (message.Value.ToString() != "SUCCESS")
                {
                    MessageBox.Show("Mauvais Log In ou mot de passe");
                }
                else if (iTypeCompte == null || iTypeCompte != 1)
                {
                    MessageBox.Show("Compte non administrateur!");

                }
                txt_Password.Clear();
                txt_Username.Clear();
                _sPassword = "";
            }
            
        }

        private void txt_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            string sText = txt_Password.Text;
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

                string sPasswordTextBox = txt_Password.Text;
                _sPassword += sPasswordTextBox[sPasswordTextBox.Length - 1];
                int iLongueur = sPasswordTextBox.Length;
                //txt_Password.Clear();
                string sNewTxt = "";
                for (int i = 0; i < iLongueur; i++)
                {
                    sNewTxt += '*';
                }
                txt_Password.Text = sNewTxt;
                txt_Password.CaretIndex = txt_Password.Text.Length;
            }
            else
            {
                if (_sPassword.Length > txt_Password.Text.Length)
                {
                    string sNouveauMot = "";
                    for (int i = 0; i < _sPassword.Length - (_sPassword.Length - txt_Password.Text.Length); i++)
                    {
                        sNouveauMot += _sPassword[i];
                    }
                    _sPassword = sNouveauMot;
                }
            }
        }
    }
}
