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
{   [Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
  
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;
 
        public AccountController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
 
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserDB userDto)
        {
            var user = _userService.Authenticate(userDto.Username, userDto.Password);
 
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
 
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            _userService.TokenUpdate(user,tokenString);
            
            return Ok(new {
                Id = user.Id,
                Username = user.Username,
                Server = user.Server,
                Token = tokenString
            });
        }
 
        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserDB userDto)
        {
            var user = _mapper.Map<User>(userDto);
 
            try
            {
                _userService.Create(user, userDto.Password);
                return Ok();
            } 
            catch(AppException ex)
            {
                return BadRequest(new { message = ex.Message+ userDto.ToString() });
            }
        }
 
        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            var userDtos = _mapper.Map<IList<UserDB>>(users);
            return Ok(userDtos);
        }
 
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user =  _userService.GetById(id);
            var userDto = _mapper.Map<UserDB>(user);
            return Ok(userDto);
        }
 
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]UserDB userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.Id = id;
 
            try
            {
                _userService.Update(user, userDto.Password);
                return Ok();
            } 
            catch(AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
     
    }
}