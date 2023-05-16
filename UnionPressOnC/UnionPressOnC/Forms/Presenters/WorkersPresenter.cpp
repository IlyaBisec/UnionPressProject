#include <string>
#include "../Views/IWorkersView.h"
#include "../Models/IWorkersRepository.h"
using namespace UnionPressOnC;
using namespace  System;
using namespace  System::Collections::Generic;
using namespace  System::Windows::Forms;

namespace UnionPressOnC
{
   public class WorkersPresenter
    {
    private:
         IWorkersView workersView;
         IWorkersRepository workersRepository;
         BindingSource workersBindingSource;
         IEnumerable<WorkersModel> workersList;


    public:
        
        WorkersPresenter(IWorkersView workersView, IWorkersRepository workersRepository)
        {
            this->workersBindingSource = gcnew BindingSource();
            this->workersView = workersView;
            this->workersRepository = workersRepository;

            this->workersView.SearchDataEvent += SearchWorker;
            this->workersView.AddNewDataEvent += AddNewWorkers;
            this->workersView.EditDataEvent += LoadSelectedWorkersToEdit;
            this->workersView.DeleteDataEvent += DeleteSelectedWorkers;
            this->workersView.SaveDataEvent += SaveWorkers;
            this->workersView.CancelEvent += CancelAction;
            this->workersView.SetWorkersListBindingSource(workersBindingSource);

            LoadAllWorkersList();
        }


    private:
        
        void LoadAllWorkersList()
        {
            workersList = workersRepository.GetAllWorkers();
            workersBindingSource.DataSource = workersList;
        }

        void SearchWorker(Object sender, EventArgs e)
        {
            bool emptyValue = String::IsNullOrWhiteSpace(this->workersView.getSearchValue());
            if (emptyValue == false)
                workersList = workersRepository.GetByValue(this->workersView.getSearchValue());
            else workersList = workersRepository.GetAllWorkers();
            workersBindingSource.DataSource = workersList;
        }
        
        void CancelAction(Object sender, EventArgs e)
        {
            workersView.setIsEditData(false);
            CleanviewFields();
        }
        
        void SaveWorkers(Object sender, EventArgs e)
        {
            WorkersModel workerModel;

            workerModel.surname = workersView.getWorkersSurname();
            workerModel.name = workersView.getWorkersName();
            workerModel.fatherName = workersView.getWorkersFatherName();
            workerModel.special = workersView.getWorkersSpecial();
            workerModel.phoneNumber = workersView.getWorkersNumber();
            try
            {
                //new Common.ModelDataValidation().Validate(workerModel);
                if (workersView.getIsEditData())//Edit model
                {
                    workersRepository.EditData(workerModel);
                    workersView.setMessage("Сотрудник отредактирован");
                }
                else //Add new model
                {
                    workersRepository.AddData(workerModel);
                    workersView.setMessage("Сотрудник добавлен");
                }
                workersView.setIsSuccessful(true);
                LoadAllWorkersList();
                CleanviewFields();
            }
            catch (Exception^ ex)
            {
                workersView.setIsSuccessful(false);
                workersView.setMessage(ex->Message);
            }
        }

        void CleanviewFields()
        {
            workersView.setWorkersSurname("");
            workersView.setWorkersName("");
            workersView.setWorkersFatherName("");
            workersView.setWorkersSpecial("");
            workersView.setWorkersNumber("");
        }

        void DeleteSelectedWorkers(Object sender, EventArgs e)
        {
            try
            {
                WorkersModel worker = (WorkersModel)workersBindingSource.Current;
                workersRepository.DeleteData(worker.phoneNumber);
                workersView.setIsSuccessful(1); //t
                workersView.setMessage("Сотрудник удален");
                LoadAllWorkersList();
            }
            catch (Exception^)
            {
                workersView.setIsSuccessful(0);
                workersView.setMessage("Ошибка, не удалось удалить сотрудника");
            }
        }
        
        void LoadSelectedWorkersToEdit(Object sender, EventArgs e)
        {
            WorkersModel worker = (WorkersModel)workersBindingSource.Current;

            workersView.setWorkersSurname(worker.surname);
            workersView.setWorkersName(worker.name);
            workersView.setWorkersFatherName(worker.fatherName);
            workersView.setWorkersSpecial(worker.special);
            workersView.setWorkersNumber(worker.phoneNumber);
            workersView.setIsEditData(1);
        }
        
        void AddNewWorkers(Object sender, EventArgs e)
        {
            workersView.setIsEditData(0);
        }




    }
}
