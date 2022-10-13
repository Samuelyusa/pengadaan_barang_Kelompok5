using API.Models;
using API.Repositories.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisiController : ControllerBase
    {
        DivisiRepository divisiRepository;

        public DivisiController(DivisiRepository divisiRepository)
        {
            this.divisiRepository = divisiRepository;
        }

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            var data = divisiRepository.Get();

            if (data.Count == 0)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //READ BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = divisiRepository.Get(id);

            if (data == null)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //UPDATE
        [HttpPut("{id}")]
        public IActionResult Put(int id,Divisi divisi)
        {
            var result = divisiRepository.Put(divisi);
            if (result > 0)
                return Ok(new { message = "Berhasil mengambil data", statusCode = 200 });
            return BadRequest(new { messagae = "Gagal mengambil data", statusCode = 400 });
        }

        //CREATE
        [HttpPost]
        public IActionResult Post(Divisi divisi)
        {
            var result = divisiRepository.Post(divisi);

            if (result > 0)
                return Ok(new { message = "Berhasil menambahkan data", statusCode = 200 });
            return BadRequest(new { messagae = "Gagal menambahkan data", statusCode = 400 });
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = divisiRepository.Delete(id);
            if (result > 0)
                return Ok(new { message = "Berhasiil menghapus data", statusCode = 200 });
            return Ok(new { message = "Gagal menghapus data", statusCode = 200 });
        }
    }
}
