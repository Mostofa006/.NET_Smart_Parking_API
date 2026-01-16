using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ReservationRepo : Repo, IRepo<Reservation, string, Reservation>
    {
        public Reservation Create(Reservation obj)
        {
            db.Reservations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            if (ex == null) return false;

            db.Reservations.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Reservation> Read(int id)
        {
            return db.Reservations.ToList();
        }

        public Reservation Read(string id)
        {
            return db.Reservations.Find(id);
        }

        public List<Reservation> Read()
        {
            throw new NotImplementedException();
        }

        public Reservation Update(Reservation obj)
        {
            var ex = Read(obj.Id);
            if (ex == null) return null;

            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
