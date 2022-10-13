
using API.Context;
using API.Models;
using API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories.Data
{
    public class DivisiRepository : IDivisiRepository
    {
        MyContext mycontext;

        public DivisiRepository(MyContext myContext)
        {
            this.mycontext = myContext;
        }
        public int Delete(int id)
        {
            var deldiv = mycontext.Divisi.Where(a => a.Id == id).FirstOrDefault();
            mycontext.Divisi.Remove(deldiv);
            var result = mycontext.SaveChanges();
            return result;
        }

        public List<Divisi> Get()
        {
            var data = mycontext.Divisi.ToList();

            return data;
        }

        public Divisi Get(int id)
        {
            var data = mycontext.Divisi.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }

        public int Post(Divisi divisi)
        {
            mycontext.Divisi.Add(divisi);
            var result = mycontext.SaveChanges();
            return result;
        }

        public int Put(Divisi divisi)
        {
            throw new System.NotImplementedException();
        }
    }
}
