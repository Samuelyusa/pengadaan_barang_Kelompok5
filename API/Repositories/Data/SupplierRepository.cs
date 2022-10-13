
using API.Context;
using API.Models;
using API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories.Data
{
    public class SupplierRepository 
    {
        MyContext mycontext;

        public SupplierRepository(MyContext myContext)
        {
            this.mycontext = myContext;
        }
        public int Delete(int id)
        {
            var delsup = mycontext.Supplier.Where(a => a.Id == id).FirstOrDefault();
            mycontext.Supplier.Remove(delsup);
            var result = mycontext.SaveChanges();
            return result;
        }

        public List<Supplier> Get()
        {
            var data = mycontext.Supplier.ToList();

            return data;
        }

        public Supplier Get(int id)
        {
            var data = mycontext.Supplier.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }

        public int Post(Supplier Supplier)
        {
            mycontext.Supplier.Add(Supplier);
            var result = mycontext.SaveChanges();
            return result;
        }

        public int Put(Supplier Supplier)
        {
            var data = Get(Supplier.Id);
            data.Nama = Supplier.Nama;
            data.Kota = Supplier.Kota;
            data.Email = Supplier.Email;
            data.Alamat = Supplier.Alamat;
            data.Telepon = Supplier.Telepon;
             mycontext.Supplier.Update(data);
            var result = mycontext.SaveChanges();
            return result;
        }
    }
}
