using DataAccessLayer.EF.Models.Common.Conversations;
using DataAccessLayer.Interface;
using DataAccessLayer.Interface.Common.Conversation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.CommonRepos.ConversationRepos
{
    internal class ConversationRepo : Repo, IRepo<Conversation, int, Conversation>, IConversation<Conversation>
    {
        public List<Conversation> showAllConversationToCurrentLoggedInUser(int currentLoggedInUserEmail)
        {
            throw new NotImplementedException();
        }

        public Conversation Create(Conversation obj)
        {
            db.Conversations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Conversations.Remove(existing);
            return db.SaveChanges() > 0;
        }

        public List<Conversation> Get()
        {
            return db.Conversations.ToList();
        }

        public Conversation Get(int id)
        {
            return db.Conversations.Find(id);
        }

        

        public Conversation Update(Conversation obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
