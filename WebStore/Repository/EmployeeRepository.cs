using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Models;

namespace WebStore.Repository
{
    public class EmployeeRepository: IEmployeeRepository<Employee>
    {
        private static readonly List<Employee> Employees = new List<Employee>(10)
            {
                new Employee()
                {
                    Id = 1,
                    Age = 22,
                    FirstName = "Иванов",
                    SurName = "Иван",
                    Patronymic = "Иванович"                    
                },
                new Employee()
                {
                    Id = 2,
                    Age = 35,
                    FirstName = "Пупкин",
                    SurName = "Василий",
                    Patronymic = "Викторович",                    
                }
            };

        public Employee GetItem(int id)
        {
            return Employees.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetItems()
        {
            return Employees;
        }

        /// <summary>
        /// Сохраняет изменения сотрудника в списке
        /// </summary>
        /// <param name="model"></param>
        public void Edit(Employee model)
        {
            //Получаем индекс сущности в списке
            var oldEmployeeIndex = Employees.FindIndex(e => e.Id.Equals(model.Id));

            if (model.Age != Employees[oldEmployeeIndex].Age)
            {
                Employees[oldEmployeeIndex].Age = model.Age;
            }
            if (model.FirstName != Employees[oldEmployeeIndex].FirstName)
            {
                Employees[oldEmployeeIndex].FirstName = model.FirstName;
            }
            if (model.SurName != Employees[oldEmployeeIndex].SurName)
            {
                Employees[oldEmployeeIndex].SurName = model.SurName;
            }
        }

        public void SaveItem(Employee item)
        {
            item.Id = Employees.Max(e => e.Id) + 1;//Новый уникальный Id
            Employees.Add(item);
        }

        public void SaveItems(IEnumerable<Employee> items)
        {
            throw new NotImplementedException();
        }
        public void DeleteItem(int id)
        {
            var item = GetItem(id);
            if (item != null)
                Employees.Remove(item);
        }        
    }
}