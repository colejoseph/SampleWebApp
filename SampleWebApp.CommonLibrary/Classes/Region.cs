using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApp.CommonLibrary.Classes
{
    public class Region
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Territory> Territories { get; set; }
    }
}
