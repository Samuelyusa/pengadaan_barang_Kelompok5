using API.Models;
using API.Repositories.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]
    public class SatuanController : ControllerBase
    {
        SatuanRepository satuanRepository;

        public SatuanController( SatuanRepository satuanRepository)
        {
            this.satuanRepository = satuanRepository;
        }

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            var data = satuanRepository.Get();

            if (data.Count == 0)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //CREATE
        [HttpPost]
        public IActionResult Post(Satuan satuan)
        {
            var result = satuanRepository.Post(satuan);

            if (result > 0)
                return Ok(new { message = "Berhasil menambahkan data", statusCode = 200 });
            return BadRequest(new { messagae = "Gagal menambahkan data", statusCode = 400 });
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = satuanRepository.Delete(id);
            if (result > 0)
                return Ok(new { message = "Berhasiil menghapus data", statusCode = 200 });
            return Ok(new { message = "Gagal menghapus data", statusCode = 200 });
        }
    }
}
