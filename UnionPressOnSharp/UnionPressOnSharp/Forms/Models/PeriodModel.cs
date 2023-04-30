using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UnionPressOnSharp.Forms.Models
{
    public class PeriodModel
    {
        private string srokSubscribe;
        private string sell;
        private string transferChoice;
        private string popularity;


        [DisplayName("Срок подписки")]
        [Required(ErrorMessage = "поле Срок подписки обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string SrokSubscribe
        {
            get { return srokSubscribe; }
            set { srokSubscribe = value; }
        }
        [DisplayName("Стоимость")]
        [Required(ErrorMessage = "поле Стоимость обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Sell
        {
            get { return sell; }
            set { sell = value; }
        }
        [DisplayName("Способ доставки")]
        [Required(ErrorMessage = "поле Способ доставки обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string TransferChoice
        {
            get { return transferChoice; }
            set { transferChoice = value; }
        }
        [DisplayName("Популярность %")]
        [Required(ErrorMessage = "поле Популярность обязательное")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "длина от 2 до 40 симовлов")]
        public string Popularity
        {
            get { return popularity; }
            set { popularity = value; }
        }
    }
}
