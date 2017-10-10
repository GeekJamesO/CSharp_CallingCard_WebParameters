using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallingCard.Controllers
{
// Calling Card
// Its about time we put some of this new knowledge to use. We have learned about creating a ASP.NET Core app, 
// using MVC, and simple aspects of returning JSON. Before we move into views we will practice routing, route 
// parameters and JSON responses with a quick assignment.

// Create a simple app that reads in parameters from a single GET route and renders the values with a JSON response. 
//Your route should accept four parameters:
    // First Name
    // Last Name
    // Age
    // Favorite Color
// A user using your app would expect to enter a route such as http://localhost/Tim/Toolmam/42/Brown to which you 
//should display the appropriate information as a JSON response.

    public class RtnJson : object 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FavoriteColor { get; set; }
        public RtnJson(string FirstName, string LastName, int Age, string FavoriteColor)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.FavoriteColor = FavoriteColor;
        }
    }
    public class CallingCardController : Controller 
    {
        [HttpGetAttribute]
        [Route("Index/{FirstName}/{LastName}/{Age}/{FavoriteColor}")]
        public JsonResult Index( string FirstName, string LastName, int Age, string FavoriteColor) 
        {
            return Json(new RtnJson(FirstName, LastName, Age, FavoriteColor));
        }
    }
}