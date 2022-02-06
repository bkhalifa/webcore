using Microsoft.EntityFrameworkCore;

using OdeToFood.Core;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
        Restaurant GetRestaurantById(int Id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Delete(int id);
        Restaurant Create(Restaurant restaurant);

        int GetCountOfRestaurants();
        int Commit();
    }

    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;
        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
          return   db.SaveChanges();
        }

        public Restaurant Create(Restaurant restaurant)
        {
            db.Add(restaurant);
            return restaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetRestaurantById(id);
            if(restaurant != null)
            {
                db.Restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public int GetCountOfRestaurants()
        {
            return  db.Restaurants.Count();
        }

        public Restaurant GetRestaurantById(int Id)
        {
            return db.Restaurants.Find(Id);
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name)
        {
            return from r in db.Restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {

            var entity = db.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }


}
