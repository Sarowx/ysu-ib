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
    
    public partial class UserRating
    {
        public long Id { get; set; }
        public long FromUserId { get; set; }
        public long ToUserId { get; set; }
        public long CriterionId { get; set; }
        public double RatePercent { get; set; }
    
        public virtual RatingCriterion RatingCriterion { get; set; }
        public virtual User UserFrom { get; set; }
        public virtual User UserTo { get; set; }
    }
}
