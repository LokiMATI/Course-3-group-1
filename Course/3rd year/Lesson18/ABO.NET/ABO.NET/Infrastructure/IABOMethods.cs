using Abo.Model;
using System.Collections.Generic;

namespace Abo.Infrastructure
{
    public interface IABOmethods
    {
        void Add(Contact contact);
        void Remove(string name);
        void Update(Contact contact);
        Contact Get(string name);
        List<Contact> GetAll();
    }
}