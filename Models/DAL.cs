using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratoire_1.Models
{
    public static class DAL
    {
        public static Nouvelle AddNouvelle (this NouvellesDbEntities DB, Nouvelle nouvelle)
        {
            nouvelle = DB.Nouvelles.Add(nouvelle);
            DB.SaveChanges();
            return nouvelle;
        }

        public static bool UpdateNouvelle (this NouvellesDbEntities DB, Nouvelle nouvelle) 
        {
            DB.Entry(nouvelle).State = EntityState.Modified;
            DB.SaveChanges();
            return true;
        }

        public static bool RemoveNouvelle (this NouvellesDbEntities DB, Nouvelle nouvelle)
        {
            Nouvelle toDelete = DB.Nouvelles.Find(nouvelle.Id);
            DB.Nouvelles.Remove(toDelete);
            DB.SaveChanges();
            return true;
        }
    }
}