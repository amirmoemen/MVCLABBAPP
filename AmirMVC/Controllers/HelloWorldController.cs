﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;



namespace AmirMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, IDs: {ID}");
        }
    }
}