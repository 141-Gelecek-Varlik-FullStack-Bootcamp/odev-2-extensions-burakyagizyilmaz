using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mail adresi zorunludur.")]
        [StringLength(50, ErrorMessage = "Mail adresi 50 karakterden uzun olamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi girmelisiniz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "İsim zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim zorunludur")]
        public string SurName { get; set; }

        public  string FullName { get => Name + " " + SurName;}

        public string Password { get; set; }

    }
}
