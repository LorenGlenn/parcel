using System.Collections.Generic;
using Nancy;
using Boxes.Objects;
using System;

namespace Boxes
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["input_Parcel.cshtml"];
      Post["/confirmation"] = _ => {
        int weight = 0;
        int height = 0;
        int width = 0;
        int length = 0;
        weight = Request.Form["weight"];
        height = Request.Form["height"];
        width = Request.Form["width"];
        length = Request.Form["length"];
        if (weight <= 0 || height <= 0 || width <= 0 || length <=0)
        {
          //Console.WriteLine("Please enter a number in all fields");
          return View["error.cshtml"];
        }
        Parcel newParcel = new Parcel (weight, height, width, length);
        return View["confirmation.cshtml", newParcel];
      };
    }
  }
}
