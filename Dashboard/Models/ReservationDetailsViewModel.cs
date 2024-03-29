﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Models
{
    public class ReservationDetailsViewModel


    {
        public ReservationDetailsViewModel(List<ReservationModel> pastReservations, List<ReservationModel> upcomingReservations, DateTime date)
        {
            PastReservations = pastReservations;
            UpcomingReservations = upcomingReservations;
            Date = date;

            TotalPastNoOfRes = pastReservations.Sum(r => r.NoOfRes);
            TotalPastPayment = pastReservations.Sum(r => r.Payment);

            TotalUpcomingNoOfRes = upcomingReservations.Sum(r => r.NoOfRes);
            TotalUpcomingPayment = upcomingReservations.Sum(r => r.Payment);

            TotalRevenuePastSevenDays = TotalPastPayment * 0.2m;

        }

        public DateTime Date { get; set; }
        public int TotalPastNoOfRes { get; set; }
        public decimal TotalPastPayment { get; set; }
        public List<ReservationModel> PastReservations { get; set; }
        public int TotalUpcomingNoOfRes { get; set; }
        public decimal TotalUpcomingPayment { get; set; }
        public decimal TotalRevenuePastSevenDays { get; set; }

        public List<ReservationModel> UpcomingReservations { get; set; }
    }

}
