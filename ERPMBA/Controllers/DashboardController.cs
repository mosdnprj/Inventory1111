using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using System.Web.Helpers;
using System.Drawing;
using System.IO;

namespace ERPMBA.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashbord/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexResult()
        {
            return  PartialView("IndexResult");

        }

        public ActionResult mychartoutput()
        {
        var myChart = new Chart(width: 250, height: 300, theme:ChartTheme.Green)
        .AddTitle("Sales Chart")
        .AddSeries(
            name: "ChartTitle",
            chartType: "Pie",
            xValue: new[] {  "Col1", "Col2", "Col3", "Col4", "Col5" },
            yValues: new[] { "2", "6", "4", "5", "3" })
        .Write("bmp");
        return null;
        }




        public ActionResult mychartoutput1()
        {

            var myChart = new Chart(width: 250, height: 300, theme: ChartTheme.Green)
           .AddTitle("Services Chart")
           .AddSeries(
               name: "ChartTitle",
               xValue: new[] { "Col1", "Col2", "Col3", "Col4", "Col5" },
               yValues: new[] { "2", "6", "4", "5", "3" })
           .Write("bmp");
            return null;

        
        
        }

    }

      
    }

