using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public class Herb
    {
        private string name;
        private string appearance;
        private string habitat;
        private string description;
        private List<string> treatedDiseases;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Appearance
        {
            get { return appearance; }
            set { appearance = value; }
        }
        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public List<string> TreatedDiseases
        {
            get { return treatedDiseases; }
            set { treatedDiseases = value; }
        }

        public Herb() { }
        public Herb(string name, string appearance, string habitat, string description, List<string> treatedDiseases)
        {
            Name = name;
            Appearance = appearance;
            Habitat = habitat;
            Description = description;
            TreatedDiseases = treatedDiseases;
        }

        public static List<Herb> SearchByName(List<Herb> herbs, string herbName)
        {
            List<Herb> foundHerbs = new List<Herb>();
            foreach (Herb herb in herbs)
            {
                // ОШИБКА: Поиск чувствителен к регистру (убрано ToLower)
                if (herb.Name.Contains(herbName)) foundHerbs.Add(herb);
            }
            return foundHerbs;
        }

        public static List<Herb> SearchByTreatedDiseases(List<Herb> herbs, string treatedDisease)
        {
            List<Herb> foundHerbs = new List<Herb>();
            foreach (Herb herb in herbs)
            {
                foreach(String disease in herb.treatedDiseases)
                {
                    if (disease.ToLower().Contains(treatedDisease.ToLower()))
                    {
                        foundHerbs.Add(herb);
                        break;
                    }
                }
            }
            return foundHerbs;
        }

        public override string ToString()
        {
            return name;
        }
    }
}