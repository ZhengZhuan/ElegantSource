using ElegantSource.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ElegantSource.ViewModels
{ 
    public class RfxRepository : IRfxRepository
    {
        ElegantSourceMVCContext context = new ElegantSourceMVCContext();

        public IQueryable<Rfx> All
        {
            get { return context.Rfxes; }
        }

        public IQueryable<Rfx> AllIncluding(params Expression<Func<Rfx, object>>[] includeProperties)
        {
            IQueryable<Rfx> query = context.Rfxes;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Rfx Find(int id)
        {
            return context.Rfxes.Find(id);
        }

        public void InsertOrUpdate(Rfx rfx)
        {
            if (rfx.Id == default(int)) {
                // New entity
                context.Rfxes.Add(rfx);
            } else {
                // Existing entity
                context.Entry(rfx).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var rfx = context.Rfxes.Find(id);
            context.Rfxes.Remove(rfx);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface IRfxRepository : IDisposable
    {
        IQueryable<Rfx> All { get; }
        IQueryable<Rfx> AllIncluding(params Expression<Func<Rfx, object>>[] includeProperties);
        Rfx Find(int id);
        void InsertOrUpdate(Rfx rfx);
        void Delete(int id);
        void Save();
    }
}