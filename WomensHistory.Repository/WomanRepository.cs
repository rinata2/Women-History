using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomensHistory.Repository
{
    public class WomanRepository    
    {
        // FAKE DATABASE
        private List<Woman> _womanList = new List<Woman>();

        // CRUD

        // CREATE / READ / UPDATE / DELETE

        // CREATE
        public void AddWomanToList(Woman woman)
        {
            _womenList.Add(woman);
        }


        // READ
        public List<Woman> GetAllWomanFromList()
        {
            return _womanList;
        }

        public Woman GetWomanFromListByName(string userInputNameSearch)
        {
            foreach (Woman woman in _womanList)
            {
                if (woman.Name.ToUpper() == userInputNameSearch.ToUpper())
                {
                    return woman;
                }
            }

            return null;
        }

        // UPDATE
        public bool UpdateWoman(Woman woman)
        {
            foreach (Woman existingWoman in _womanList)
            {
                if (existingWoman.Title.ToUpper() == woman.Title.ToUpper())
                {
                    existingWoman.Name = woman.Name;
                    
                    existingWoman.Age = woman.Age;
                    
                    existingWoman.generation = woman.generation;

                    existingWoman.Gloss = woman.Gloss;

                    return true;
                }
            }

            return false;
        }

        public bool UpdateMovie(Woman woman, string title)
        {
            foreach (Woman existingWoman in _womanList)
            {
                if (existingWoman.Name.ToUpper() == woman.Name.ToUpper())
                {
                    existingWoman.Name = woman.Name;
                    existingWoman.Age = woman.Age
                    existingWoman.Generation = woman.Generation;
                    existingWoman.Gloss= woman.Gloss;
                    return true;
                }
            }

            return false;
        }



        // DELETE
        public bool DeleteWomanByName(string name)
        {
            foreach (Woman woman in _womanList)
            {
                if (woman.Title.ToUpper() == woman.ToUpper())
                {
                    _womanList.Remove(woman);
                    return true;
                }
            }

            return false;
        }

        // SEED DATA METHOD

        public void SeedWomanData()
        {
            Woman jillHeatherScott = new Woman("Jill Heather Scott", age, Generation.Millenal, 49, true);
);
            Woman kamalaDeviHarris = new Woman("Kamala Devi Harris", 54, Generation.Baby_Boomer_II, false);

            Woman mayaAngelou = new Woman("Maya Angelou", 86, Generation.Silent, false);
            
            Woman oprahGailWinfrey = new Woman("Oprah Gail Winfrey", 68, Generation.Baby_Boomer_I, Baby Boomer, true);
            
            Woman saraTreleavenBlakely  = new Woman("Sara Treleaven Blakely", 51, Generation.X, true);
            
            Generation[] generationArr =  { Alpha, Baby_Boomer_I, Baby_Boomer_II, Greatest, Lost, Millenal, Silent, X, Z};

            foreach (Woman woman in womanArr)
            {
                AddWWomanToList(woman);
            }
        }

    }
}