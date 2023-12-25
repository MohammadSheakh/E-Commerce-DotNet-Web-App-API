using DataAccessLayer.EF.Models.Common.Conversations;
using DataAccessLayer.Interface;
using DataAccessLayer.Interface.Common.Conversation;
using DataAccessLayer.Repos.UserRepo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            // var createdMessage = null;
            
            // Destructing done .. 
            var receiverEmail = obj.ReceiverEmail;
            var message = obj.MessageDetails;
            var senderEmail = obj.SenderEmail;


            // Create a new Message object
            var newMessage = new Message
            {
                Id = Convert.ToInt32(Guid.NewGuid()), // Using ticks as a unique identifier
                SenderEmail = senderEmail,
                ReceiverEmail = receiverEmail,
                MessageDetails = message,
                // Other properties if needed
            };

            // check conversation already exist or not 

            var participant_email1 = senderEmail + '-' + receiverEmail;
            var participant_email2 = receiverEmail + '-' + senderEmail;

            // already kono conversation exist kore kina .. sheta check korte hobe 

            // var conversations = db.Conversations.Where(conversaiton => conversaiton.ParticipantsEmail == participant_email1 || conversation.ParticipantsEmail == participant_email2);

            var foundConversation = db.Conversations.Where(conversation => conversation.ParticipantsEmail.Contains(participant_email1) || conversation.ParticipantsEmail.Contains(participant_email2))
            .FirstOrDefault();
            
            if(foundConversation != null)
            {
                //   ============== previous conversation found
                var conversaionId = foundConversation.Id;

                // conversaion exist
                var newMessageWithConversationId = new Message
                {
                    Id = Convert.ToInt32(Guid.NewGuid()), // Using ticks as a unique identifier
                    SenderEmail = senderEmail,
                    ReceiverEmail = receiverEmail,
                    MessageDetails = message,
                    ConversationId = conversaionId,
                };

                foundConversation.LastMessage = message;

                var conversationRepo = new ConversationRepo();
                conversationRepo.Update(foundConversation);


                db.Messages.Add(newMessageWithConversationId);

                return newMessageWithConversationId;
            }
            else
            {
                // console.log(" ============== conversation does not exist============ >> conversation is null" , conversation);
                // conversation does not exist 
                // create a conversation with participant_email and timeStamps

                //🟢check korte hobe sender and receiver email user database e ase kina
                // thaklei conversation create korbo 

                var userRepo = new UserRepo.UserRepo();

                var user = userRepo.getUserByEmail(senderEmail, receiverEmail);


                if(user != null)
                {
                    // sender and receiver user DB te ase .. 
                    // conversation create korbo 
                    var newConversation = new Conversation
                    {
                        ParticipantsEmail = participant_email1,
                        LastMessage = message,
                        CreatedAt = DateTime.Now,
                    };

                    // new conversation creation done 
                    var conversationRepo = new ConversationRepo();
                    var createdConversaiton = conversationRepo.Create(newConversation);

                    var createdConversaitonId = createdConversaiton.Id;

                    var messageRepo = new MessageRepo();
                    var newMessageWithConversationId = new Message
                    {
                        Id = Convert.ToInt32(Guid.NewGuid()), // Using ticks as a unique identifier
                        SenderEmail = senderEmail,
                        ReceiverEmail = receiverEmail,
                        MessageDetails = message,
                        ConversationId = createdConversaitonId,
                    };
                    var createdMessage =  messageRepo.Create(newMessageWithConversationId);

                    return createdMessage;

                }

            }

            return null;
            //db.Messages.Add(obj);
            //if (db.SaveChanges() > 0) return obj;
            
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
