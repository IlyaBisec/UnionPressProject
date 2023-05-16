#include <string>
#include "../Models/TypeModel.cpp"
using namespace System::Windows::Forms;
using namespace System;
using namespace std;

namespace UnionPressOnC
{
    public __interface ITypeView
    {

        string getTypePresss()
        {
            TypeModel typModel;
            typModel.getType();
        }

        string setTypePresss(string value)
        {
            TypeModel typModel;
            typModel.setType(value);
        }


        //
        string getSearchValue()
        {
            return;
        }

        string setSearchValue(string value)
        {
            return value;
        }

        bool getIsEditData()
        {
            return;
        }

        bool setIsEditData(int value)
        {
            return value;
        }

        bool getIsSuccessful()
        {
            return;
        }

        bool setIsSuccessful(int value)
        {
            return value;
        }

        string getMessage()
        {
            return;
        }

        string setMessage(string value)
        {
            return value;
        }

        String setMessageS()
        {
            return;
        }

            //События
            event EventHandler SearchDataEvent;
            event EventHandler AddNewDataEvent;
            event EventHandler EditDataEvent;
            event EventHandler DeleteDataEvent;
            event EventHandler SaveDataEvent;
            event EventHandler CancelEvent;

            void SetTypeListBindingSource(BindingSource workerList);
            void Show();
        }
}
