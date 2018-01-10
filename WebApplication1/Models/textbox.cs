using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class textbox
    {
        public DateTime startdate { get; set; }
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public List<textbox> listget { get; set; }
    }
}