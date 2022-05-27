using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IRatesManager
    {
        IEnumerable<Rates> rates { get; }
    }
    public class RatesManager : IRatesManager
    {
            public RatesManager() { }
            public IEnumerable<Rates> rates => RatesList.rates;
    }
        public static class RatesList
        {
            public static List<Rates> rates = new List<Rates>()
            {
                 new Rates("Обычный на 10 часов", 550),
                 new Rates("Обычный на 24 часа", 950),
                 new Rates("Студенческий на 10 часов", 450),
                 new Rates("Студенческий на 24 часа", 800),
                 new Rates("Кворкинг на месяц", 4500),
                 new Rates("Круглосуточный на месяц", 5500),
            };
        }
}
