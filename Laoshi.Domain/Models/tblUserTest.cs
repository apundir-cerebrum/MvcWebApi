namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserTest")]
    public partial class tblUserTest
    {
        public int Id { get; set; }

        public int? LoginId { get; set; }

        [StringLength(500)]
        public string TestTitle { get; set; }

        public int? TestType { get; set; }

        public int? TestCategory { get; set; }

        public TimeSpan? TimeToComplete { get; set; }

        public int? MaxAttempts { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AvailabilityFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AvailabilityTo { get; set; }

        public int? QuestionsToDisplay { get; set; }

        public decimal? PassPercentage { get; set; }

        public string TestPassword { get; set; }

        public string TestLink { get; set; }

        public bool? IsRandomDisplay { get; set; }

        public bool? IsNegativeMarking { get; set; }

        public bool? IsSendCertificate { get; set; }

        public bool? IsSendEmail { get; set; }

        public bool? IsPrint { get; set; }

        public bool? IsPasswordProtected { get; set; }

        public bool? IsTestByLink { get; set; }

        public virtual UserLogin tblLogin { get; set; }
    }
}
