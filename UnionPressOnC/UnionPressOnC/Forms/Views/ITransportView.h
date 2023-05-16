#include "../Models/TransportModel.cpp"
using namespace System::Windows::Forms;
using namespace System;
using namespace std;

namespace UnionPressOnC
{
    public __interface ITransportView
    {
        string getDataBegin()
        {
            TransportModel tpModel;
            tpModel.getDataBegin();
        }

        string setDataBegin(string value)
        {
            TransportModel tpModel;
            tpModel.setDataBegin(value);
        }

        string getDataEnd()
        {
            TransportModel tpModel;
            tpModel.getDataEnd();
        }

        string setDataEnd(string value)
        {
            TransportModel tpModel;
            tpModel.setDataEnd(value);
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

        //Методы
        void SetTransportListBindingSource(BindingSource transportList);
        void Show();

    };
}
