#include "WorkersModel.cpp"
using namespace System::Collections::Generic;
namespace UnionPressOnC
{
    public  __interface IWorkersRepository
    {
        void AddData(WorkersModel workersModel);
        void EditData(WorkersModel workersModel);
        void DeleteData(string number);
        IEnumerable<WorkersModel> GetAllWorkers();
        IEnumerable<WorkersModel> GetByValue(string value);


    };
}