//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public factura()
        {
            this.detalle_factura = new HashSet<detalle_factura>();
        }
    
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int Estado { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public decimal Pagado { get; set; }
        public decimal Cambio { get; set; }
        public decimal C_total { get; set; }
        public decimal T_Itbis { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_factura> detalle_factura { get; set; }
    }
}
