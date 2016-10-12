using System.ComponentModel.DataAnnotations;


namespace CityExplorer.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
