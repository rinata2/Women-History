using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomensHistory.Repository
{
    public class Woman
    {
      //Class object of WomansHistory
        public string Name { get; set; }
        public int Age { get; set; }
        public enum Generation { get; set; }
        
        public bool Gloss { get; set; } 
    
    }   
    public enum History(string name, int age, enum generation, bool gloss)
    {
        Name =Name;
        Age = age;
        Generation = generation;
        Gloss = gloss;
    }
}


