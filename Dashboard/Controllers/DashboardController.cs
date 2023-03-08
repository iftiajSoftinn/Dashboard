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

            ReservationDetailsViewModel model = new ReservationDetailsViewModel(pastReservations, upcomingReservations, date);

            return View(model);
        }
    }
}
