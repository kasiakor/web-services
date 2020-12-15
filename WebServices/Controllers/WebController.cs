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
            //matches routing api/
            return repo.GetAll();
        }

        public Reservation GetReservation( int id)
        {
            return repo.Get(id);
        }

        public Reservation PostReservation(Reservation item)
        {
            return repo.Add(item);
        }

        public void  DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}