#include "TransportModel.cpp"
using namespace System::Collections::Generic;
namespace UnionPressOnC
{
    public  __interface ITransportRepository
    {
        void AddData(TransportModel transportModel);
        void EditData(TransportModel transportModel);
        void DeleteData(string data);
        IEnumerable<TransportModel> GetAll();
        IEnumerable<TransportModel> GetByValue(string value);
    };
}
