#include "TypeModel.cpp"
using namespace System::Collections::Generic;
namespace UnionPressOnC
{
    public  __interface ITypeRepository
    {
        void AddData(TypeModel typeModel);
        void EditData(TypeModel typeModel);
        void DeleteData(string type);
        IEnumerable<TypeModel> GetAllType();
        IEnumerable<TypeModel> GetByValue(string value); //search

    };
}
