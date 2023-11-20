using Data.Entities;
using Labolatorium_3_App.Models;

public class MemoryContactService : IContactService
{

    IDateTimeProvider _timeProvider;
    public MemoryContactService(IDateTimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
    }
    private Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
    public int Add(Contact item)
    {
        int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
        item.id = id + 1;
        item.Created = _timeProvider.GetCurrentDateTime();
        _items.Add(item.id, item);
        return item.id;
    }

    public void Delete(int id)
    {
        _items.Remove(id);
    }

    public List<Contact> FindAll()
    {
        return _items.Values.ToList();
    }

    public Contact? FindById(int id)
    {
        return _items[id];
    }

    public void Update(Contact item)
    {
        _items[item.id] = item;
    }

    public List<OrganizationEntity> FindAllOrganizations()
    {
        throw new NotImplementedException();
    }
}