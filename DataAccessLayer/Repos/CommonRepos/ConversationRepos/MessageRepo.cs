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
    internal class MessageRepo : Repo, IRepo<Message, int, Message>, IMessage<Message>
    {
        public List<Message> GetAllMessageByConversationId(int conversationId)
        {
            var products = db.Messages.Where(p => p.ConversationId == conversationId).ToList();
            return products;
        }

        public Message Create(Message obj)
        {
            db.Messages.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Messages.Remove(existing);
            return db.SaveChanges() > 0;
        }

        public List<Message> Get()
        {
            return db.Messages.ToList();
        }

        public Message Get(int id)
        {
            return db.Messages.Find(id);
        }

        

        public Message Update(Message obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
