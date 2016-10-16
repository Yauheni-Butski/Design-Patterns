using System;

using Composite.Repository;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityRepository = new CityMapComponentRepository();
            var city = cityRepository.GetCity();
            city.Show();

            var cityComponent = city.FindChildByName("Ghostbusters");
            Console.WriteLine("Search result :");
            if (cityComponent == null)
            {
                Console.WriteLine("Not found any elements");
            }
            else
            {
                cityComponent.Show();
            }
        }
    }
}
