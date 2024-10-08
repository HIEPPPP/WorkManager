namespace WorkManager.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [StringLength(200)]
        public string ShortName { get; set; }
    }
}
