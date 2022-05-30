using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace GeekTime.Manager
{
    public interface IEventsManager
    {
        IEnumerable<Events> Event { get; }
        IEnumerable<Events> GetEventByName(string Name);
        void AddEvent(Events events);
    }
    public class EventsManager : IEventsManager
    {
        public EventsManager() { }

        public IEnumerable<Events> Event => EventsList.eventlist;
        public void AddEvent(Events events)
        {
            EventsList.eventlist.Add(events);
        }
        public IEnumerable<Events> GetEventByName(string Name)
        {
            return EventsList.eventlist.Where(ev => ev.Name.ToLower() ==
           Name.ToLower());
        }
    }
    public static class EventsList
    {
        public static List<Events> eventlist = new List<Events>()
        {
            new Events("Мафия", "link to image", "describtion", "link to admin"),
            new Events("Игротека", "link to image", "describtion", "link to admin"),
        };
    }
}
