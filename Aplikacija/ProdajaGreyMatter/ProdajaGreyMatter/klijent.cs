//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProdajaGreyMatter
{
    using System;
    using System.Collections.Generic;
    
    public partial class klijent
    {
        public klijent()
        {
            this.narudzbenica = new HashSet<narudzbenica>();
        }
    
        public string oib { get; set; }
        public string naziv { get; set; }
        public string telefon { get; set; }
        public string e_mail { get; set; }
        public string adresa { get; set; }
        public string ziroRacun { get; set; }
    
        public virtual ICollection<narudzbenica> narudzbenica { get; set; }
    }
}