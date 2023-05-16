#include <string>
#include "../Models/WorkersModel.cpp"
using namespace System::Windows::Forms;
using namespace System;
using namespace std;

namespace UnionPressOnC
{
   public __interface IWorkersView
   {
    //Поля

       string getWorkersSurname()
       {
           WorkersModel wModel;
           wModel.getSurname();
       }

       string setWorkersSurname(string value)
       {
           WorkersModel wModel;
           wModel.setSurname(value);
       }

       string getWorkersName()
       {
           WorkersModel wModel;
           wModel.getName();
       }

       string setWorkersName(string value)
       {
           WorkersModel wModel;
           wModel.setName(value);
       }

       string getWorkersFatherName()
       {
           WorkersModel wModel;
           wModel.getFatherName();
       }

       string setWorkersFatherName(string value)
       {
           WorkersModel wModel;
           wModel.setFatherName(value);
       }

       string getWorkersSpecial()
       {
           WorkersModel wModel;
           wModel.getSpecial();
       }

       string setWorkersSpecial(string value)
       {
           WorkersModel wModel;
           wModel.setSpecial(value);
       }

       string getWorkersNumber()
       {
           WorkersModel wModel;
           wModel.getPhoneNumber();
       }

       string setWorkersNumber(string value)
       {
           WorkersModel wModel;
           wModel.setPhoneNumber(value);
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
        void SetWorkersListBindingSource(BindingSource workerList);
        void Show();


   };
}
