using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class Pokemon
    {
        public List<string> types { get; set; }

        public double height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string imagen { get; set; }
        public double weight { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int specialAttack { get; set; }
        public int specialDefense { get; set; }
        public int speed { get; set; }
    }
}