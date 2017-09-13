using System.Collections.Generic;

namespace WebStore.Repository
{
    public interface IEmployeeRepository<T> where T : class, new()
    {
        //Get all items in the database method
        IEnumerable<T> GetItems();
        //Get specific item in the database method with Id
        T GetItem(int id);
        void Edit(T item);
        void SaveItem(T item);
        void SaveItems(IEnumerable<T> items);
        void DeleteItem(int id);
    }
}
