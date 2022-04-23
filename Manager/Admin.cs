using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IAdminManager
    {
        IEnumerable<Admin> admin { get; }
        IEnumerable<Admin> GetAdminByName(string name);
        void AddAdmin(Admin admin);
    }

    public class AdminManager : IAdminManager
    {
        public AdminManager()
        {
        }
        public IEnumerable<Admin> admin => AdminList.admin;
        public void AddAdmin(Admin admin)
        {
            AdminList.admin.Add(admin);
        }
        public IEnumerable<Admin> GetAdminByName(string name)
        {
            return AdminList.admin.Where(adm => adm.Name.ToLower() ==
           name.ToLower());
        }
    }
    public static class AdminList
    {
        public static List<Admin> admin = new List<Admin>()
        {
         new Admin("Эльф", "чай", "адрес фотки"),
         new Admin("Рогро", "Ролевки", "адрес фотки"),
         new Admin("Дима", "Игротека", "адрес фотки"),
         new Admin("Макс", "Мафия", "адрес фотки")};
        }
    } 
   

