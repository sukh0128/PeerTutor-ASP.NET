using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PeerTutor.Models
{

    [Table("dbo.Tutor")]
    public partial class Tutor
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(30)]
        public string Major { get; set; }

        [Required]
        [StringLength(30)]
        public string  Year { get; set; }


    }

}