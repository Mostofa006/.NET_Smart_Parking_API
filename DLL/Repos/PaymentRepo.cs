using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using DAL.Models;


namespace DAL.Repos
{
    internal class PaymentRepo : Repo, IRepo<Payment, int, Payment>
    {
        public Payment Create(Payment obj)
        {
            db.Payment.Add(obj);        // Add
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = db.Payment.Find();  // Find by PK
            if (existing == null) return false;

            db.Payment.Remove(existing);          // Remove
            return db.SaveChanges() > 0;
        }

        public List<Payment> Read()
        {
            return db.Payment.ToList();          // ToList
        }

        public Payment Read(int id)
        {
            return db.Payment.Find(id);           // Find by PK
        }

        public Payment Update(Payment obj)
        {
            var existing = db.Payment.Find(obj.ReservationId); // Find PK
            if (existing == null) return null;

            db.Entry(existing).CurrentValues.SetValues(obj);   // Update
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
