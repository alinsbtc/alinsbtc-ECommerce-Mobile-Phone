using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Mobile_Phone.ViewModels
{
    public class DangNhap
    {
        [Display(Name = "Ten Dang Nhap")]
        [Required(ErrorMessage = "*")]
        [MaxLength(20, ErrorMessage = "Toi Da 20 ki Tu")]
        public string Username { get; set; }

        [Display(Name = "Ten Dang Nhap")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
