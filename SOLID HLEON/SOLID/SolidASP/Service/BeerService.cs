using SolidASP.DAL.Beer;
using SolidASP.Models.ViewModels;
using SolidASP.Tools;

namespace SolidASP.Service
{
    public class BeerService
    {
        private readonly BeerDb _beerDb;
        private readonly Log _log;

        public BeerService (BeerDb beerDb, Log log)
        {
            _beerDb = beerDb;
            _log = log;
        }

        public void Create (BeerVModel beer)
        {
            _beerDb.Save(beer);
            _log.Save("Guardado Correctament de Cerveza en Db, Cerveza: " + beer.Name);
        }
    }
}
