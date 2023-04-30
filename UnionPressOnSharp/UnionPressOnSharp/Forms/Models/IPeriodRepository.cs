using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
    public interface IPeriodRepository
    {
        void AddData(PeriodModel periodModel);
        void EditData(PeriodModel periodModel);
        void DeleteData(string transferChoice);
        IEnumerable<PeriodModel> GetAll();
        IEnumerable<PeriodModel> GetByValue(string value);

    }
}
