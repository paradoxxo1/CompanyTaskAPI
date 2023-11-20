using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewlatterWepApi.Context;
using NewlatterWepApi.Models;

namespace NewlatterWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewslatterDb _context;

        public NewsController(NewslatterDb context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _context.Newslaters.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _context.Newslaters.FindAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Newslatter newslatter)
        {
            newslatter.CreatedDate = DateTime.Now;
            await _context.Newslaters.AddAsync(newslatter);
            await _context.SaveChangesAsync();

            return Ok("Haber Kaydı başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> Put(Newslatter newslatter)
        {
            _context.Newslaters.Update(newslatter);
            await _context.SaveChangesAsync();

            return Ok("Haber Kaydı Başarılı bir şekilde güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.Newslaters.FindAsync(id);
            _context.Newslaters.Remove(result);
            await _context.SaveChangesAsync();

            return Ok("Haber Kaydı Başarılı bir şekilde silindi");
        }
    }
}
