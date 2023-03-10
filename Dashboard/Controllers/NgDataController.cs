using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NgDataController : ControllerBase
    {
        private List<ReservationModel> reservations = new List<ReservationModel>()
        {
            new ReservationModel
            {
                NoOfRes = 1,
                Date = new DateTime(2023, 3, 1), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 10,
                Date = new DateTime(2023, 3, 30), // year, month, day
                Payment = 90
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<ReservationModel>> GetReservationData()
        {
            return Ok(reservations);
        }
    }
}
