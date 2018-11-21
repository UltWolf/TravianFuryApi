using ApiFury.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiFury.Entities
{
    public class User
    {
       
        public int Id { get; set; }
        //Server , where our player play
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //This village we are farm
        public List<Villages> Villages {get;set;}
        //This our villages
        public List<MyVillages> MyVillages {get;set;}
       
        public List<Task> tasks{get;set;}
        public string token    {get;set;}
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public User(){
            Villages = new List<Villages>();
            MyVillages = new List<MyVillages>();
        }

    }
}