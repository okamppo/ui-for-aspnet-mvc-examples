//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KendoSchedulerWithServerRecurrence.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weather
    {
        public int ID { get; set; }
        public string Station { get; set; }
        public System.DateTime Date { get; set; }
        public decimal TMax { get; set; }
        public decimal TMin { get; set; }
        public decimal Wind { get; set; }
        public Nullable<decimal> Gust { get; set; }
        public decimal Rain { get; set; }
        public Nullable<decimal> Snow { get; set; }
        public string Events { get; set; }
    }
}
