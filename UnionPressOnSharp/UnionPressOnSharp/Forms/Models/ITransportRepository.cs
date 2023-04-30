using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
    public interface ITransportRepository
    {
        void AddData(TransportModel transportModel);
        void EditData(TransportModel transportModel);
        void DeleteData(string data);
        IEnumerable<TransportModel> GetAll();
        IEnumerable<TransportModel> GetByValue(string value);
    }
}
