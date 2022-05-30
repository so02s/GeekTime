using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
        public interface IComicsManager
        {
            IEnumerable<Comics> сomics { get; }
            IEnumerable<Comics> GetComicsByName(string name);
            void AddComics(Comics comics);
        }

    public class ComicsManager : IComicsManager
    {
            public IEnumerable<Comics> сomics => ComicsList.сomics;
            public void AddComics(Comics сomics)
            {
                ComicsList.сomics.Add(сomics);
            }
            public IEnumerable<Comics> GetComicsByName(string name)
            {
                return ComicsList.сomics.Where(com => com.Name.ToLower() ==
               name.ToLower());
            }
        }
        public static class ComicsList
    {
        public static List<Comics> сomics = new List<Comics>()
        {
         new Comics("Шерлок", "детектив", "комиксная"),
         new Comics("Свинка По", "детское", "шелдон"),
        };
    }
}
