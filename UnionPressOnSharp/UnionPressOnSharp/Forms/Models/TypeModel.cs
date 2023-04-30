using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
    public class TypeModel
    {
        string type;

        [DisplayName("Тип печати")]
        [Required(ErrorMessage = "поле Тип обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
