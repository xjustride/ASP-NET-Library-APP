//using Data.Entities;
//using Labolatorium_3_App.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Labolatorium_3_App.Models
//{
//    public class MemoryContactService : IContactService
//    {
//        IDateTimeProvider _timeProvider;

//        private Dictionary<int, Contact> _items = new Dictionary<int, Contact>();

//        public MemoryContactService(IDateTimeProvider timeProvider)
//        {
//            _timeProvider = timeProvider;
//        }



//        public int Add(Contact item)
//        {
//            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
//            item.Id = id + 1;
//            item.Created = _timeProvider.GetCurrentDateTime();
//            _items.Add(item.Id, item);
//            return item.Id;
//        }

//        public void Delete(int id)
//        {
//            _items.Remove(id);
//        } 

//        public List<Contact> FindAll()
//        {
//            return _items.Values.ToList();
//        }

//        public List<OrganizationEntity> FindAllOrganizations()
//        {
//            return _items.Organizations.ToList();
//        }

//        public Contact? FindById(int id)
//        {
//            return _items[id];
//        }

//        public void Update(Contact item)
//        {
//            _items[item.Id] = item;
//        }
//    }
//}