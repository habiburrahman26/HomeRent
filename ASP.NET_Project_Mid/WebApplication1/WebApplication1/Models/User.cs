//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public User()
        {
            this.Bookings = new HashSet<Booking>();
            this.Flats = new HashSet<Flat>();
        }

        public int UserId { get; set; }

        [Required(ErrorMessage = "Username can't be empty")]
        [MaxLength(10, ErrorMessage = "Username less than 10 character")]
        [MinLength(2, ErrorMessage = "Username must be greater than 2 character")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email can't be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can't be empty")]
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Flat> Flats { get; set; }
    }
}
