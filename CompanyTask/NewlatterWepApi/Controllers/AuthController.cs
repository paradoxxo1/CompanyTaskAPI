using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewlatterWepApi.Context;
using NewlatterWepApi.Dtos;
using NewlatterWepApi.Models;

namespace NewlatterWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly NewslatterDb _context;

        public AuthController(NewslatterDb context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var isUserNameExsist = await _context.Users.Where(p=> p.UserName == registerDto.UserName).FirstOrDefaultAsync();
            if (isUserNameExsist != null)
            {
                return BadRequest("Bu kullanıcı adı daha önce alınmış!");
            }

            var isEmailExsist = await _context.Users.Where(p => p.Email == registerDto.Email).FirstOrDefaultAsync();
            if (isEmailExsist != null)
            {
                return BadRequest("Bu E-mail daha önce alınış!");
            };


            User user = new()
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                Password = registerDto.Password,
                NameLastname = registerDto.NameLastName
            };


            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return Ok("Kayıt İşlemi başarıyla tamamlandı!");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _context.Users.Where(p=> p.UserName == loginDto.UserName).FirstOrDefaultAsync();
            if (user == null)
                user = await _context.Users.Where(p => p.Email == loginDto.UserName).FirstOrDefaultAsync();

            if (user == null)
                return BadRequest("Kullanıcı adı / email adresi bulunamadı!");
            if (user.Password == loginDto.Password)
                return Ok("Kullanıcı girişi başarılı");
            else
                return BadRequest("Şifrenizi yanlış girdiniz!");
        }
    }
}
