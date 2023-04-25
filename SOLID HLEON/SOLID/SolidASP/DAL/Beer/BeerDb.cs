using SolidASP.Models.ViewModels;

namespace SolidASP.DAL.Beer
{
    public class BeerDb
    {
        public void Save(BeerVModel beer)
        {
            Console.WriteLine("Guardar en DB" + beer.Name);
        }
    }
}
