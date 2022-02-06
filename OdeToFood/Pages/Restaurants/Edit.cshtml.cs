

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using OdeToFood.Core;
using OdeToFood.Data;

using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        [BindProperty]
        public Restaurant restaurant { get; set; }


        public  IRestaurantData restaurantData { get; set; }
        public IHtmlHelper htmlHelper { get; set; }
        public EditModel(IRestaurantData restaurantData, 
                         IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }
     
        
        
        
        public IActionResult OnGet(int? id)
        {
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            if(id.HasValue)
            {
                restaurant = restaurantData.GetRestaurantById(id.Value);
                if (restaurant == null)
                {
                    return RedirectToPage("./NotFound");
                }
            }
            else
            {
                restaurant = new Restaurant();
            }

           
            return Page();
        }

        public IActionResult OnPost()
        {
            if(restaurant.Id > 0)
            {
                restaurantData.Update(restaurant);
            }
            else
            {
                restaurantData.Create(restaurant);
            }
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            restaurantData.Commit();
         
            TempData["Message"] = "Restaurant saved  !";
            return RedirectToPage("./Details", new { id = restaurant.Id }) ;

        }


    }
}
