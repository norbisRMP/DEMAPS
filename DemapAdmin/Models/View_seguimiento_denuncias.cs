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
    
    public partial class View_seguimiento_denuncias
    {
        public int Id { get; set; }
        public string CedulaDenunciante { get; set; }
        public string Establecimiento { get; set; }
        public string Producto { get; set; }
        public string Estado { get; set; }
        public string Status { get; set; }
        public string Usuario { get; set; }
        public string Perfil { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<byte> Activo { get; set; }
        public Nullable<System.DateTime> UltModifFecha { get; set; }
        public Nullable<int> UltModifUsuarioID { get; set; }
        public string RegistroSanitario { get; set; }
        public string Tipo { get; set; }
    }
}
