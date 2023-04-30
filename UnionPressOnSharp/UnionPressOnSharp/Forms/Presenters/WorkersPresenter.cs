using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Models;
using UnionPressOnSharp.Forms.Views;
using UnionPressOnSharp.Forms.Presenters.Common;

namespace UnionPressOnSharp.Forms.Presenters
{
   public class WorkersPresenter
    {
        private IWorkersView workersView;
        private IWorkersRepository workersRepository;
        private BindingSource workersBindingSource;
        private IEnumerable<WorkersModel> workersList;


        public WorkersPresenter(IWorkersView workersView, IWorkersRepository workersRepository)
        {
            this.workersBindingSource = new BindingSource();
            this.workersView = workersView;
            this.workersRepository = workersRepository;

            this.workersView.SearchDataEvent += SearchWorker;
            this.workersView.AddNewDataEvent += AddNewWorkers;
            this.workersView.EditDataEvent += LoadSelectedWorkersToEdit;
            this.workersView.DeleteDataEvent += DeleteSelectedWorkers;
            this.workersView.SaveDataEvent += SaveWorkers;
            this.workersView.CancelEvent += CancelAction;
            this.workersView.SetWorkersListBindingSource(workersBindingSource);

            LoadAllWorkersList();


        }


        private void LoadAllWorkersList()
        {
            workersList = workersRepository.GetAllWorkers();
            workersBindingSource.DataSource = workersList;
        }
        private void SearchWorker(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.workersView.SearchValue);
            if (emptyValue == false)
                workersList = workersRepository.GetByValue(this.workersView.SearchValue);
            else workersList = workersRepository.GetAllWorkers();
            workersBindingSource.DataSource = workersList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            workersView.isEditData = false;
            CleanviewFields();
        }
        private void SaveWorkers(object sender, EventArgs e)
        {
            var workerModel = new WorkersModel();
   
            workerModel.Surname = workersView.WorkersSurname;
            workerModel.Name = workersView.WorkersName;
            workerModel.FatherName = workersView.WorkersFatherName;
            workerModel.Special = workersView.WorkersSpecial;
            workerModel.Phone = workersView.WorkersNumber;
            try
            {
                new Common.ModelDataValidation().Validate(workerModel);
                if (workersView.isEditData)//Edit model
                {
                    workersRepository.EditData(workerModel);
                    workersView.Message = "Сотрудник отредактирован";
                }
                else //Add new model
                {
                    workersRepository.AddData(workerModel);
                    workersView.Message = "Сотрудник добавлен";
                }
                workersView.isSuccessful = true;
                LoadAllWorkersList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                workersView.isSuccessful = false;
                workersView.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            workersView.WorkersSurname = "";
            workersView.WorkersName = "";
            workersView.WorkersFatherName = "";
            workersView.WorkersSpecial = "";
            workersView.WorkersNumber = "";
        }
        private void DeleteSelectedWorkers(object sender, EventArgs e)
        {
            try
            {
                var worker = (WorkersModel)workersBindingSource.Current;
                workersRepository.DeleteData(worker.Phone);
                workersView.isSuccessful = true;
                workersView.Message = "Сотрудник удален";
                LoadAllWorkersList();
            }
            catch (Exception)
            {
                workersView.isSuccessful = false;
                workersView.Message = "Ошибка, не удалось удалить сотрудника";
            }
        }
        private void LoadSelectedWorkersToEdit(object sender, EventArgs e)
        {
            var worker = (WorkersModel)workersBindingSource.Current;

            workersView.WorkersSurname = worker.Surname;
            workersView.WorkersName = worker.Name;
            workersView.WorkersFatherName = worker.FatherName;
            workersView.WorkersSpecial = worker.Special;
            workersView.WorkersNumber = worker.Phone;
            workersView.isEditData = true;
        }
        private void AddNewWorkers(object sender, EventArgs e)
        {
            workersView.isEditData = false;
        }




    }
}
