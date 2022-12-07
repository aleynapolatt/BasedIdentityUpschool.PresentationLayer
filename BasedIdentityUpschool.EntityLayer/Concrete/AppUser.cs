using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedIdentityUpschool.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        // <int> dedik demezsek eğer id string olur

        public string Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
    }
}
