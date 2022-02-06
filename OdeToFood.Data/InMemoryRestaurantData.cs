using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant {Id=1, Name="Bilel Pizza",Location="MaryLand", Cuisine=CuisineType.Italian},
                new Restaurant {Id=2, Name="Mimi home",Location="New York", Cuisine=CuisineType.Indian},
                new Restaurant {Id=3, Name="La costa",Location="Rome", Cuisine=CuisineType.Mexican }
            };
        }

        public Restaurant GetRestaurantById(int Id)
        {
            return (from r in restaurants
                    where r.Id == Id
                    select r).FirstOrDefault(); 
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name = null)
        {
            return  from r in restaurants
                    where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                    orderby r.Name
                    select r;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant Create(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if(restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public int GetCountOfRestaurants()
        {
            return restaurants.Count() ;
        }
    }
}
