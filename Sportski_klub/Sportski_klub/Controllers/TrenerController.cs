using Sportski_klub.Models;
using Sportski_klub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Sportski_klub.Controllers
{
    public class TrenerController : ApiController
    {
        private KLUB_Entities ctx = new KLUB_Entities();


        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<TrenerViewModel> trener = null;

            using (var ctx = new KLUB_Entities())
            {
                trener = ctx.Trener.Select(c => new TrenerViewModel()
                {
                    ID=c.ID,
                    KlubID = c.KlubID,
                    IsAdmin = c.IsAdmin,
                    Ime = c.Ime,
                    Prezime = c.Prezime,
                    OIB=c.OIB,
                    Adresa=c.Adresa,
                    Username=c.Username,
                    Lozinka=c.Lozinka
                }).ToList<TrenerViewModel>();
            }

            if (trener.Count == 0)
            {
                return NotFound();
            }

            return Ok(trener);
        }
        public IHttpActionResult GetByID(int id)
        {
            TrenerViewModel trener = null;

            using (var ctx = new KLUB_Entities())
            {
                trener = ctx.Trener.Where(w=>w.ID==id).Select(c => new TrenerViewModel()
                {
                    ID = c.ID,
                    KlubID = c.KlubID,
                    IsAdmin = c.IsAdmin,
                    Ime = c.Ime,
                    Prezime = c.Prezime,
                    OIB = c.OIB,
                    Adresa = c.Adresa,
                    Username = c.Username,
                    Lozinka = c.Lozinka
                }).Single();
                
            }

            return Ok(trener);
        }
        public IHttpActionResult GetByUsernameAndLozinka(string username, string lozinka)
        {
            TrenerViewModel trener = null;
            using (var ctx = new KLUB_Entities())
            {
                try
                {
                    trener = ctx.Trener.Where(w => w.Username == username && w.Lozinka == lozinka).Select(c => new TrenerViewModel()
                    {
                        Username = c.Username,
                        Lozinka = c.Lozinka

                    }).Single();
                }
                catch (InvalidOperationException ex)
                {
                    return NotFound();
                }
                return Ok(trener);



            }
        }

        [HttpPost]
        public IHttpActionResult Post(TrenerViewModel trenerVM)
        {
            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var trener = new Trener();
                    trener.KlubID = trenerVM.KlubID;
                    trener.IsAdmin = trenerVM.IsAdmin;
                    trener.Ime = trenerVM.Ime;
                    trener.Prezime = trenerVM.Prezime;
                    trener.OIB = trenerVM.OIB;
                    trener.Adresa = trenerVM.Adresa;
                    trener.Username = trenerVM.Username;
                    trener.Lozinka = trenerVM.Lozinka;

                    ctx.Trener.Add(trener);

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                
            }
            

            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(TrenerUpdateViewModel trenerVM)
        {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var trener = ctx.Trener.Where(w => w.ID == trenerVM.ID).SingleOrDefault();
                    if (trener == null)
                    {
                        return NotFound();
                    }
                    trener.ID = trenerVM.ID;
                    trener.KlubID = trenerVM.KlubID;
                    trener.IsAdmin = trenerVM.IsAdmin;
                    trener.Ime = trenerVM.Ime;
                    trener.Prezime = trenerVM.Prezime;
                    trener.OIB = trenerVM.OIB;
                    trener.Adresa = trenerVM.Adresa;
                    trener.Username = trenerVM.Username;
                    trener.Lozinka = trenerVM.Lozinka;

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
                var trener = ctx.Trener.Where(w => w.ID == ID).SingleOrDefault();
                if (trener == null)
                {
                    return NotFound();
                }
                ctx.Trener.Remove(trener);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}

