//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YSUIB.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItem
    {
        public long Id { get; set; }
        public long NameT { get; set; }
        public long LinkId { get; set; }
        public string Type { get; set; }
    
        public virtual Link Link { get; set; }
        public virtual Translation NameTranslation { get; set; }
    }
}
