using BusinessLogicLayer.DTOs.Common.Conversation;
using BusinessLogicLayer.DTOs.Conversation;
using BusinessLogicLayer.Services.Common.Conversation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce_Web_App_API.Controllers.Common.Conversation
{
    public class ConversationController : ApiController
    {
        // 21. createNewMessage [Message]

        [HttpPost]
        [Route("api/seller/message/createNewMessage")] //🔰 - - -🔴🔗
        public HttpResponseMessage CreateNewMessage(MessageDTO messageDTO)
        {
            try
            {
                //ConversationService.CreateNewMessage(messageDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "New Message Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 22. createNewConversation [Conversation] //🔰 - - -🔴🔗

        [HttpPost]
        [Route("api/seller/conversation/createNewConversation")] //🔰 - - -🔴🔗
        public HttpResponseMessage CreateNewConversation(ConversationDTO conversationDto)
        {
            try
            {
                ConversationService.CreateNewConversation(conversationDto);
                return Request.CreateResponse(HttpStatusCode.OK, "New Conversation Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 23. showAllConversation [Conversation] 

        [HttpGet]
        [Route("api/seller/message/showAllConversation/{loggedInUserEmail}")] //🔰 - - -🔴🔗
        public HttpResponseMessage ShowAllConversation(string loggedInUserEmail)
        {
            try
            {
                var allConversation = ConversationService.ShowAllConversation(loggedInUserEmail);
                return Request.CreateResponse(HttpStatusCode.OK, allConversation);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        // 24. showAllMessageOfAConversation [Conversation] //🔰 - - -🔴🔗

        [HttpGet]
        [Route("api/seller/message/showAllMessageOfAConversation/{conversationId}")]
        public HttpResponseMessage ShowAllMessageOfAConversation(int conversationId)
        {
            try
            {
                var allConversation = ConversationService.ShowAllMessageOfAConversation(conversationId);
                return Request.CreateResponse(HttpStatusCode.OK, allConversation);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }

}
