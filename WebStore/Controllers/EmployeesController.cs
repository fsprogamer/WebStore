using System.Web.Mvc;
using WebStore.Models;
using WebStore.Repository;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository<Employee> EmployeesRepo;
        public EmployeesController()
        {
            EmployeesRepo = new EmployeeRepository();
        }
        /// <summary>
        /// Выводит список сотрудников
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View(EmployeesRepo.GetItems());
        }
        /// <summary>
        /// Редактирование или добавление сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            var model = new Employee();
            if (id.HasValue)
                model = EmployeesRepo.GetItem(id.Value);
            return View(model);
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            if (model.Age == 22)
            {
                ModelState.AddModelError("Age", "Ваш возраст не может быть равен 22");
            }
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                    EmployeesRepo.Edit(model);
                else
                    EmployeesRepo.SaveItem(model);

                return RedirectToAction("List");
            }
            return View(model);
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            EmployeesRepo.DeleteItem(id);
            return RedirectToAction("List");
        }
    }
}