using SeminarMVC.Models;
using SeminarMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net;
using System.Web.Http;

namespace SeminarMVC.Areas.Api.Controllers
{
    public class RestoranController : ApiController
    {
        private RestoranRepository _restoranRepository;
        public RestoranController(RestoranRepository restoranRepository)
        {
            this._restoranRepository = restoranRepository;
        }
        public List<RestoranDTO> Get()
        {
            return this._restoranRepository.GetAllDTO();
        }
        public RestoranDTO Get(int id)
        {
            return this._restoranRepository.GetDTO(id);
        }
        public List<RestoranDTO> Get(string q)
        {
            return this._restoranRepository.GetAllDTO(q);
        }
        public IHttpActionResult Post([FromBody]RestoranDTO value)
        {
            var restoran = new Restoran();
            restoran.Adresa = value.Adresa;
            restoran.Ime = value.Ime;
            restoran.GradID = value.GradID;
            restoran.Kapacitet = value.Kapacitet;
            restoran.Zvez = value.Zvez;
            this._restoranRepository.Add(restoran, autoSave: true);
            return this.Ok();
        }
       public IHttpActionResult Delete(int id)
        {
            this._restoranRepository.Delete(id, autoSave: true);
            return this.Ok();
        }
    }
}