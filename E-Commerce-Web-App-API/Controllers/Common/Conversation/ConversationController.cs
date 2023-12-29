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
        [Route("api/conversation/createNewMessage")] //🔰 OK - - -🔴🔗
        public HttpResponseMessage CreateNewMessage(MessageDTO messageDTO)
        {
            try
            {
                var createdMessage =  ConversationService.CreateNewMessage(messageDTO);
                return Request.CreateResponse(HttpStatusCode.OK, createdMessage);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // 22. createNewConversation [Conversation] //🔰 - - -🔴🔗

        //[HttpPost]
        //[Route("api/conversation/createNewConversation")] //🔰 - - -🔴🔗
        //public HttpResponseMessage CreateNewConversation(ConversationDTO conversationDto)
        //{
        //    try
        //    {
        //        var createdConversation =  ConversationService.CreateNewConversation(conversationDto);
        //        return Request.CreateResponse(HttpStatusCode.OK, createdConversation);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        // 23. showAllConversation [Conversation] 

        [HttpGet]
        [Route("api/conversation/All")] //🔰 - - -🔴🔗 {loggedInUserEmail}
        public HttpResponseMessage ShowAllConversation([FromUri] string loggedInUserEmail)
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
        [Route("api/conversation/showAllMessage/by/")] // {conversationId}
        public HttpResponseMessage ShowAllMessageOfAConversation([FromUri] int conversationId)
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

        // deleteConversationByConversationId
        [HttpDelete]
        [Route("api/conversation/deletedConversation/by")] // {conversationId}
        public HttpResponseMessage DeleteConversationByConversationId([FromUri] int conversationId)
        {
            try
            {
                var deletedConversation = ConversationService.DeleteConversationByConversationId(conversationId);
                return Request.CreateResponse(HttpStatusCode.OK, deletedConversation);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }

}
