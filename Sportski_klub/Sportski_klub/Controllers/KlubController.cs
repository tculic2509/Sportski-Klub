using Sportski_klub.Models;
using Sportski_klub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sportski_klub.Controllers
{
    public class KlubController : ApiController
    {
        private KLUB_Entities ctx = new KLUB_Entities();


        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<KlubViewModel> klub = null;

            using (var ctx = new KLUB_Entities())
            {
                klub = ctx.Klub.Select(s => new KlubViewModel()
                {
                    ID = s.ID,
                    ImeKluba = s.ImeKluba,
                    DatumOsnivanja = s.DatumOsnivanja,
                    OIB=s.OIB,
                    Clanarina=s.Clanarina,
                    Adresa=s.Adresa,
                }).ToList<KlubViewModel>();
            }

            if (klub.Count == 0)
            {
                return NotFound();
            }

            return Ok(klub);
        }
        public IHttpActionResult GetByID(int id)
        {
            KlubViewModel klub = null;

            using (var ctx = new KLUB_Entities())
            {
                klub = ctx.Klub.Where(w => w.ID == id).Select(c => new KlubViewModel()   
                {
                    ID =c.ID,
                    ImeKluba = c.ImeKluba,
                    DatumOsnivanja = c.DatumOsnivanja,
                    OIB=c.OIB,
                    Clanarina=c.Clanarina,
                    Adresa=c.Adresa,
                }).Single();

            }

            return Ok(klub);
        }

        [HttpPost]
        public IHttpActionResult Post(KlubViewModel klubVM)
        {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var klub = new Klub();
                    klub.ImeKluba = klubVM.ImeKluba;
                    klub.DatumOsnivanja = klubVM.DatumOsnivanja;
                    klub.OIB = klubVM.OIB;
                    klub.Clanarina = klubVM.Clanarina;
                    klub.Adresa = klubVM.Adresa;

                    ctx.Klub.Add(klub);

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

            }

            return Ok();
        }
       [HttpPut]
        public IHttpActionResult Put(KlubUpdateViewModel klubVM)
       {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var klub = ctx.Klub.Where(w => w.ID == klubVM.ID).SingleOrDefault();
                    if (klub == null)
                    {
                        return NotFound();
                    }
                    klub.ImeKluba = klubVM.ImeKluba;
                    klub.DatumOsnivanja = klubVM.DatumOsnivanja;
                    klub.OIB = klubVM.OIB;
                    klub.Clanarina = klubVM.Clanarina;
                    klub.Adresa = klubVM.Adresa;

                    ctx.SaveChanges();
                }

            }
            catch (Exception)
            {

            }

           return Ok();
       }
       [HttpDelete]
       public IHttpActionResult Delete(int ID)
       {

           using (var ctx = new KLUB_Entities())
           {
               var klub = ctx.Klub.Where(w => w.ID == ID).SingleOrDefault();
               if (klub == null)
               {
                   return NotFound();
               }
               ctx.Klub.Remove(klub);

               ctx.SaveChanges();
           }

           return Ok();
       }
    }
}

