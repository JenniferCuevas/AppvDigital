//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUscv.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDireccionIndividualizada
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public Nullable<int> fkTipoEstudio { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaTermino { get; set; }
        public string NoAlumnos { get; set; }
        public string Estatus { get; set; }
        public Nullable<int> fkinstitucionSuperior { get; set; }
        public string ConsideraCurriculum { get; set; }
        public Nullable<int> fkPersonal { get; set; }
    
        public virtual catInstitucionSuperior catInstitucionSuperior { get; set; }
        public virtual catTipoEstudio catTipoEstudio { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
