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
    public class SportasController : ApiController
    {
        private KLUB_Entities ctx = new KLUB_Entities();


        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<SportasViewModel> sportas = null;

            using (var ctx = new KLUB_Entities())
            {
                sportas = ctx.Sportas.Select(c => new SportasViewModel()
                {
                    ID = c.ID,
                    KlubID = c.KlubID,
                    TrenerID = c.TrenerID,
                    Ime = c.Ime,
                    Prezime = c.Prezime,
                    DatumRodenja = c.DatumRodenja,
                    OIB = c.OIB,
                    MjestoStanovanja = c.MjestoStanovanja,
                    Adresa = c.Adresa,
                    LijecnickiPregledVrijediDo = c.LijecnickiPregledVrijediDo,
                    DatumUpisa = c.DatumUpisa,
                }).ToList<SportasViewModel>();
            }

            if (sportas.Count == 0)
            {
                return NotFound();
            }

            return Ok(sportas);
        }
        public IHttpActionResult GetByID(int id)
        {
            SportasViewModel sportas = null;

            using (var ctx = new KLUB_Entities())
            {
                sportas = ctx.Sportas.Where(w => w.ID == id).Select(c => new SportasViewModel()
                {
                    ID = c.ID,
                    KlubID = c.KlubID,
                    TrenerID = c.TrenerID,
                    Ime = c.Ime,
                    Prezime = c.Prezime,
                    DatumRodenja = c.DatumRodenja,
                    OIB = c.OIB,
                    MjestoStanovanja = c.MjestoStanovanja,
                    Adresa = c.Adresa,
                    LijecnickiPregledVrijediDo = c.LijecnickiPregledVrijediDo,
                    DatumUpisa = c.DatumUpisa,
                }).Single();

            }

            return Ok(sportas);
        }

        [HttpPost]
        public IHttpActionResult Post(SportasViewModel sportasVM)
        {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var sportas = new Sportas();
                    sportas.KlubID = sportasVM.KlubID;
                    sportas.TrenerID = sportasVM.TrenerID;
                    sportas.Ime = sportasVM.Ime;
                    sportas.Prezime = sportasVM.Prezime;
                    sportas.DatumRodenja = sportasVM.DatumRodenja;
                    sportas.OIB = sportasVM.OIB;
                    sportas.MjestoStanovanja = sportasVM.MjestoStanovanja;
                    sportas.Adresa = sportasVM.Adresa;
                    sportas.LijecnickiPregledVrijediDo = sportasVM.LijecnickiPregledVrijediDo;
                    sportas.DatumUpisa = sportasVM.DatumUpisa;

                    ctx.Sportas.Add(sportas);

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

            }

            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(SportasUpdateViewModel sportasVM)
        {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var sportas = ctx.Sportas.Where(w => w.ID == sportasVM.ID).SingleOrDefault();
                    if (sportas == null)
                    {
                        return NotFound();
                    }
                    sportas.ID = sportasVM.ID;
                    sportas.KlubID = sportasVM.KlubID;
                    sportas.TrenerID = sportasVM.TrenerID;
                    sportas.Ime = sportasVM.Ime;
                    sportas.Prezime = sportasVM.Prezime;
                    sportas.DatumRodenja = sportasVM.DatumRodenja;
                    sportas.MjestoStanovanja = sportasVM.MjestoStanovanja;
                    sportas.Adresa = sportasVM.Adresa;
                    sportas.LijecnickiPregledVrijediDo = sportasVM.LijecnickiPregledVrijediDo;
                    sportas.DatumUpisa = sportasVM.DatumUpisa;

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
                var sportas = ctx.Sportas.Where(w => w.ID == ID).SingleOrDefault();
                if (sportas == null)
                {
                    return NotFound();
                }
                ctx.Sportas.Remove(sportas);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
