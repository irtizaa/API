using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Dto
{
    public class PersonDto
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int number { get; set; }

    }
}
