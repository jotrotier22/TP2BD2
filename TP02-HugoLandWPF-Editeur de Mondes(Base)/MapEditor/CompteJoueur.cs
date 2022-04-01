//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapEditor
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects;
    using System.Linq;

    public partial class CompteJoueur
    {
        JeuEntities jeuContext = JeuEntities.CreationContext();
        public CompteJoueur()
        {
            this.Heros = new HashSet<Heros>();
        }
    
        public int Id { get; set; }
        public string NomJoueur { get; set; }
        public string Courriel { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int TypeUtilisateur { get; set; }
        public byte[] MotDePasseHash { get; set; }
        public System.Guid Salt { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual ICollection<Heros> Heros { get; set; }


        public string CreerCompteJoueur(string nomUltilisateur, string courriel, string prenom, string nom, int? typeUltilisateur, string mdp)
        {
            string sNom = "message";
            ObjectParameter message = new ObjectParameter(sNom, sNom.GetType());
            jeuContext.CreerCompteJoueur(nomUltilisateur, courriel, prenom, nom, typeUltilisateur, mdp, message);

            return message.Value.ToString();
        }
        public void SupprimerCompteJoueur(int IdCompte/*,string mdp pas utilisé à cause des permissions admin*/)
        {
            CompteJoueur compteJoueur = jeuContext.CompteJoueurs.Where(cj => cj.Id == IdCompte).FirstOrDefault();
            List<Heros> lstHero = jeuContext.Heros.Where(h => h.CompteJoueurId == IdCompte).ToList();

            foreach (Heros hero in lstHero)
            {
                List<InventaireItem> lstIi = hero.InventaireItem.ToList();
                foreach (InventaireItem item in lstIi)
                {
                    jeuContext.InventaireItems.Remove(item);
                }
                hero.SupprimerHero(hero.Id, hero.MondeId);
            }
            jeuContext.CompteJoueurs.Remove(compteJoueur);
            jeuContext.SaveChanges();
        }
        public void ModifierParamCompteJoueur(int idCompte, string nomUltilisateur, string courriel, string prenom, string nom)
        {
            CompteJoueur compteJoueur = jeuContext.CompteJoueurs.Where(cj => cj.Id == idCompte).FirstOrDefault();
            compteJoueur.NomJoueur = nomUltilisateur;
            compteJoueur.Nom = nom;
            compteJoueur.Prenom = prenom;
            compteJoueur.Courriel = courriel;
            jeuContext.SaveChanges();
        }
        public string ValideConnexionCompteJoueur(string nomUltilisateur, string mdp)
        {
            string sNom = "message";
            ObjectParameter message = new ObjectParameter(sNom, sNom.GetType());
            jeuContext.Connexion(nomUltilisateur, mdp, message);

            return message.Value.ToString();
        }
    }
}
