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
    
    public partial class tbl_seguimiento_denuncias
    {
        public int Id { get; set; }
        public Nullable<int> DenunciaID { get; set; }
        public Nullable<int> ComentarioID { get; set; }
        public Nullable<int> AsignadaUsuarioID { get; set; }
        public Nullable<int> EstadoDenunciaID { get; set; }
        public Nullable<int> StatusDenunciaID { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string CreadoPor { get; set; }
        public Nullable<System.DateTime> UltModifFecha { get; set; }
        public string UltModifUsuario { get; set; }
        public Nullable<byte> Activo { get; set; }
    
        public virtual tbl_comentarios_denuncias tbl_comentarios_denuncias { get; set; }
        public virtual tbl_denuncias tbl_denuncias { get; set; }
        public virtual tbl_estados_denuncias tbl_estados_denuncias { get; set; }
        public virtual tbl_usuarios tbl_usuarios { get; set; }
        public virtual tbl_status_denuncias tbl_status_denuncias { get; set; }
    }
}