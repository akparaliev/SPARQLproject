using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPARQLproject.Models
{
    public class BookModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsSelected { get; set; }

    }
}
