﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;

    public partial class JeuEntities : DbContext
    {
        private static JeuEntities _instance = null;
        protected JeuEntities() //AndTitties
            : base("name=JeuEntities")
        {
        }

        public static JeuEntities CreationContext()
        {
            if (_instance == null)
                _instance = new JeuEntities();
            return _instance;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<CompteJoueur> CompteJoueurs { get; set; }
        public DbSet<EffetItem> EffetItems { get; set; }
        public DbSet<Heros> Heros { get; set; }
        public DbSet<InventaireItem> InventaireItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Monde> Mondes { get; set; }
        public DbSet<Monstre> Monstres { get; set; }
        public DbSet<ObjetMonde> ObjetMondes { get; set; }
        public DbSet<TypeItem> TypeItems { get; set; }

        public virtual int Connexion(string pNomJoueur, string pMotDePasse, ObjectParameter message)
        {
            var pNomJoueurParameter = pNomJoueur != null ?
                new ObjectParameter("pNomJoueur", pNomJoueur) :
                new ObjectParameter("pNomJoueur", typeof(string));

            var pMotDePasseParameter = pMotDePasse != null ?
                new ObjectParameter("pMotDePasse", pMotDePasse) :
                new ObjectParameter("pMotDePasse", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Connexion", pNomJoueurParameter, pMotDePasseParameter, message);
        }

        public virtual int CreerCompteJoueur(string pNomUtilisateur, string pCourriel, string pPrenom, string pNom, Nullable<int> pTypeUtilisateur, string pMotDePasse, ObjectParameter message)
        {
            var pNomUtilisateurParameter = pNomUtilisateur != null ?
                new ObjectParameter("pNomUtilisateur", pNomUtilisateur) :
                new ObjectParameter("pNomUtilisateur", typeof(string));

            var pCourrielParameter = pCourriel != null ?
                new ObjectParameter("pCourriel", pCourriel) :
                new ObjectParameter("pCourriel", typeof(string));

            var pPrenomParameter = pPrenom != null ?
                new ObjectParameter("pPrenom", pPrenom) :
                new ObjectParameter("pPrenom", typeof(string));

            var pNomParameter = pNom != null ?
                new ObjectParameter("pNom", pNom) :
                new ObjectParameter("pNom", typeof(string));

            var pTypeUtilisateurParameter = pTypeUtilisateur.HasValue ?
                new ObjectParameter("pTypeUtilisateur", pTypeUtilisateur) :
                new ObjectParameter("pTypeUtilisateur", typeof(int));

            var pMotDePasseParameter = pMotDePasse != null ?
                new ObjectParameter("pMotDePasse", pMotDePasse) :
                new ObjectParameter("pMotDePasse", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreerCompteJoueur", pNomUtilisateurParameter, pCourrielParameter, pPrenomParameter, pNomParameter, pTypeUtilisateurParameter, pMotDePasseParameter, message);
        }
    }
}
//{
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Infrastructure;
//    using System.Data.Objects;
//    using System.Data.Objects.DataClasses;
//    using System.Linq;

//    public partial class JeuEntities : DbContext
//    {
//        public JeuEntities()
//            : base("name=JeuEntities")
//        {
//        }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            throw new UnintentionalCodeFirstException();
//        }

//        public DbSet<Classe> Classe { get; set; }
//        public DbSet<CompteJoueur> CompteJoueur { get; set; }
//        public DbSet<EffetItem> EffetItem { get; set; }
//        public DbSet<Heros> Heros { get; set; }
//        public DbSet<InventaireItem> InventaireItem { get; set; }
//        public DbSet<Item> Item { get; set; }
//        public DbSet<Monde> Monde { get; set; }
//        public DbSet<Monstre> Monstre { get; set; }
//        public DbSet<ObjetMonde> ObjetMonde { get; set; }
//        public DbSet<TypeItem> TypeItem { get; set; }

//        public virtual int Connexion(string pNomJoueur, string pMotDePasse, ObjectParameter message)
//        {
//            var pNomJoueurParameter = pNomJoueur != null ?
//                new ObjectParameter("pNomJoueur", pNomJoueur) :
//                new ObjectParameter("pNomJoueur", typeof(string));

//            var pMotDePasseParameter = pMotDePasse != null ?
//                new ObjectParameter("pMotDePasse", pMotDePasse) :
//                new ObjectParameter("pMotDePasse", typeof(string));

//            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Connexion", pNomJoueurParameter, pMotDePasseParameter, message);
//        }

//        public virtual int CreerCompteJoueur(string pNomUtilisateur, string pCourriel, string pPrenom, string pNom, Nullable<int> pTypeUtilisateur, string pMotDePasse, ObjectParameter message)
//        {
//            var pNomUtilisateurParameter = pNomUtilisateur != null ?
//                new ObjectParameter("pNomUtilisateur", pNomUtilisateur) :
//                new ObjectParameter("pNomUtilisateur", typeof(string));

//            var pCourrielParameter = pCourriel != null ?
//                new ObjectParameter("pCourriel", pCourriel) :
//                new ObjectParameter("pCourriel", typeof(string));

//            var pPrenomParameter = pPrenom != null ?
//                new ObjectParameter("pPrenom", pPrenom) :
//                new ObjectParameter("pPrenom", typeof(string));

//            var pNomParameter = pNom != null ?
//                new ObjectParameter("pNom", pNom) :
//                new ObjectParameter("pNom", typeof(string));

//            var pTypeUtilisateurParameter = pTypeUtilisateur.HasValue ?
//                new ObjectParameter("pTypeUtilisateur", pTypeUtilisateur) :
//                new ObjectParameter("pTypeUtilisateur", typeof(int));

//            var pMotDePasseParameter = pMotDePasse != null ?
//                new ObjectParameter("pMotDePasse", pMotDePasse) :
//                new ObjectParameter("pMotDePasse", typeof(string));

//            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreerCompteJoueur", pNomUtilisateurParameter, pCourrielParameter, pPrenomParameter, pNomParameter, pTypeUtilisateurParameter, pMotDePasseParameter, message);
//        }
//    }
//}