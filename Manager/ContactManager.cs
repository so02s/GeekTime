using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IContactManager
    {
        Task<IList<Contact>> GetAll();
        Task AddContact(string Name, long TelNumber, string Mail, string Post);
        Task DeleteContact(int id);
    }
    public class ContactManager : IContactManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public ContactManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddContact(string Name, long TelNumber, string Mail, string Post)
        {
            var contact = new Contact(Name, TelNumber, Mail, Post);
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteContact(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<Contact>> GetAll() => await _context.Contacts.ToListAsync();
    }
}

