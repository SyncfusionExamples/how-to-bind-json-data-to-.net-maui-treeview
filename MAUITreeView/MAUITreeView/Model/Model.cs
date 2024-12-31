using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITreeView
{
    public class Cities
    {
        public string Name { get; set; }
    }
    public class States
    {
        public List<Cities> Cities { get; set; }
        public string Name { get; set; }
    }
    public class Countries
    {
        public List<States> States { get; set; }
        public string Name { get; set; }
    }
}
