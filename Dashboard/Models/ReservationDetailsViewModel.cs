namespace Dashboard.Models
{
    public class ReservationDetailsViewModel
    {
        public ReservationDetailsViewModel(List<ReservationModel> pastReservations, List<ReservationModel> upcomingReservations, DateTime date)
        {
            PastReservations = pastReservations;
            UpcomingReservations = upcomingReservations;
            Date = date;
        }

        public IEnumerable<ReservationModel> PastReservations { get; set; }
        public IEnumerable<ReservationModel> UpcomingReservations { get; set; }
        public DateTime SelectedDate { get; set; }
        public DateTime Date { get; set; }
    }
}
