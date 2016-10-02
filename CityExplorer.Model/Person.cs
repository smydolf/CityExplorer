using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CityExplorer.Model
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
