using Restoran4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran4.ViewModels
{
    public class BTn
    {
        public Garson garson { get; set; }
        public List<Food> foods { get; set; }
        public BTn(Garson _garson, List<Food> _foods)
        {
            garson= _garson;
            foods= _foods;
        }
        public BTn() {
        
        }
    }
}
