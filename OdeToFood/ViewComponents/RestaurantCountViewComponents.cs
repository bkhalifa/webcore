using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;


namespace OdeToFood.Pages
{
    [ViewComponent(Name = "RestaurantCount")]
    public class RestaurantCountViewComponents: ViewComponent
    {
        private IRestaurantData restaurantData;
        public RestaurantCountViewComponents(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }


        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCountOfRestaurants();
            return View(count);
        }
    }
}
