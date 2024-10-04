namespace WorkManager.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Request")]
    public partial class Request
    {
        public int Id { get; set; }

        [StringLength(599)]
        public string RequestType { get; set; }
        public string RequestBy { get; set; }

        public string Description { get; set; }

        public string Department { get; set; }

        [StringLength(200)]
        public string Factory { get; set; }

        public string Location { get; set; }

        [StringLength(500)]
        public string Status { get; set; }

        public string AssignedTo { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
