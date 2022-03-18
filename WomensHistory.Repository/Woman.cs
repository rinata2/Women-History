using System;
using System.Collections.Generic;
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
        
        public Generation generation { get; set; }
        
        public bool Gloss { get; set; } 
    
    }   
    public History(string name, int age, Generation generation, bool gloss)
    {
        Name =Name;
        Age = age;
        Generation = generation;
        Gloss = gloss;
    }
    public enum Generation { Alpha, Baby_Boomer_I, Baby_Boomer_II, Greatest, Lost, Millenal, Silent, X, Z}
}


