using System;
using System.ComponentModel.DataAnnotations;

namespace UserWebApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Place is required")]
        [StringLength(100)]
        [Display(Name = "Country")]
        public string Place { get; set; }

        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [StringLength(15)]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Registered On")]
        public DateTime RegisteredOn { get; set; } = DateTime.Now;

        [Display(Name = "Profile Picture")]
        public string? ProfilePicturePath { get; set; }

        [Display(Name = "Latitude")]
        public double? Latitude { get; set; }

        [Display(Name = "Longitude")]
        public double? Longitude { get; set; }
    }
}

