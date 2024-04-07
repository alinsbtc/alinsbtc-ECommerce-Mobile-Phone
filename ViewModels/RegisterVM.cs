using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Commerce_Mobile_Phone.Data;

namespace E_Commerce_Mobile_Phone.ViewModels
{
    public class RegisterVM
    {

        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public string Fullname { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public byte? Gender { get; set; }

        public DateOnly Birthday { get; set; }

        public string Address { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateTime Created { get; set; }

        public bool Trash { get; set; }

        public bool Access { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<DbOrder> DbOrders { get; set; } = new List<DbOrder>();




    }
}
