using ElegantSource.Data.Context;
using ElegantSource.Data.Repositories;
using ElegantSource.Entity.Entities;
using System.Web.Mvc;

namespace ElegantSource.Controllers.Sourcing
{
    public class RfxController:Controller
    {
        public ViewResult Index()
        {
            var context = new DataContext();
            var rfxRepository = new RepositoryService<Rfx>(context);
            var result = rfxRepository.GetById(1);
            result.Name = "Books";
            rfxRepository.Update(result);
            return View(rfxRepository.GetAll());
        }
    }
}
