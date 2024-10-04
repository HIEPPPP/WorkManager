namespace WorkManager.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string UserCode { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }

        public string Department { get; set; }
    }
}
