using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
    public interface IPressRepository
    {

        void AddData(PressModel  pressModel);
        void EditData(PressModel pressModel);
        void DeleteData(string caption);
        IEnumerable<PressModel> GetAll();
        IEnumerable<PressModel> GetByValue(string value);


    }
}
