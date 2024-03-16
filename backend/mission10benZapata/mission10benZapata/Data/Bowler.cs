using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission10benZapata.Data
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }

        [ForeignKey("TeamID")]
        public int TeamID { get; set; }
        public Team Team { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Bowler ID: {BowlerID}");
            Console.WriteLine($"Last Name: {BowlerLastName ?? "N/A"}");
            Console.WriteLine($"First Name: {BowlerFirstName ?? "N/A"}");
            Console.WriteLine($"Middle Initial: {BowlerMiddleInit ?? "N/A"}");
            Console.WriteLine($"Address: {BowlerAddress ?? "N/A"}");
            Console.WriteLine($"City: {BowlerCity ?? "N/A"}");
            Console.WriteLine($"State: {BowlerState ?? "N/A"}");
            Console.WriteLine($"Zip: {BowlerZip ?? "N/A"}");
            Console.WriteLine($"Phone Number: {BowlerPhoneNumber ?? "N/A"}");
            Console.WriteLine($"Team ID: {TeamID}"); // No need for null-coalescing operator here
        }
    }
}
