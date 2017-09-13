using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Имя является обязятельным", AllowEmptyStrings = false)]
        [DisplayName("Введите имя*:")]
        [StringLength(250)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательной")]
        [StringLength(250)]
        [DisplayName("Фамилия")]
        public string SurName { get; set; }

        [StringLength(250)]
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательным")]
        [DisplayName("Возраст")]
        public int Age { get; set; }

    }
}