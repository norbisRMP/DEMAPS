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
    
    public partial class tbl_denuncias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_denuncias()
        {
            this.tbl_evidencias_denuncias = new HashSet<tbl_evidencias_denuncias>();
            this.tbl_seguimiento_denuncias = new HashSet<tbl_seguimiento_denuncias>();
        }
    
        public int Id { get; set; }
        public int TipoProductoID { get; set; }
        public Nullable<int> EstadoDenunciaID { get; set; }
        public string CedulaDenunciante { get; set; }
        public string Producto { get; set; }
        public string Establecimiento { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<byte> Activo { get; set; }
    
        public virtual tbl_estados_denuncias tbl_estados_denuncias { get; set; }
        public virtual tbl_tipos_productos tbl_tipos_productos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_evidencias_denuncias> tbl_evidencias_denuncias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_seguimiento_denuncias> tbl_seguimiento_denuncias { get; set; }
    }
}
