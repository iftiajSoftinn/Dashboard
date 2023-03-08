namespace Dashboard.Models
{
    public class ReservationDetailsViewModel
    {
        public ReservationDetailsViewModel()
        {
            UpcomingReservations = new List<ReservationModel>();
            PastReservations = new List<ReservationModel>();
        }

        public List<ReservationModel> UpcomingReservations { get; set; }
        public List<ReservationModel> PastReservations { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPastAmount { get; set; }
        public DateTime SelectedDate { get; set; }
    }


}
