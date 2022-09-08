using DevExpress.DevAV.Chat.Model;
using System;

namespace Chat_Box
{
    public class MessageDto
    {
        
        public long ID { get; set; }
        public Contact Owner { get; set; }
        public string Text { get; set; }
        public DateTime SentOrUpdated { get; set; }
        public string StatusText { get; set; }
        
        public bool IsEdited { get; set; }
       
        public bool IsDeleted { get; set; }
        
        public bool IsLiked { get; set; }
        
        public bool IsOwnMessage { get; set; }
       
        public bool IsFirstMessageOfReply { get; set; }
      
        public bool IsFirstMessageOfBlock { get; set; }
        [Flags]
        public enum MessageStatus
        {
            Own = 1,
            Edited = 2,
            Deleted = 4,
            FirstInBlock = 8,
            FirstInReply = 16,
            Liked = 32
        }
    }
}