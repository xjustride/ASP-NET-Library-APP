using Data.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Labolatorium_3_App.Models

{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity
            {
                ContactId = model.id,
                Birth = model.Birth,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                OrgaznizationId = model.OrganizationId,
                Priority = (int)model.Priority,
            };
        }

        public static BookEntity ToEntity(Book model) 
        {
            return new BookEntity
            {
                BookId = model.id,
                Title = model.Title,
                Page_No = model.Page_No,
                ISBN = model.ISBN,
                PublicationDate = model.PublicationDate,
                PublishingHouse = model.PublishingHouse,
            };
        }





        public static Contact FromEntity(ContactEntity entity) 
        {
            return new Contact()
            {
                id = entity.ContactId,
                Birth = entity.Birth,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                OrganizationId = entity.OrgaznizationId,
                Priority = (Priority)entity.Priority,
            };
            

        }

        public static Contact FromEntity(BookEntity entity)
        {
            return new Contact()
            {
                
            };


        }
    }
}
