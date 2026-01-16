using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;

namespace DAL
{
    public static class DataAccessFactory
    {
        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<ParkingSlot, string, ParkingSlot> ParkingSlotData()
        {
            return new ParkingSlotRepo();
        }
        public static IRepo<Reservation, string, Reservation> ReservationData()
        {
            return new ReservationRepo();
        }
        public static IRepo<Payment, int, Payment> GetPaymentData()
        {
            return new PaymentRepo();
        }

        public static object PaymentData()
        {
            throw new NotImplementedException();
        }
    }
}
