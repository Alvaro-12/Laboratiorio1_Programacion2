//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1_CalculadoraNotas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblNotasEstudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<double> Lab1 { get; set; }
        public Nullable<double> Lab2 { get; set; }
        public Nullable<double> Lab3 { get; set; }
        public Nullable<double> Parcial1 { get; set; }
        public Nullable<double> Parcial2 { get; set; }
        public Nullable<double> Parcial3 { get; set; }
    }
}