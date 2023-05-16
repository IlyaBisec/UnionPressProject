#include "PressModel.cpp"
using namespace System::Collections::Generic;
namespace UnionPressOnC
{
    public  __interface IPressRepository
    {

        void AddData(PressModel  pressModel);
        void EditData(PressModel pressModel);
        void DeleteData(string caption);
        IEnumerable<PressModel> GetAll();
        IEnumerable<PressModel> GetByValue(string value);


    };
}
