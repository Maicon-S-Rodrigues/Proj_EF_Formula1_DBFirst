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

    public partial class Carro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carro()
        {
            this.PilotoCarro = new HashSet<PilotoCarro>();
        }

        public int id_equipe { get; set; }
        public int id { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public int unidade { get; set; }

        public virtual Equipe Equipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotoCarro> PilotoCarro { get; set; }
        public override string ToString()
        {
            return $"\n ID do Carro: {this.id} \n Modelo: {this.modelo}\n Ano de fabricação: {this.ano}" +
                   $"\n Unidade: {this.unidade}\n Equipe: {this.Equipe.ToString()}\n ".ToString();
        }
    }
}
