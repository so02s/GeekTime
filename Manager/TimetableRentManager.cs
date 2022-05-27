using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface ITimetableRentManager
    {
        IEnumerable<TimetableRent> Timetable { get; }
        IEnumerable<TimetableRent> GetTimetableByDate(string name);
        void AddTimetableRent(TimetableRent timetableRent);
    }
    public class TimetableRentManager : ITimetableRentManager
    {
        public IEnumerable<TimetableRent> Timetable => TimetableList.timetableList;
        public void AddTimetableRent(TimetableRent timetableRent)
        {
            TimetableList.timetableList.Add(timetableRent);
        }

        public IEnumerable<TimetableRent> GetTimetableByDate(string data)
        {
            return TimetableList.timetableList.Where(tt => tt.Data.ToLower() == data.ToLower());
        }
        public static class TimetableList
        {
            public static List<TimetableRent> timetableList = new List<TimetableRent>()
            {
             new TimetableRent(1530, "08.08.22", 1200),
             new TimetableRent(1600, "04.08.22", 1200),
             new TimetableRent(2100, "06.08.22", 600),
             new TimetableRent(1100, "02.08.22", 2000),
            };
        }
    }
}
