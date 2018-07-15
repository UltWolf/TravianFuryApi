using System.Collections.Generic;

namespace ApiFury.Models
{
    public class VillagesAdd
    {
        public int IdUser{get;set;}
        public string Token{get;set;}
        public List<Villages> village{get;set;}
    }
}