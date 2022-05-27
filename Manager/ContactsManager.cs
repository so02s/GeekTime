using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IContactsManager
    {
        IEnumerable<Contacts> Person { get; }
        IEnumerable<Contacts> GetPersonByPost(string post);
        void AddPerson(Contacts person);
    }
    public class ContactsManager : IContactsManager
    {
        public ContactsManager() { }

        public IEnumerable<Contacts> Person => ContactsList.personcontacts;
        public void AddPerson(Contacts person)
        {
            ContactsList.personcontacts.Add(person);
        }
        public IEnumerable<Contacts> GetPersonByPost(string post)
        {
            return ContactsList.personcontacts.Where(pers => pers.Post.ToLower() ==
           post.ToLower());
        }
    }
    public static class ContactsList
    {
        public static List<Contacts> personcontacts = new List<Contacts>()
        {
             new Contacts("Саша", 8909123123, "sasha@yandex.ru", "основатель"),
             new Contacts("Люба", 8909123123, "luba@mail.ru", "сооснователь"),
        };
    }
}

