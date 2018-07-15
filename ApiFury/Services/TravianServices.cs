using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ApiFury.Entities;
using ApiFury.Models;

namespace ApiFury.Services
{
    
public interface ITravianServices
{
    List<Villages> Sync(string token,int UserId);
    bool Add(string token, int UserID,Villages villageID);
    bool Add(string token, int UserID, List<Villages> Villages);


}    
    public class TravianServices:ITravianServices
    {
        private DataContext _db;
        public TravianServices(DataContext db){
           _db = db;
        }

        public bool Add(string token, int UserID, Villages vil)
        {
            User us = _db.Users.SingleOrDefault(m=>m.token==token);
           if(CheckOutUser(token,  UserID,us)){
            us.Villages.Add(vil);
            _db.Users.Update(us);
            _db.SaveChanges();
            return true;
           }
           return false;
        }
        private bool CheckOutUser(string token, int UserID,User us){
         
            if(us==null){
                return false;
            }
            
            if(us.Id !=_db.Users.SingleOrDefault(m=>m.Id==UserID).Id){
                       return false;
            }
            return true;
        }
        public bool Add(string token, int UserID, List<Villages> Villages)
        {
            User us = _db.Users.SingleOrDefault(m=>m.token==token);
           if(CheckOutUser(token,  UserID,us)){
            us.Villages.AddRange(Villages);
            _db.Users.Update(us);
            _db.SaveChanges();
            return true;
           }
           return false;
        }

        public List<Villages> Sync(string token, int UserId)
        { 
            User us = _db.Users.SingleOrDefault(m=>m.token==token);
           if(us==null){
                return null;
            }
            
            if(us.Id !=_db.Users.SingleOrDefault(m=>m.Id==UserId).Id){
                       return null;
            }
           return us.Villages;
        }
    }
}