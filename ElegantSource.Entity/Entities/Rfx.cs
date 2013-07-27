using System;

namespace ElegantSource.Entity.Entities
{
    public class Rfx : BaseEntity<int>
    {
        public string Name { get; set; }
        public bool AllowComment { get; set; }
        public DateTime ResponseDeadline{ get; set; }
    }
}
