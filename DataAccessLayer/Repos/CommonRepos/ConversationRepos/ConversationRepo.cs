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
        public List<Conversation> showAllConversationToCurrentLoggedInUser(string currentLoggedInUserEmail)
        {
            // 1. current logged in user conversation er participantEmail er moddhe ase kina check korbo
            //    shei conversation gula niye ashbo 
            var conversations = db.Conversations.Where(p => p.ParticipantsEmail.Contains(currentLoggedInUserEmail)).ToList();

            // string[] participantsEmail = { };
            //return conversations;
            //foreach (var conversation in conversations)
            //{
            //    participantsEmail.
            //}
            //string[] participantsEmail = conversations.Select(conversation => conversation.ParticipantsEmail).ToArray();

            List<string> participantsEmail = conversations.Select(conversation => conversation.ParticipantsEmail).ToList();

            //List<string> filteredParticipantsEmail1 = participantsEmail.Select(participantEmail => participantsEmail.Replace())
            List<string> filteredParticipantsEmail1 = participantsEmail
                .Select(participantEmail => participantEmail.Replace(currentLoggedInUserEmail + "-", ""))
                .ToList();

            List<string> filteredParticipantsEmail2 = filteredParticipantsEmail1
                .Select(participantEmail => participantEmail.Replace(currentLoggedInUserEmail + "-", ""))
                .ToList();

            // List<string> users;
            //foreach (var participantEmail in filteredParticipantsEmail2)
            //{
                
            //   var data =  db.Users.Where(p => p.Email == participantEmail);
            //    if(data != null)
            //    {
            //        users.Add(data);
            //    }
            //}

            var usersWithMatchingEmails = db.Users.Where(user => filteredParticipantsEmail2.Contains(user.Email)).ToList();

            // conversations er last
            return conversations; // 🏠 aro kaj kora baki ....................

        }

        public Conversation Create(Conversation obj)
        {
            obj.CreatedAt = DateTime.Now;

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
