using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Constants
{
    public class DataConstants
    {
        public class Cafe
        {
            public const int COFE_NAME_MAX_LENGTH = 50;
            public const int OWNER_FIRST_NAME_MAX_LENGTH = 30;
            public const int OWNER_SECOND_NAME_MAX_LENGTH = 50;
            public const int OWNER_LAST_NAME_MAX_LENGTH = 40;
        }
        public class Drink 
        {
            public const int DRINK_NAME_MAX_LENGTH = 50;
            public const int DRINK_DESCRIPTION_MAX_LENGTH = 300;
        }
        public class Food
        {
            public const int FOOD_NAME_MAX_LENGTH = 50;
            public const int FOOD_DESCRIPTION_MAX_LENGTH = 400;
        }
        public class DrinkType
        {
            public const int DRINK_TYPE_NAME_MAX_LENGTH = 50;
        }
        public class FoodType
        {
            public const int FOOD_TYPE_NAME_MAX_LENGTH = 50;
        }
        public class Supplements
        {
            public const int SUPPELEMENT_NAME_MAX_LENGTH = 50;
        }
        public class Table
        {
            public const int TABLE_DESCRIPTION_MAX_LENGTH = 50;
        }
        public class User
        {
            public const int USER_FIRST_NAME_MAX_LENGTH = 40;
            public const int USER_SECOND_NAME_MAX_LENGTH = 40;
            public const int USER_LAST_NAME_MAX_LENGTH = 40;
        }



    }
}
