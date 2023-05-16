using namespace System::Windows::Forms;
using namespace System;

namespace UnionPressOnC
{
	public __interface IPeriodView
	{
        
        string getPeriodSrokSubscribe()
        {
            PeriodModel perModel;
            perModel.getSrokSubscribe();
        }

        string setPeriodSrokSubscribe(string value)
        {
            PeriodModel perModel;
            perModel.setSrokSubscribe(value);
        }

        string gePeriodSell()
        {
            PeriodModel perModel;
            perModel.getSell();
        }

        string sePeriodSell(string value)
        {
            PeriodModel perModel;
            perModel.setSell(value);
        }

        string getPeriodTransferChoice()
        {
            PeriodModel perModel;
            perModel.getTransferChoice();
        }

        string setPeriodTransferChoice(string value)
        {
            PeriodModel perModel;
            perModel.setTransferChoice(value);
        }

        string getPeriodPopularity()
        {
            PeriodModel perModel;
            perModel.getPopularity();
        }

        string setPeriodPopularity(string value)
        {
            PeriodModel perModel;
            perModel.setPopularity(value);
        }

        string getSearchValue()
        {
            return;
        }

        string setSearchValue(string value)
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

        event EventHandler^ SearchDataEvent;
        event EventHandler^ AddNewDataEvent;
        event EventHandler^ EditDataEvent;
        event EventHandler^ DeleteDataEvent;
        event EventHandler^ SaveDataEvent;
        event EventHandler^ CancelEvent;
	
        //Ìועמהû
        void SetPeriodListBindingSource(BindingSource periodList);
        void Show();
    };
}