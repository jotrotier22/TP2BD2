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
    
    public partial class CompteJoueur
    {
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
    }
}