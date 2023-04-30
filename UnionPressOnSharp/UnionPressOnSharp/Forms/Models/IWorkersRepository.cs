using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionPressOnSharp.Forms.Models
{
   public interface IWorkersRepository 
   {
        void AddData(WorkersModel workersModel);
        void EditData(WorkersModel workersModel);
        void DeleteData(string number);
        IEnumerable<WorkersModel> GetAllWorkers();
        IEnumerable<WorkersModel> GetByValue(string value); 


   }
}
