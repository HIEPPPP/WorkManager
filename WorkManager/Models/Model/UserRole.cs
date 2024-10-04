namespace WorkManager.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRole")]
    public partial class UserRole
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string UserCode { get; set; }

        public string RoleName { get; set; }
    }
}
