using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class ReservationDetailsViewController : Controller
    {
        public ActionResult ReservationDetails(DateTime selectedDate)
        {
            var reservationDetails = new ReservationDetailsViewModel();

            // populate the UpcomingReservations and PastReservations lists based on selectedDate
            reservationDetails.UpcomingReservations = Reservations
                .Where(r => r.Date > selectedDate && r.Date <= selectedDate.AddDays(7))
                .ToList();
            reservationDetails.PastReservations = Reservations
                .Where(r => r.Date >= selectedDate.AddDays(-7) && r.Date < selectedDate)
                .ToList();

            // calculate the TotalPastAmount based on the PastReservations list
            reservationDetails.TotalPastAmount = reservationDetails.PastReservations.Sum(r => r.Payment);

            // set the SelectedDate property of the view model
            reservationDetails.SelectedDate = selectedDate;

            // return the view with the view model
            return View(reservationDetails);
        }

    }
}
