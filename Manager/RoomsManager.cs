using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IRoomsManager
    {
        IEnumerable<Rooms> rooms { get; }
        IEnumerable<Rooms> GetRoomsByName(string name);
    }
    public class RoomsManager : IRoomsManager
    {
        public IEnumerable<Rooms> rooms => RoomsList.rooms;

        public IEnumerable<Rooms> GetRoomsByName(string name)
        {
            return RoomsList.rooms.Where(room => room.Name.ToLower() == name.ToLower());
        }
        public static class RoomsList
        {
          public static List<Rooms> rooms = new List<Rooms>()
          {
           new Rooms("Шелдон", "link to photo", "чай", "будни: 1000/час\nвыходные: 1300/час","link to DataBase"),
           new Rooms("AdvencherTime", "link to photo", "детективки", "будни: 1300/час\nвыходные: 1600/час","link to DataBase"),
           new Rooms("Татуин", "link to photo", "мафия", "будни: 1600/час\nвыходные: 1900/час","link to DataBase"),
           new Rooms("Алиса", "link to photo", "шляпа", "будни: 600/час\nвыходные: 800/час","link to DataBase"),
           new Rooms("Тардис", "link to photo", "ничего :(", " + 300 рублей к чеку","link to DataBase"),
           new Rooms("Комиксная", "link to photo", "ничего :(", " + 200 рублей к чеку","link to DataBase"),
           new Rooms("VR-комната", "link to photo", "ничего :(", "150рублей/10 минут, 300рублей/30 минут","link to DataBase"),
          };
        }
    }
}
