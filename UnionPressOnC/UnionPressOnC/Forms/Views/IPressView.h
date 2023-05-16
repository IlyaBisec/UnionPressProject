#include <string>
#include "../Models/PressModel.cpp"
using namespace System::Windows::Forms;
using namespace System;
using namespace std;

namespace UnionPressOnC
{
    public __interface IPressView
    {
        string getPressCaption()
        {
            PressModel pressModel;
            pressModel.getCaption();
        }

        string setPressCaption(string value)
        {
            PressModel pressModel;
            pressModel.setCaption(value);
        }

        string getPressOutput()
        {
            PressModel pressModel;
            pressModel.getPeriodOutput();
        }

        string setPressOutput(string value)
        {
            PressModel pressModel;
            pressModel.setPeriodOutput(value);
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
        void SetPressListBindingSource(BindingSource pressList);
        void Show();



    };
}
