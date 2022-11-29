using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Enums
{
    public enum DrinkMainTypes
    {
        [Description("Топли напитки")] HotDrinks = 0,
        [Description("Безалкохолни напитки")] SoftDrinks = 1,
        [Description("Алкохолни напитки")] AlcoholicDrinks = 2,

    }
}
