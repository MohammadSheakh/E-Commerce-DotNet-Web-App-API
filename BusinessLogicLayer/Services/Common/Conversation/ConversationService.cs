using BusinessLogicLayer.DTOs.Conversation;
using BusinessLogicLayer.DTOs.Product;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer;
using E_Commerce_Web_Application.Helper.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EF.Models.Common.Conversations;
using BusinessLogicLayer.DTOs.Common.Conversation;

namespace BusinessLogicLayer.Services.Common.Conversation
{
    public class ConversationService
    {
        // 18. createNewMessage [Message]
        // 19. createNewConversation [Conversation]
        // 20. showAllConversation [Conversation]
        // 21. showAllMessageOfAConversation [Conversation]
        // deleteConversationByConversationId
        // showAllConversationToCurrentLoggedInUser


        // 18. createNewMessage [Message]
        public static MessageDTO CreateNewMessage(MessageDTO messageDto) //🔰 OK - - -🔴🔗
        {
            // auto mapper diye convert korte hobe 

            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<MessageDTO, Message>(messageDto);

            // 🏠 Message Repo er Create method e data return kora niye problem ase
            var result = DataAccessFactory.MessageData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Message, MessageDTO>(result);
            return Model_DTOMapped;

        }


        // 19. createNewConversation [Message] 
        //public static ConversationDTO CreateNewConversation(ConversationDTO conversationDto)
        //{
        //    // auto mapper diye convert korte hobe 

        //    var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<ConversationDTO, DataAccessLayer.EF.Models.Common.Conversations.Conversation>(conversationDto);

        //    var result = DataAccessFactory.ConversationData().Create(DTO_ModelMapped);

        //    var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<DataAccessLayer.EF.Models.Common.Conversations.Conversation, ConversationDTO>(result);
        //    return Model_DTOMapped;

        //}

        // 20. showAllConversation [Conversation] //🔰 - - -🔴🔗

        public static List<ConversationDTO> ShowAllConversation(string loggedInUserEmail)
        {
            var result = DataAccessFactory.IConversationData().ShowAllConversationByLoggedInUserEmail(loggedInUserEmail);
            // Model to DTO
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<DataAccessLayer.EF.Models.Common.Conversations.Conversation, ConversationDTO>(result);

            return Model_DTOMapped;
        }

        // 21. showAllMessageOfAConversation [Conversation] //🔰 - - -🔴🔗
        public static List<MessageDTO> ShowAllMessageOfAConversation(int conversationId)
        {
            var result = DataAccessFactory.IMessageData().GetAllMessageByConversationId(conversationId);
            // Model to DTO
            var Model_DTOMapped = AutoMapperConverter.ConvertForList<Message, MessageDTO>(result);

            // DTO ta thik korte hobe 🏠

            return Model_DTOMapped;
        }


        // . deleteConversationByConversationId
        public static bool DeleteConversationByConversationId(int conversationId)
        {
            // conversation delete korar age .. ei conversationId er shob message gula 
            // delete korte hobe .. 

            // age dekhte hobe ..  conversation ase kina .. thakle .. 
            // tar under e thaka message gula delete korte hobe .. 

            var res = DataAccessFactory.IMessageData().DeleteAllMessageByConversationId(conversationId);
            
            if(res != null)
            {
                var result = DataAccessFactory.ConversationData().Delete(conversationId);
                return result;
            }
            return false;
            
        }

        // .  showAllConversationToCurrentLoggedInUser

        //public static List<DataAccessLayer.EF.Models.Common.Conversations.Conversation> ShowAllConversationToCurrentLoggedInUser(string currentLoggedInUserEmail)
        //{
        //    var result = DataAccessFactory.IConversationData().showAllConversationToCurrentLoggedInUser(currentLoggedInUserEmail);
        //    //DTO conversation .. 🏠
            
        //    return result;
        //}
    }
}
