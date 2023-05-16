#include <string>
#include "../Views/IPressView.h"
#include "../Models/IPressRepository.h"
using namespace UnionPressOnC;
using namespace  System;
using namespace  System::Collections::Generic;
using namespace  System::Windows::Forms;

namespace UnionPressOnC
{
    public class PressPresenter{
    
private:
       IPressView pressView;
       IPressRepository pressRepository;
       BindingSource pressbindingSource;
       IEnumerable<PressModel> pressList;



    public:
        
        PressPresenter(IPressView pressView, IPressRepository pressRepository)
        {
            this->pressbindingSource = gcnew BindingSource();
            this->pressView = pressView;
            this->pressRepository = pressRepository;

            this->pressView.SearchDataEvent += Search;
            this->pressView.AddNewDataEvent += AddNew;
            this->pressView.EditDataEvent += LoadSelectedToEdit;
            this->pressView.DeleteDataEvent += DeleteSelected;
            this->pressView.SaveDataEvent += Save;
            this->pressView.CancelEvent += CancelAction;
            this->pressView.SetPressListBindingSource(pressbindingSource);
            //Load pet list view
            LoadAllList();


        }


        void LoadAllList()
        {
            pressList = pressRepository.GetAll();
            pressbindingSource.DataSource = pressList;
        }

        void Search(Object sender, EventArgs e)
        {
            bool emptyValue = String::IsNullOrWhiteSpace(this->pressView.getSearchValue());
            if (emptyValue == false)
                pressList = pressRepository.GetByValue(this->pressView.getSearchValue());
            else pressList = pressRepository.GetAll();
            pressbindingSource.DataSource = pressList;
        }

        void CancelAction(Object sender, EventArgs e)
        {
            pressView.setIsEditData(false);
            CleanviewFields();
        }

        void Save(Object sender, EventArgs e)
        {
            PressModel pressModel;

            pressModel.caption = pressView.getPressCaption();
            pressModel.periodOutput = pressView.getPressOutput();
            try
            {
               // new Common.ModelDataValidation().Validate(pressModel);
                if (pressView.getIsEditData())
                {
                    pressRepository.EditData(pressModel);
                    pressView.setMessage("Издание отредактировано");
                }
                else
                {
                    pressRepository.AddData(pressModel);
                    pressView.setMessage("Издание добавлено");
                }
                pressView.setIsSuccessful(true);
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception^ ex)
            {
                pressView.setIsSuccessful(false);
                pressView.setMessage(ex->Message);
            }
        }

        void CleanviewFields()
        {
            pressView.setPressCaption("");
            pressView.setPressOutput("");
        }

        void DeleteSelected(Object sender, EventArgs e)
        {
            try
            {
                PressModel press = (PressModel)pressbindingSource.Current;
                pressRepository.DeleteData(press.caption);
                pressView.setIsSuccessful(true);
                pressView.setMessage("Издание удалено");
                LoadAllList();
            }
            catch (Exception^)
            {
                pressView.setIsSuccessful(false);
                pressView.setMessage("Ошибка, не удалось удалить издание");
            }
        }
        
        void LoadSelectedToEdit(Object sender, EventArgs e)
        {
            PressModel press = (PressModel)pressbindingSource.Current;

            pressView.setPressCaption(press.caption);
            pressView.setPressOutput(press.periodOutput);
            pressView.setIsEditData(true);
        }
        
        void AddNew(Object sender, EventArgs e)
        {
            pressView.setIsEditData(false);
        }



    }
}
