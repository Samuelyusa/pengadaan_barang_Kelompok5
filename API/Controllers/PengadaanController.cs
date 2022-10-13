using API.Models;
using API.Repositories.Data;
using API.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]

    public class PengadaanController : ControllerBase
    {
        PengadaanRepositiry pengadaanRepositiry;

        public PengadaanController(PengadaanRepositiry pengadaanRepositiry)
        {
            this.pengadaanRepositiry = pengadaanRepositiry;
        }

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            var data = pengadaanRepositiry.Get();

            if (data.Count == 0)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //READ BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = pengadaanRepositiry.Get(id);

            if (data == null)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //UPDATE
        [HttpPut("{id}")]
        public IActionResult Put(int id,EditPengadaan Pengadaan)
        {
            var result = pengadaanRepositiry.Put(Pengadaan);
            if (result > 0)
                return Ok(new { message = "Berhasil mengambil data", statusCode = 200 });
            return BadRequest(new { messagae = "Gagal mengambil data", statusCode = 400 });
        }

        //CREATE
        [HttpPost]
        public IActionResult Post(TambahPengadaan Pengadaan)
        {
            var result = pengadaanRepositiry.Post(Pengadaan);

            if (result > 0)
                return Ok(new { message = "Berhasil menambahkan data", statusCode = 200 });
            return BadRequest(new { messagae = "Gagal menambahkan data", statusCode = 400 });
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = pengadaanRepositiry.Delete(id);
            if (result > 0)
                return Ok(new { message = "Berhasiil menghapus data", statusCode = 200 });
            return Ok(new { message = "Gagal menghapus data", statusCode = 200 });
        }
    }
}
