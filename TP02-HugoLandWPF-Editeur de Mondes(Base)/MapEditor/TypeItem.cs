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
    
    public partial class TypeItem
    {
        public TypeItem()
        {
            this.EffetItem = new HashSet<EffetItem>();
            this.InventaireItem = new HashSet<InventaireItem>();
            this.Item = new HashSet<Item>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Nullable<int> ImageId { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual ICollection<EffetItem> EffetItem { get; set; }
        public virtual ICollection<InventaireItem> InventaireItem { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
