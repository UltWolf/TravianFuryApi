using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ApiFury.Models
{
    [Owned]
    public class Transport
    {
        public int Id { get; set; }
        public int ResourceWood{get;set;}
        public int ResourceIron{get;set;}
        public int ResourceClay{get;set;}
        public int ResourceCrop{get;set;}
        [Required]
        public string FromVillage{get;set;}
        [Required]
        public string DestinationVillage{get;set;}

    }
}