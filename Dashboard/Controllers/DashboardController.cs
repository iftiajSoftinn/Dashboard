using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Controllers
{
    public class DashboardController : Controller
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
                NoOfRes = 2,
                Date = new DateTime(2023, 3, 2), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 3,
                Date = new DateTime(2023, 3, 3), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 4,
                Date = new DateTime(2023, 3, 4), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 5,
                Date = new DateTime(2023, 3, 5), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 6,
                Date = new DateTime(2023, 3, 6), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 7,
                Date = new DateTime(2023, 3, 7), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 8,
                Date = new DateTime(2023, 3, 8), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 9,
                Date = new DateTime(2023, 3, 9), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 10,
                Date = new DateTime(2023, 3, 10), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 11,
                Date = new DateTime(2023, 3, 11), // year, month, day
                Payment = 150
            },
            new ReservationModel
            {
                NoOfRes = 12,
                Date = new DateTime(2023, 3, 12), // year, month, day
                Payment = 80
            },
            new ReservationModel
            {
                NoOfRes = 13,
                Date = new DateTime(2023, 3, 13), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 14,
                Date = new DateTime(2023, 3, 14), // year, month, day
                Payment = 110
            },
            new ReservationModel
            {
                NoOfRes = 15,
                Date = new DateTime(2023, 3, 15), // year, month, day
                Payment = 150
            },
            new ReservationModel
            {
                NoOfRes = 16,
                Date = new DateTime(2023, 3, 16), // year, month, day
                Payment = 140
            },
            new ReservationModel
            {
                NoOfRes = 17,
                Date = new DateTime(2023, 3, 17), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 18,
                Date = new DateTime(2023, 3, 18), // year, month, day
                Payment = 150
            },
            new ReservationModel
            {
                NoOfRes = 19,
                Date = new DateTime(2023, 3, 19), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 20,
                Date = new DateTime(2023, 3, 20), // year, month, day
                Payment = 90
            },
                        new ReservationModel
            {
                NoOfRes = 21,
                Date = new DateTime(2023, 3, 21), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 22,
                Date = new DateTime(2023, 3, 22), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 3,
                Date = new DateTime(2023, 3, 23), // year, month, day
                Payment = 140
            },
            new ReservationModel
            {
                NoOfRes = 4,
                Date = new DateTime(2023, 3, 24), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 5,
                Date = new DateTime(2023, 3, 25), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 6,
                Date = new DateTime(2023, 3, 26), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 7,
                Date = new DateTime(2023, 3, 27), // year, month, day
                Payment = 120
            },
            new ReservationModel
            {
                NoOfRes = 8,
                Date = new DateTime(2023, 3, 28), // year, month, day
                Payment = 90
            },
            new ReservationModel
            {
                NoOfRes = 9,
                Date = new DateTime(2023, 3, 29), // year, month, day
                Payment = 100
            },
            new ReservationModel
            {
                NoOfRes = 10,
                Date = new DateTime(2023, 3, 30), // year, month, day
                Payment = 90
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ReservationDetails(DateTime? selectedDate)
        {
            DateTime date = selectedDate ?? DateTime.Today;

            List<ReservationModel> pastReservations = reservations.Where(r => r.Date >= date.AddDays(-7) && r.Date < date).ToList();
            List<ReservationModel> upcomingReservations = reservations.Where(r => r.Date >= date && r.Date < date.AddDays(7)).ToList();

            int totalPastNoOfRes = pastReservations.Sum(r => r.NoOfRes);
            decimal totalPastPayment = pastReservations.Sum(r => r.Payment);
            int totalUpcomingNoOfRes = upcomingReservations.Sum(r => r.NoOfRes);
            decimal totalUpcomingPayment = upcomingReservations.Sum(r => r.Payment);
            decimal totalRevenuePastSevenDays = totalPastPayment * 0.4m;

            ReservationDetailsViewModel model = new ReservationDetailsViewModel(pastReservations, upcomingReservations, date);

            return View(model);
        }
    }
}
