#include <string>
#include "../Views/ITransportView.h"
#include "../Models/ITransportRepository.h"
using namespace UnionPressOnC;
using namespace  System;
using namespace  System::Collections::Generic;
using namespace  System::Windows::Forms;

namespace UnionPressOnC
{
    public class TransportPresenter{
    
    private:
        ITransportView transportView;
        ITransportRepository transportRepository;
        BindingSource transportBindingSource;
        IEnumerable<TransportModel> transportList;




    public:
        
        TransportPresenter(ITransportView transportView, ITransportRepository transportRepository)
        {
            this->transportBindingSource = gcnew BindingSource();
            this->transportView = transportView;
            this->transportRepository = transportRepository;

            this->transportView.SearchDataEvent += Search;
            this->transportView.AddNewDataEvent += AddNew;
            this->transportView.EditDataEvent += LoadSelectedToEdit;
            this->transportView.DeleteDataEvent += DeleteSelected;
            this->transportView.SaveDataEvent += Save;
            this->transportView.CancelEvent += CancelAction;
            this->transportView.SetTransportListBindingSource(transportBindingSource);

            LoadAllList();
        }


    private:
            
        void LoadAllList()
        {
            transportList = transportRepository.GetAll();
            transportBindingSource.DataSource = transportList;//Set data source.
        }
        
        void Search(Object sender, EventArgs e)
        {
            bool emptyValue = String::IsNullOrWhiteSpace(this->transportView.getSearchValue());
            if (emptyValue == false)
                transportList = transportRepository.GetByValue(this->transportView.getSearchValue());
            else transportList = transportRepository.GetAll();
            transportBindingSource.DataSource = transportList;
        }
        
        void CancelAction(Object sender, EventArgs e)
        {
            transportView.setIsEditData(false);
            CleanviewFields();
        }
        
        void Save(Object sender, EventArgs e)
        {
            TransportModel transportModel;

            transportModel.dataBegin = transportView.getDataBegin();
            transportModel.dataEnd = transportView.getDataEnd();
            try
            {
                //new Common.ModelDataValidation().Validate(transportModel);
                if (transportView.getIsEditData())//Edit model
                {
                    transportRepository.EditData(transportModel);
                    transportView.setMessage("Доставка отредактирована");
                }
                else //Add new model
                {
                    transportRepository.AddData(transportModel);
                    transportView.setMessage("Доставка добавлена");
                }
                transportView.setIsSuccessful(true);
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception^ ex)
            {
                transportView.setIsSuccessful(false);
                transportView.setMessage(ex->Message);
            }
        }

        void CleanviewFields()
        {
            transportView.setDataBegin("");
            transportView.setDataEnd("");
        }
        
        void DeleteSelected(Object sender, EventArgs e)
        {
            try
            {
                TransportModel transport = (TransportModel)transportBindingSource.Current;
                transportRepository.DeleteData(transport.dataBegin);
                transportView.setIsSuccessful(true);
                transportView.setMessage("Доставка удалена");
                LoadAllList();
            }
            catch (Exception^)
            {
                transportView.setIsSuccessful(false);
                transportView.setMessage("Ошибка, не удалось удалить доставку");
            }
        }
        
        void LoadSelectedToEdit(Object sender, EventArgs e)
        {
            TransportModel transport = (TransportModel)transportBindingSource.Current;

            transportView.setDataBegin(transport.dataBegin);
            transportView.setDataEnd(transport.dataEnd);
            transportView.setIsEditData(true);
        }
        
        void AddNew(Object sender, EventArgs e)
        {
            transportView.setIsEditData(false);
        }



    }
}
