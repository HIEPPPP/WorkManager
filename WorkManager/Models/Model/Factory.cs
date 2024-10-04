namespace WorkManager.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factory")]
    public partial class Factory
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
