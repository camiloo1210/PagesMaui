﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PagesMaui.Models
{
    public class Estudiante
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public List<string> courses { get; set; }
        public double gpa { get; set; }
        public string image { get; set; }

    }

    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string country { get; set; }


    }
}
