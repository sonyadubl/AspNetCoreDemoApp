using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemoApp.Model
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        public string Description { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        public int Semester { get; set; }

        [Required, ForeignKey("Institute")]
        public long FK_Institute { get; set; }
        public Institute Institute { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(350)]
        public string Password { get; set; }

        [Required, MaxLength(350)]
        public string Token { get; set; }
    }
}
