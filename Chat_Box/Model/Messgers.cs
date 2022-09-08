using DevExpress.DevAV.Chat.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Chat_Box.Model
{
    public class Messgers
    {
        public static List<Message> Messages
        {
            get
            {
                Image tempImage = null;
                using (FileStream fs = new FileStream("007.png", FileMode.Open, FileAccess.Read))
                {
                    tempImage = Image.FromStream(fs);
                }
                List<Contact> contacts = new List<Contact>()
            {
                new Contact(1,"User1", tempImage),
                new Contact(2,"User2", tempImage),
                new Contact(3,"User3", tempImage),
                new Contact(4,"User4", tempImage),
                new Contact(5,"User5", tempImage),
                new Contact(6,"User6", tempImage),
            };

                List<Message> messages = new List<Message>()
                {
                new Message(contacts[0],"Chào bạn Uses1",DateTime.Now),
                new Message(contacts[0],"Chào bạn Uses2",DateTime.Now),
                new Message(contacts[0],"Chào bạn Uses3",DateTime.Now),
                new Message(contacts[0],"Chào bạn Uses4",DateTime.Now),
                new Message(contacts[0],"Chào bạn Uses5",DateTime.Now),
                new Message(contacts[0],"Chào bạn Uses6",DateTime.Now),

                new Message(contacts[1],"Chào bạn Uses11",DateTime.Now),
                new Message(contacts[1],"Chào bạn Uses12",DateTime.Now),
                new Message(contacts[1],"Chào bạn Uses13",DateTime.Now),
                new Message(contacts[1],"Chào bạn Uses14",DateTime.Now),

                new Message(contacts[2],"Chào bạn Uses21",DateTime.Now),
                new Message(contacts[2],"Chào bạn Uses22",DateTime.Now),
                new Message(contacts[2],"Chào bạn Uses23",DateTime.Now),
                new Message(contacts[2],"Chào bạn Uses24",DateTime.Now),

                new Message(contacts[3],"Chào bạn Uses21A",DateTime.Now),
                new Message(contacts[3],"Chào bạn Uses22A",DateTime.Now),
                new Message(contacts[3],"Chào bạn Uses23A",DateTime.Now),

                new Message(contacts[4],"Chào bạn Uses43A",DateTime.Now),
                new Message(contacts[4],"Chào bạn Uses44A",DateTime.Now),

                new Message(contacts[5],"Chào bạn Uses232A",DateTime.Now),
                new Message(contacts[5],"Chào bạn Uses3232A",DateTime.Now)
                };
                return messages;
            }
            set { }
        }
        public static List<MessageDto> GetMessageDtos()
        {
            Image tempImage = null;
            using (FileStream fs = new FileStream("007.png", FileMode.Open, FileAccess.Read))
            {
                tempImage = Image.FromStream(fs);
            }
            List<Contact> contacts = new List<Contact>()
            {
                new Contact(1,"User1", tempImage),
                new Contact(2,"User2", tempImage),
                new Contact(3,"User3", tempImage),
                new Contact(4,"User4", tempImage),
                new Contact(5,"User5", tempImage),
                new Contact(6,"User6", tempImage),
            };

            List<MessageDto> messageDtos = new List<MessageDto>()
            {
                new MessageDto(){ ID =1, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[0], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Chào bạn" },

                new MessageDto(){ ID =2, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=true, Owner =contacts[0], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Bạn nhé" },

                new MessageDto(){ ID =3, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[0], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Chào bạn nhé" },
                new MessageDto(){ ID =4, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = true, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[0], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Chào bạn é" },


                new MessageDto(){ ID =5, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[1], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Bạn đăng nhập" },
                new MessageDto(){ ID =6, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=true, Owner =contacts[1], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Nhận việc ngay" },

                new MessageDto(){ ID =7, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=true, Owner =contacts[2], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Đã Có Việc" },
                new MessageDto(){ ID =8, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[2], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Nhận luôn việc nhé" },

                new MessageDto(){ ID =9, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[3], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Biệt đội báo thù" },
                new MessageDto(){ ID =10, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=true, Owner =contacts[3], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Cuộc Chiến Vô Cực" },

                new MessageDto(){ ID =11, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[4], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Siêu anh hùng" },
                new MessageDto(){ ID =12, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=true, Owner =contacts[4], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="IronMan" },

                new MessageDto(){ ID =13, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=false, Owner =contacts[5], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Vâng một loạt skill vần đôi được ad đua ra để pha combat được sống động hơn" },
                new MessageDto(){ ID =14, IsDeleted = false, IsEdited=false,
                    IsFirstMessageOfBlock = false, IsFirstMessageOfReply= false,
                    IsLiked=true, IsOwnMessage=true, Owner =contacts[5], SentOrUpdated =DateTime.Now, StatusText ="Online", Text ="Ông này review hay thật xem cười cả ngày ln. Cảm ơn ông nhiều" }
            };
            return messageDtos;
        }
    }
}