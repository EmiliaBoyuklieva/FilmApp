//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace film
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.LotaryRoles = new HashSet<LotaryRole>();
        }
    
        public int Id { get; set; }
        public string FilmName { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public decimal Size { get; set; }
        public int GenreId { get; set; }
        public int Rating { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<System.DateTime> DateWatch { get; set; }
        public int UserId { get; set; }
        public byte[] Image { get; set; }
        public string IMDB { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotaryRole> LotaryRoles { get; set; }
    }
}
