using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionPressOnSharp.Forms.Models;
using UnionPressOnSharp.Forms.Views;
using UnionPressOnSharp.Forms.Presenters.Common;
using System.Windows.Forms;

namespace UnionPressOnSharp.Forms.Presenters
{
    public class PeriodPresenter
    {

        private IPeriodView  periodView;
        private IPeriodRepository  periodRepository;
        private BindingSource periodBindingSource;
        private IEnumerable<PeriodModel> periodList;


        public PeriodPresenter(IPeriodView periodView, IPeriodRepository periodRepository)
        {
            this.periodBindingSource = new BindingSource();
            this.periodView = periodView;
            this.periodRepository = periodRepository;

            this.periodView.SearchDataEvent += Search;
            this.periodView.AddNewDataEvent += AddNew;
            this.periodView.EditDataEvent += LoadSelectedToEdit;
            this.periodView.DeleteDataEvent += DeleteSelected;
            this.periodView.SaveDataEvent += Save;
            this.periodView.CancelEvent += CancelAction;
            this.periodView.SetPeriodListBindingSource(periodBindingSource);

            LoadAllList();


        }


        private void LoadAllList()
        {
            periodList = periodRepository.GetAll();
            periodBindingSource.DataSource = periodList;//Set data source.
        }
        private void Search(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.periodView.SearchValue);
            if (emptyValue == false)
                periodList = periodRepository.GetByValue(this.periodView.SearchValue);
            else periodList = periodRepository.GetAll();
            periodBindingSource.DataSource = periodList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            periodView.isEditData = false;
            CleanviewFields();
        }
        private void Save(object sender, EventArgs e)
        {
            var periodModel = new PeriodModel();

            periodModel.SrokSubscribe = periodView.periodSrokSubscribe;
            periodModel.Sell = periodView.periodSell;
            periodModel.TransferChoice = periodView.periodTransferChoice;
            periodModel.Popularity = periodView.periodPopularity;
            try
            {
                new Common.ModelDataValidation().Validate(periodModel);
                if (periodView.isEditData)//Edit model
                {
                    periodRepository.EditData(periodModel);
                    periodView.Message = "Период издания отредактирован";
                }
                else //Add new model
                {
                    periodRepository.AddData(periodModel);
                    periodView.Message = "Период издания добавлен";
                }
                periodView.isSuccessful = true;
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                periodView.isSuccessful = false;
                periodView.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            periodView.periodSrokSubscribe = "";
            periodView.periodSell = "";
            periodView.periodTransferChoice = "";
            periodView.periodPopularity = "";
        }
        private void DeleteSelected(object sender, EventArgs e)
        {
            try
            {
                var period = (PeriodModel)periodBindingSource.Current;
                periodRepository.DeleteData(period.TransferChoice);
                periodView.isSuccessful = true;
                periodView.Message = "Период издания удален";
                LoadAllList();
            }
            catch (Exception)
            {
                periodView.isSuccessful = false;
                periodView.Message = "Ошибка, не удалось удалить период издания";
            }
        }
        private void LoadSelectedToEdit(object sender, EventArgs e)
        {
            var period = (PeriodModel)periodBindingSource.Current;

            periodView.periodSrokSubscribe = period.SrokSubscribe;
            periodView.periodSell = period.Sell;
            periodView.periodTransferChoice = period.TransferChoice;
            periodView.periodPopularity = period.Popularity;
            periodView.isEditData = true;
        }
        private void AddNew(object sender, EventArgs e)
        {
            periodView.isEditData = false;
        }

    }
}
