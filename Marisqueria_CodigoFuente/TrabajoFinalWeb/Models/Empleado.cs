//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Pedidoes = new HashSet<Pedido>();
        }

        [DisplayName("Nombre de Usuario")]
        public string ID { get; set; }
        public string Contraseña { get; set; }
        public int IdTipoEmpleado { get; set; }
        [DisplayName("Nombre Completo")]
        public string Nombre { get; set; }
        [DisplayName("Numero de Celular")]
        public int Celular { get; set; }
        [DisplayName("Correo Electronico")]
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public decimal Sueldo { get; set; }
    
        public virtual TipoEmpleado TipoEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedidoes { get; set; }
    }
}
