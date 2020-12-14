using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();

        //current property, RR instance, will be consistent between requests
        public static ReservationRepository Current
        {
            get
            {
                return repo;
            }
        }

       
    }
}