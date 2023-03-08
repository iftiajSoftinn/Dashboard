using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ReservationDetails()
        {
            List<ReservationModel> reservationDetails = new List<ReservationModel>()
            {
                new ReservationModel
                {
                    NoOfRes = 1,
                    Date = new DateTime(2023, 3, 1), // // year, month, day
                    Payment = 100
                },

                new ReservationModel
                {
                    NoOfRes = 2,
                    Date = new DateTime(2023, 3, 2), // // year, month, day
                    Payment = 90
                },                
                new ReservationModel
                {
                    NoOfRes = 3,
                    Date = new DateTime(2023, 3, 3), // // year, month, day
                    Payment = 100
                },

                new ReservationModel
                {
                    NoOfRes = 4,
                    Date = new DateTime(2023, 3, 4), // // year, month, day
                    Payment = 90
                },                
                new ReservationModel
                {
                    NoOfRes = 5,
                    Date = new DateTime(2023, 3, 5), // // year, month, day
                    Payment = 100
                },

                new ReservationModel
                {
                    NoOfRes = 6,
                    Date = new DateTime(2023, 3, 6), // // year, month, day
                    Payment = 90
                },                
                new ReservationModel
                {
                    NoOfRes = 7,
                    Date = new DateTime(2023, 3, 7), // // year, month, day
                    Payment = 100
                },

                new ReservationModel
                {
                    NoOfRes = 8,
                    Date = new DateTime(2023, 3, 8), // // year, month, day
                    Payment = 90
                },                
                new ReservationModel
                {
                    NoOfRes = 9,
                    Date = new DateTime(2023, 3, 9), // // year, month, day
                    Payment = 100
                },

                new ReservationModel
                {
                    NoOfRes = 10,
                    Date = new DateTime(2023, 3, 10), // // year, month, day
                    Payment = 90
                }
            };
            ViewBag.List = reservationDetails;
            ViewData["reservationDeatails"] = reservationDetails;

            return View(reservationDetails);
        }
    }
}
