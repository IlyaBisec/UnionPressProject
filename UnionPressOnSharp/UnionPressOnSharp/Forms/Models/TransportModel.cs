using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
    public class TransportModel
    {
        private string dataBegin;
        private string dataEnd;


        [DisplayName("Дата начала")]
        [Required(ErrorMessage = "поле Дата начала обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Begindat
        {
            get { return dataBegin; }
            set { dataBegin = value; }
        }
        [DisplayName("Дата окончания")]
        [Required(ErrorMessage = "поле Дата окончания обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Enddat
        {
            get { return dataEnd; }
            set { dataEnd = value; }
        }
        


    }
}
