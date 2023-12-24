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

namespace BusinessLogicLayer.Services.Common.Conversation
{
    internal class ConversationService
    {
        // 18. createNewMessage [Message]
        // 19. createNewConversation [Conversation]
        // 20. showAllConversation [Conversation]
        // 21. showAllMessageOfAConversation [Conversation]


        // 18. createNewMessage [Message]
        public static MessageDTO createNewMessage(MessageDTO messageDto)
        {
            // auto mapper diye convert korte hobe 

            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<MessageDTO, Message>(messageDto);

            var result = DataAccessFactory.MessageData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Message, MessageDTO>(result);
            return Model_DTOMapped;

        }


        // 19. createNewConversation [Message]
        public static MessageDTO createNewConversation(MessageDTO messageDto)
        {
            // auto mapper diye convert korte hobe 

            var DTO_ModelMapped = AutoMapperConverter.ConvertForSingleInstance<MessageDTO, Message>(messageDto);

            var result = DataAccessFactory.MessageData().Create(DTO_ModelMapped);

            var Model_DTOMapped = AutoMapperConverter.ConvertForSingleInstance<Message, MessageDTO>(result);
            return Model_DTOMapped;

        }

    }
}
