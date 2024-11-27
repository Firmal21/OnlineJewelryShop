using Microsoft.AspNetCore.Mvc;

namespace OnlineJewelryShop.Controllers
{
    public class DateController : Controller
    {
        public string Index()
        {
            //    var todaysDate = new DateTime().Hour;
            //return todaysDate.ToString();
                //return todaysDate.ToString();  
                var datime = DateTime.Now.Hour;
            if (datime >= 0 && datime < 6)
                return "Доброй ночи";

            if (datime >= 6 && datime < 12)
                return "Доброе утро";

            if (datime >= 12 && datime < 18)
                return "Добрый день";

            if (datime >= 18 && datime < 0)
                return "Добрый вечер";

            return "некорректное время";
        }
    }
}
