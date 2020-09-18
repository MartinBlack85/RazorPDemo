using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPDemoApp.Pages.Food
{
    public class ListModel : PageModel
    {
        private readonly IFoodData _foodData;

        //without the Bindproterty this property cannot be modified from the front-end/view
        public List<FoodModel> Food { get; set; }

        public ListModel(IFoodData foodData)
        {
            this._foodData = foodData;
        }


        public async Task OnGet()
        {
            Food = await _foodData.GetFood();
        }
    }
}
