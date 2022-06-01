using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
        public interface IComicsManager
        {
            IEnumerable<Comic> сomics { get; }
            IEnumerable<Comic> GetComicsByName(string name);
            void AddComics(Comic comics);
        }

    public class ComicsManager : IComicsManager
    {
            public IEnumerable<Comic> сomics => ComicsList.сomics;
            public void AddComics(Comic сomics)
            {
                ComicsList.сomics.Add(сomics);
            }
            public IEnumerable<Comic> GetComicsByName(string name)
            {
                return ComicsList.сomics.Where(com => com.Name.ToLower() ==
               name.ToLower());
            }
        }
        public static class ComicsList
    {
        public static List<Comic> сomics = new List<Comic>()
        {
         new Comic("Шерлок", "детектив", "комиксная"),
         new Comic("Свинка По", "детское", "шелдон"),
        };
    }
}
