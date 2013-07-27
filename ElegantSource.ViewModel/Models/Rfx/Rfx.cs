using System;

namespace ElegantSource.ViewModels
{
    public class Rfx
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public bool AllowComment{ get; set; }
        public DateTime ResponseDeadline{ get; set; }
    }
}