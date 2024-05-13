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
    public class ClanarinaController : ApiController
    {
        private KLUB_Entities ctx = new KLUB_Entities();

        
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<ClanarinaViewModel> clanarina = null;

            using (var ctx = new KLUB_Entities())
            {
                clanarina = ctx.Clanarina.Select(c => new ClanarinaViewModel()
                {
                    ID = c.ID,
                    SportasID = c.SportasID,
                    KlubID=c.KlubID,
                    Mjesec=c.Mjesec,
                    Iznos=c.Iznos,

                }).ToList<ClanarinaViewModel>();
            }

            if (clanarina.Count == 0)
            {
                return NotFound();
            }

            return Ok(clanarina);
        }
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            ClanarinaViewModel clanarina = null;

            using (var ctx = new KLUB_Entities())
            {
                clanarina = ctx.Clanarina.Where(w => w.ID == id).Select(c => new ClanarinaViewModel()
                {
                    ID = c.ID,
                    SportasID = c.SportasID,
                    KlubID = c.KlubID,
                    Mjesec = c.Mjesec,
                    Iznos = c.Iznos,
                }).Single();

            }

            return Ok(clanarina);
        }


        [HttpPost]
        public IHttpActionResult Post(ClanarinaViewModel clanarinaVM)
        {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var clanarina = new Clanarina();
                    clanarina.SportasID = clanarinaVM.SportasID;
                    clanarina.KlubID = clanarinaVM.KlubID;
                    clanarina.Mjesec = clanarinaVM.Mjesec;
                    clanarina.Iznos = clanarinaVM.Iznos;

                    ctx.Clanarina.Add(clanarina);

                    ctx.SaveChanges();
                }

            }
            catch (Exception)
            {

            }
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(ClanarinaUpdateViewModel clanarinaVM)
        {

            try
            {
                using (var ctx = new KLUB_Entities())
                {
                    var clanarina = ctx.Clanarina.Where(w => w.ID == clanarinaVM.ID).SingleOrDefault();
                    if (clanarina == null)
                    {
                        return NotFound();
                    }
                    clanarina.ID = clanarinaVM.ID;
                    clanarina.SportasID = clanarinaVM.SportasID;
                    clanarina.KlubID = clanarinaVM.KlubID;
                    clanarina.Mjesec = clanarinaVM.Mjesec;
                    clanarina.Iznos = clanarinaVM.Iznos;

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
                var clanarina = ctx.Clanarina.Where(w => w.ID == ID).SingleOrDefault();
                if (clanarina == null)
                {
                    return NotFound();
                }
                ctx.Clanarina.Remove(clanarina);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
