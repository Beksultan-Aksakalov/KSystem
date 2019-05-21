//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEF.MyDbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Training
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Training()
        {
            this.Selection = new HashSet<Selection>();
        }
    
        public int Id { get; set; }
        public string Resource { get; set; }
        public string Course { get; set; }
        public string Duration { get; set; }
        public Nullable<double> FinalEvaluation { get; set; }
        public string ProjectPhoto { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> KnowledgeId { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual City City { get; set; }
        public virtual Knowledge Knowledge { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selection> Selection { get; set; }
    }
}
