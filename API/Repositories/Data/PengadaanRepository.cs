
using API.Context;
using API.Models;
using API.Repositories.Interface;
using API.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories.Data
{
    public class PengadaanRepositiry 
    {
        MyContext myContext;

        public PengadaanRepositiry(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(int id)
        {
            var pengadaan = myContext.Pengadaan.Where(a => a.Id == id).FirstOrDefault();
            myContext.Pengadaan.Remove(pengadaan);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Pengadaan> Get()
        {
             var data = myContext.Pengadaan.Include(x => x.IdSupplierNavigation).
                        Include(y => y.IdBarangNavigation).
                        Include(z => z.IdStatusNavigation).
                        Include(p => p.IdDivisiNavigation)
                        .ToList();

            return data;
        }

        public Pengadaan Get(int id)
        {
             var data = myContext.Pengadaan.Where(a => a.Id == id).FirstOrDefault();
             return data;
        }

        public int Post(TambahPengadaan pengadaan)
        {
            Pengadaan tmbhpengadaan = new Pengadaan()
            {
               IdBarang =pengadaan.IdBarang,
               IdSupplier = pengadaan.IdSupplier,
               Kuantitas = pengadaan.Kuantitas,
               Totals = pengadaan.Totals,
               IdDivisi = pengadaan.IdDivisi,
               IdStatus = 1

               

            };
            myContext.Pengadaan.Add(tmbhpengadaan);
                var result = myContext.SaveChanges();
                return result;
        }

        public int Put(EditPengadaan pengadaan)
        {
            var data = Get(pengadaan.Id);


            data.IdBarang = pengadaan.IdBarang;
            data.IdSupplier = pengadaan.IdSupplier;
            data.Kuantitas = pengadaan.Kuantitas;
            data.Totals = pengadaan.Kuantitas;
            data.IdStatus = pengadaan.IdStatus;
            data.IdDivisi = pengadaan.IdDivisi;
           
            myContext.Pengadaan.Update(data);
            var result = myContext.SaveChanges();
            return result;

        }
    }
}
