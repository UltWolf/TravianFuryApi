using ApiFury.Entities;
using ApiFury.Helpers;
using ApiFury.Models;
using ApiFury.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace ApiFury.Controllers
{ 
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TravianController: ControllerBase
    {
        private ITravianServices _ts;
        public TravianController(ITravianServices ts){
            _ts = ts;
        }
        [HttpPost("Add")]
        public IActionResult AddVillage([FromBody]VillageAdd vil) {
           if(_ts.Add(vil.Token,vil.IdUser,vil.village)){
                      return  Ok();
           }
            return BadRequest();
        }
         [HttpPost("AddAll")]
        public IActionResult AddVillage([FromBody]VillagesAdd vil) {
           if(_ts.Add(vil.Token,vil.IdUser,vil.village)){
                      return  Ok();
           }
            return BadRequest();
        }
        [HttpPost("Sync")]
        public IActionResult SyncVillage([FromBody]VillageAdd vil) {
           var ListVillage = _ts.Sync(vil.Token,vil.IdUser);
           if(ListVillage!=null){
                      return  Ok(ListVillage);
           }
            return BadRequest();
        }
    }
}