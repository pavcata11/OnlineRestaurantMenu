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
            public const int COFE_NAME_MIN_LENGTH = 5;
            public const int OWNER_FIRST_NAME_MAX_LENGTH = 30;
            public const int OWNER_FIRST_NAME_MIN_LENGTH = 5;
            public const int OWNER_SECOND_NAME_MAX_LENGTH = 50;
            public const int OWNER_SECOND_NAME_MIN_LENGTH = 5;
            public const int OWNER_LAST_NAME_MAX_LENGTH = 40;
            public const int OWNER_LAST_NAME_MIN_LENGTH = 5;
        }
        public class Drink 
        {
            public const int DRINK_NAME_MAX_LENGTH = 50;
            public const int DRINK_NAME_MIN_LENGTH = 5;
            public const int DRINK_DESCRIPTION_MAX_LENGTH = 300;
            public const int DRINK_DESCRIPTION_MIN_LENGTH = 20;
            public const double DRINK_PRICE_MIN = 0.10;
            public const double DRINK_PRICE_MAX = 99.99;
            public const double DRINK_CALORIES_MAX = 1200;
            public const double DRINK_CALORIES_MIN = 20;
            public const int DRINK_IMAGE_MIN_LENGTH = 5;
            public const int DRINK_IMAGE_MAX_LENGTH = 100;
            public const double DRINK_SIZE_MIN = 50;
            public const double DRINK_SIZE_MAX = 3000;
        }

        public class Food
        {
            public const int FOOD_NAME_MAX_LENGTH = 50;
            public const int FOOD_NAME_MIN_LENGTH = 5;
            public const int FOOD_DESCRIPTION_MAX_LENGTH = 300;
            public const int FOOD_DESCRIPTION_MIN_LENGTH = 20;
            public const int FOOD_IMAGE_MIN_LENGTH = 5;
            public const int FOOD_IMAGE_MAX_LENGTH = 100;
            public const double FOOD_SIZE_MIN = 50;
            public const double FOOD_SIZE_MAX = 3000;
            public const double FOOD_COOKING_TIME_MAX = 3000;
            public const double FOOD_COOKING_TIME_MIN = 5;
            public const decimal FOOD_PRICE_MIN = 0.10m;
            public const decimal FOOD_PRICE_MAX = 99.99m;
            public const double FOOD_CALORIES_MAX = 1200;
            public const double FOOD_CALORIES_MIN = 20;
        }
        public class DrinkType
        {
            public const int DRINK_TYPE_NAME_MAX_LENGTH = 50;
            public const int DRINK_TYPE_NAME_MIN_LENGTH = 5;
            public const int DRINK_TYPE_IMAGE_MIN_LENGTH = 5;
            public const int DRINK_TYPE_IMAGE_MAX_LENGTH = 100;

        }
        public class FoodType
        {
            public const int FOOD_TYPE_NAME_MAX_LENGTH = 50;
            public const int FOOD_TYPE_NAME_MIN_LENGTH = 50;
            public const int FOOD_TYPE_IMAGE_MAX_LENGTH = 300;
            public const int FOOD_TYPE_IMAGE_MIN_LENGTH = 100;
        }
        public class Supplements
        {
            public const int SUPPELEMENT_NAME_MAX_LENGTH = 50;
            public const int SUPPELEMENT_NAME_MIN_LENGTH = 5;
            public const decimal SUPPELEMENT_PRICE_MAX = 5;
            public const decimal SUPPELEMENT_PRICE_MIN = 0.10m;
        }
        public class Table
        {
            public const int TABLE_DESCRIPTION_MAX_LENGTH = 50;
            public const int TABLE_DESCRIPTION_MIN_LENGTH = 5;
            public const int TABLE_COUNTOFSEATS_MIN_LENGTH = 1;
            public const int TABLE_COUNTOFSEATS_MAX_LENGTH = 10;
            public const int TABLE_NUMBERTABLE_MIN_LENGTH = 1;
            public const int TABLE_NUMBERTABLE_MAX_LENGTH = 10;
        }
        public class User
        {
            public const int USER_FIRST_NAME_MAX_LENGTH = 40;
            public const int USER_FIRST_NAME_MIN_LENGTH = 4;
            public const int USER_SECOND_NAME_MAX_LENGTH = 40;
            public const int USER_SECOND_NAME_MIN_LENGTH = 4;
            public const int USER_LAST_NAME_MAX_LENGTH = 40;
            public const int USER_LAST_NAME_MIN_LENGTH = 4;
            public const int UserUsernameMinLength = 5;
            public const int UserUsernameMaxLength = 50;
            public const int UserEmailMinLength = 10;
            public const int UserEmailMaxLength = 60;
            public const int UserPasswordMinLength = 5;
            public const int UserPasswordMaxLength = 20;
            public const int USER_AGE_MIN = 1;
            public const int USER_AGE_MAX = 90;
        }
       

    }
}
