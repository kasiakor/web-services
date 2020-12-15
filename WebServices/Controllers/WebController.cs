using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class WebController : ApiController
    {

        private ReservationRepository repo = ReservationRepository.Current;
        // GET: Web
        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }

        public Reservation GetReservations( int id)
        {
            return repo.Get(id);
        }

        public Reservation PostReservations(Reservation item)
        {
            return repo.Add(item);
        }

        public void  DeleteReservations(int id)
        {
            repo.Remove(id);
        }
    }
}