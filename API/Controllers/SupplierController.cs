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

    public class SupplierController : ControllerBase
    {
        SupplierRepository SupplierRepository { get; set; }

        public SupplierController(SupplierRepository SupplierRepository)
        {
            this.SupplierRepository = SupplierRepository;
        }

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            var data = SupplierRepository.Get();

            if (data.Count == 0)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //READ BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = SupplierRepository.Get(id);

            if (data == null)
                return Ok(new { message = "Data yang anda ambil TIDAK ADA", statusCode = 200, data = data });
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = data });
        }

        //UPDATE
        [HttpPut("{id}")]
        public IActionResult Put(int id,Supplier supplier)
        {
            var result = SupplierRepository.Put(supplier);
            if (result > 0)
                return Ok(new { message = "Berhasil mengambil data", statusCode = 200 });
            return BadRequest(new { messagae = "Gagal mengambil data", statusCode = 400 });
        }

        //CREATE
        [HttpPost]
        public IActionResult Post(Supplier supplier)
        {
            var data = SupplierRepository.Post(supplier);


            if (data != null)
                return Ok(new { message = "Tambah Product Success", statusCode = 200, data = data });
            return BadRequest(new { message = "Tambah Product Failed", statusCode = 400 });
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = SupplierRepository.Delete(id);
            if (result > 0)
                return Ok(new { message = "Berhasiil menghapus data", statusCode = 200 });
            return Ok(new { message = "Gagal menghapus data", statusCode = 200 });
        }
    }
}
