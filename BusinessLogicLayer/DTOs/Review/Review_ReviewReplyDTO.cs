using BusinessLogicLayer.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Review
{
    public class Review_ReviewReplyDTO : ReviewDTO
    {
        // eta te Review er shob kichu thakbe .. 
        // additionally 
        public List<ReviewReplyDTO> reviewReplies {  get; set; }

        // List ke shob shomoy initiate korte hoy 

        public Review_ReviewReplyDTO() { 
            reviewReplies = new List<ReviewReplyDTO>();
        }


        //🔴⚫🔗🏠 User er information o jodi dekhate chai .. 

        // public UserDTO User { get; set; } // User er shob information chole ashbe 
        // Service er moddhe c.CreateMap er moddhe mapping bole dite hobe <User, UserDTO>()
    }
}
