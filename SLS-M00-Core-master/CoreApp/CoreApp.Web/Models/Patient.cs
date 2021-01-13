using System;
using System.ComponentModel.DataAnnotations;


namespace CoreApp.Web.Models
{
    public class Patient
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string age { get; set; }
        public string gender { get; set; }


    }
}
