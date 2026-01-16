using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ParkingSlotRepo : Repo, IRepo<ParkingSlot, string, ParkingSlot>
    {
        public ParkingSlot Create(ParkingSlot obj)
        {
            db.ParkingSlots.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            if (ex == null) return false;

            db.ParkingSlots.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ParkingSlot> Read(int id)
        {
            return db.ParkingSlots.ToList();
        }

        public ParkingSlot Read(string id)
        {
            return db.ParkingSlots.Find(id);
        }

        public List<ParkingSlot> Read()
        {
            throw new NotImplementedException();
        }

        public ParkingSlot Update(ParkingSlot obj)
        {
            var ex = Read(obj.Id);
            if (ex == null) return null;

            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
