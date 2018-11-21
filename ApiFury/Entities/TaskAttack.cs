using System.Collections.Generic;
using ApiFury.Entities;

namespace ApiFury.Models
{
    public class TaskAttack
    {
        public int Id { get; set; }
        public List<Attack> attack{get;set;}
        public Task task{get;set;}

    }
}