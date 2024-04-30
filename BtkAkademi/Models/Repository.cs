using BtkAkademi.Models;

namespace BtkAkademi
{
    public static class Repository
    {
        private static List<Candidate> applications = new(); // Gizli ve sınıfa ait.
        public static IEnumerable<Candidate> Application => applications;// applicationstan bir oge doner.

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}