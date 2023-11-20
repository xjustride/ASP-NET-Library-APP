﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        public int ContactId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birth { get; set; }
        public int Priority { get; set; }
        public OrganizationEntity Organization { get; set; }
        public int? OrgaznizationId { get; set; }

    }
}
