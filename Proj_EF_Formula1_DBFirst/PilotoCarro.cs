//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proj_EF_Formula1_DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class PilotoCarro
    {
        public int id_piloto { get; set; }
        public int id_carro { get; set; }
        public System.DateTime data_evento { get; set; }
    
        public virtual Carro Carro { get; set; }
        public virtual Piloto Piloto { get; set; }
    }
}
