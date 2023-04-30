using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UnionPressOnSharp.Forms.Models
{
    public class WorkersModel
    {
        //[Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона] 
        private string surname;
        private string name;
        private string fatherName;
        private string special;
        private string phoneNumber;


        [DisplayName("Фамилия сотрудника")]
        [Required(ErrorMessage = "поле Фамилия обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        [DisplayName("Имя сотрудника")]
        [Required(ErrorMessage = "поле Имя обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Отчество сотрудника")]
        [Required(ErrorMessage = "поле Отчество обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }
        [DisplayName("Специальность сотрудника")]
        [Required(ErrorMessage = "поле Специальность обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Special
        {
            get { return special; }
            set { special = value; }
        }
        [DisplayName("Телефон сотрудника")]
        [Required(ErrorMessage = "поле Телефон обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Phone
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }



    }
}
