using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UnionPressOnSharp.Forms.Models
{
    public class PressModel
    {

        private string caption;
        private string periodOutput;

        [DisplayName("Наименование")]
        [Required(ErrorMessage = "поле Наименование обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        [DisplayName("Период выхода")]
        [Required(ErrorMessage = "поле Период выхода обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string PeriodOutput
        {
            get { return periodOutput; }
            set { periodOutput = value; }
        }
    }
}
