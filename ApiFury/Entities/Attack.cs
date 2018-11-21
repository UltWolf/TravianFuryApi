using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ApiFury.Models
{
    [Owned]
    public class Attack
    {
        public int Id { get; set; }
        public int Troop_1 { get; set; }
        public int Troop_2 { get; set; }
        public int Troop_3 { get; set; }
        public int Troop_4 { get; set; }
        public int Troop_5 { get; set; }
        public int Troop_6 { get; set; }
        public int Troop_7 { get; set; }
        public int Troop_8 { get; set; }
        public int Troop_9 { get; set; }

        [Required]
        public string SourceVillage { get; set; }
        [Required]
        public string DestinationVillage { get; set; }

    }
}