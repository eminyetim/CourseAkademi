namespace BtkAkademi.Models
{
    public class Candidate
    {
        public String? Email { get; set; } = String.Empty; //? = Boş değere alabilir.
        public String? FirstName { get; set; } = String.Empty;
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