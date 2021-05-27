using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Rent
    {
        public int Id { get; set; }
        public int Duration { get; set; }

        
        public Reader Reader { get; set; }

        
        public Book Book { get; set; }
    }
}
