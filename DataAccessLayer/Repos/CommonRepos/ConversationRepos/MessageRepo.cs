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
             var createdMessage = new Message{};
            
            // Destructing done .. 
            var receiverEmail = obj.ReceiverEmail;
            var message = obj.MessageDetails;
            var senderEmail = obj.SenderEmail;

            Guid newGuid = Guid.NewGuid();
            byte[] bytes = newGuid.ToByteArray();
            int newMessageId = Math.Abs(BitConverter.ToInt32(bytes, 0));


            // Convert.ToInt32(Guid.NewGuid())

            // Create a new Message object
            var newMessage = new Message
            {
                Id = newMessageId, // Using ticks as a unique identifier
                SenderEmail = senderEmail,
                ReceiverEmail = receiverEmail,
                MessageDetails = message,
                CreatedAt = DateTime.Now,
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

                Guid newGuid1 = Guid.NewGuid();
                byte[] bytes1 = newGuid1.ToByteArray();
                int newMessageId1 = BitConverter.ToInt32(bytes1, 0);

                // Convert.ToInt32(Guid.NewGuid())
                // conversaion exist
                var newMessageWithConversationId = new Message
                {
                    //Id = newMessageId1, // Using ticks as a unique identifier
                    SenderEmail = senderEmail,
                    ReceiverEmail = receiverEmail,
                    MessageDetails = message,
                    ConversationId = conversaionId,
                    CreatedAt = DateTime.Now,
                };

                foundConversation.LastMessage = message;

                var conversationRepo = new ConversationRepo();
                conversationRepo.Update(foundConversation);

                var result =  db.Messages.Add(newMessageWithConversationId);

                //return newMessageWithConversationId;

                if (db.SaveChanges() > 0) return newMessageWithConversationId;
                return null;
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


                if(user == false)
                {
                    // sender and receiver email User table  exist kore na 
                    // exception generate korte hobe .. 
                    // message send korte hobe front-end e .. ⚫⚫⚫⚫⚫⚫⚫⚫⚫⚫⚫⚫

                    var user1 = "user is not found .. false";

                }
                else
                {
                    // user jodi true hoy 

                    var user1 = "user is found true";

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

                    Guid newGuid1 = Guid.NewGuid();
                    byte[] bytes1 = newGuid.ToByteArray();
                    int newMessageId1 = Math.Abs(BitConverter.ToInt32(bytes1, 0));


                    var messageRepo = new MessageRepo();
                    var newMessageWithConversationId = new Message
                    {
                        //Id = newMessageId1, // Using ticks as a unique identifier
                        Id = newMessageId1,
                        SenderEmail = senderEmail,
                        ReceiverEmail = receiverEmail,
                        MessageDetails = message,
                        ConversationId = createdConversaitonId,
                        CreatedAt = DateTime.Now,
                    };

                    //createdMessage = this.Create(newMessageWithConversationId);
                    createdMessage =  db.Messages.Add(newMessageWithConversationId);

                    if (db.SaveChanges() > 0) return createdMessage;
                    return null;
                    //return createdMessage;

                }

            }

            return createdMessage;


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
