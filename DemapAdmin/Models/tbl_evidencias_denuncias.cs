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
    
    public partial class tbl_evidencias_denuncias
    {
        public int Id { get; set; }
        public Nullable<int> DenunciaID { get; set; }
        public string ImagenDenuncia { get; set; }
        public string VideoDenuncia { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<byte> Activo { get; set; }
    
        public virtual tbl_denuncias tbl_denuncias { get; set; }
    }
}
