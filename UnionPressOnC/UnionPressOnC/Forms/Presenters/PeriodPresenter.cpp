#include <string>
#include "../Views/IPeriodView.h"
#include "../Models/IPeriodRepository.h"
using namespace UnionPressOnC;
using namespace  System;
using namespace  System::Collections::Generic;
using namespace  System::Windows::Forms;

namespace UnionPressOnC
{
    public class PeriodPresenter
    {
    private:

         IPeriodView  periodView;
         IPeriodRepository  periodRepository;
         BindingSource periodBindingSource;
         IEnumerable<PeriodModel> periodList;


    public: 
        PeriodPresenter(IPeriodView periodView, IPeriodRepository periodRepository)
        {
            this->periodBindingSource = gcnew BindingSource();
            this->periodView = periodView;
            this->periodRepository = periodRepository;

            this->periodView.SearchDataEvent += Search;
            this->periodView.AddNewDataEvent += AddNew;
            this->periodView.EditDataEvent += LoadSelectedToEdit;
            this->periodView.DeleteDataEvent += DeleteSelected;
            this->periodView.SaveDataEvent += Save;
            this->periodView.CancelEvent += CancelAction;
            this->periodView.SetPeriodListBindingSource(periodBindingSource);

            LoadAllList();
        }

    private:
         
        void LoadAllList()
         {
            periodList = periodRepository.GetAll();
            periodBindingSource.DataSource = periodList;//Set data source.
         }

        void Search(Object^ sender, EventArgs e)
        {
            bool emptyValue = String::IsNullOrWhiteSpace(this->periodView.getSearchValue());
            if (emptyValue == false)
                periodList = periodRepository.GetByValue(this->periodView.setSearchValue(emptyValue));
            else periodList = periodRepository.GetAll();
            periodBindingSource.DataSource = periodList;
        }
        
        void CancelAction(Object^ sender, EventArgs e)
        {
             periodView.setIsEditData(0);
            CleanviewFields();
        }
        
        void Save(Object^ sender, EventArgs e)
        {
            PeriodModel periodModel;

            periodModel.srokSubscribe = periodView.getPeriodSrokSubscribe();
            periodModel.sell = periodView.gePeriodSell();
            periodModel.transferChoice = periodView.getPeriodTransferChoice();
            periodModel.popularity = periodView.getPeriodPopularity();
            try
            {
               // new Common.ModelDataValidation().Validate(periodModel);
                if (periodView.getIsEditData())//Edit model
                {
                    periodRepository.EditData(periodModel);
                    periodView.setMessage("Период издания отредактирован");
                }
                else //Add new model
                {
                    periodRepository.AddData(periodModel);
                    periodView.setMessage("Период издания добавлен");
                }
                periodView.setIsSuccessful(1); //t
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception^ ex)
            {
                periodView.setIsSuccessful(0); //f
                periodView.setMessageS();
            }
        }

        void CleanviewFields()
        {
            periodView.setPeriodSrokSubscribe("");
            periodView.sePeriodSell("");
            periodView.setPeriodTransferChoice("");
            periodView.setPeriodPopularity("");
        }
   
        void DeleteSelected(Object^ sender, EventArgs e)
        {
            try
            {
                PeriodModel period = (PeriodModel)periodBindingSource.Current;
                periodRepository.DeleteData(period.transferChoice);
                periodView.setIsSuccessful(true);
                periodView.setMessage("Период издания удален");
                LoadAllList();
            }
            catch (Exception^)
            {
                periodView.setIsSuccessful(0);
                periodView.setMessage("Ошибка, не удалось удалить период издания");
            }
        }
        
        void LoadSelectedToEdit(Object^ sender, EventArgs e)
        {
            PeriodModel period = (PeriodModel)periodBindingSource.Current;

            periodView.setPeriodSrokSubscribe(period.srokSubscribe);
            periodView.sePeriodSell(period.sell);
            periodView.setPeriodTransferChoice(period.transferChoice);
            periodView.setPeriodPopularity(period.popularity);
            periodView.setIsEditData(true);
        }
       
        void AddNew(Object^ sender, EventArgs e)
        {
            periodView.setIsEditData(false);
        }

    };
}
