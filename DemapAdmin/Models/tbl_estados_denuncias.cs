//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemapAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_estados_denuncias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_estados_denuncias()
        {
            this.tbl_denuncias = new HashSet<tbl_denuncias>();
        }
    
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string CreadoPor { get; set; }
        public Nullable<byte> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_denuncias> tbl_denuncias { get; set; }
    }
}
