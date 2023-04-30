using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
    public interface ITypeRepository
    {
        void AddData(TypeModel typeModel);
        void EditData(TypeModel typeModel);
        void DeleteData(string type);
        IEnumerable<TypeModel> GetAllType();
        IEnumerable<TypeModel> GetByValue(string value); //search

    }
}
