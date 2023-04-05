using System.ComponentModel.DataAnnotations;

namespace Calendar.Models
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        //Relational data
        public virtual ICollection<Event> Events { get; set; }

    }
}
