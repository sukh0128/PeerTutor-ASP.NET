using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PeerTutor.Models
{
   

    [Table("dbo.Course")]
    public partial class Course
    {
        public string Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Area { get; set; }

        [Required]
        [StringLength(30)]
        public string Number { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
