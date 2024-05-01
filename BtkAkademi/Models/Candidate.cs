using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email is required.")]
        public String? Email { get; set; } = String.Empty; //? = Boş değere alabilir.
        [Required(ErrorMessage ="FirstName is required")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage ="LastName is Required")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}" ;//? = eğer boş değilse çalıştırır.
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()
        {
            ApplyAt = DateTime.Now; // Bu class çalıştırıldığında o anki tarih atanır.
        }

    }
}