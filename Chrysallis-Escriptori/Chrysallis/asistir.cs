//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chrysallis
{
    using System;
    using System.Collections.Generic;
    
    public partial class asistir
    {
        public int id_socio { get; set; }
        public int id_evento { get; set; }
        public Nullable<int> valoracion { get; set; }
        public string comentario { get; set; }
        public int cuantos { get; set; }
    
        public virtual eventos eventos { get; set; }
        public virtual socios socios { get; set; }
    }
}