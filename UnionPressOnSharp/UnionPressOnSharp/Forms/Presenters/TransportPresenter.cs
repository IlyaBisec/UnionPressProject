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
    public class TransportPresenter
    {
        private ITransportView transportView;
        private ITransportRepository transportRepository;
        private BindingSource transportBindingSource;
        private IEnumerable<TransportModel> transportList;




        public TransportPresenter(ITransportView transportView, ITransportRepository transportRepository)
        {
            this.transportBindingSource = new BindingSource();
            this.transportView = transportView;
            this.transportRepository = transportRepository;

            this.transportView.SearchDataEvent += Search;
            this.transportView.AddNewDataEvent += AddNew;
            this.transportView.EditDataEvent += LoadSelectedToEdit;
            this.transportView.DeleteDataEvent += DeleteSelected;
            this.transportView.SaveDataEvent += Save;
            this.transportView.CancelEvent += CancelAction;
            this.transportView.SetTransportListBindingSource(transportBindingSource);

            LoadAllList();


        }


        private void LoadAllList()
        {
            transportList = transportRepository.GetAll();
            transportBindingSource.DataSource = transportList;//Set data source.
        }
        private void Search(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.transportView.SearchValue);
            if (emptyValue == false)
                transportList = transportRepository.GetByValue(this.transportView.SearchValue);
            else transportList = transportRepository.GetAll();
            transportBindingSource.DataSource = transportList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            transportView.isEditData = false;
            CleanviewFields();
        }
        private void Save(object sender, EventArgs e)
        {
            var transportModel = new TransportModel();

            transportModel.Begindat = transportView.DataBegin;
            transportModel.Enddat = transportView.DataEnd;
            try
            {
                new Common.ModelDataValidation().Validate(transportModel);
                if (transportView.isEditData)//Edit model
                {
                    transportRepository.EditData(transportModel);
                    transportView.Message = "Доставка отредактирована";
                }
                else //Add new model
                {
                    transportRepository.AddData(transportModel);
                    transportView.Message = "Доставка добавлена";
                }
                transportView.isSuccessful = true;
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                transportView.isSuccessful = false;
                transportView.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            transportView.DataBegin = "";
            transportView.DataEnd = "";
        }
        private void DeleteSelected(object sender, EventArgs e)
        {
            try
            {
                var transport = (TransportModel)transportBindingSource.Current;
                transportRepository.DeleteData(transport.Begindat);
                transportView.isSuccessful = true;
                transportView.Message = "Доставка удалена";
                LoadAllList();
            }
            catch (Exception)
            {
                transportView.isSuccessful = false;
                transportView.Message = "Ошибка, не удалось удалить доставку";
            }
        }
        private void LoadSelectedToEdit(object sender, EventArgs e)
        {
            var transport = (TransportModel)transportBindingSource.Current;

            transportView.DataBegin = transport.Begindat;
            transportView.DataEnd = transport.Enddat;
            transportView.isEditData = true;
        }
        private void AddNew(object sender, EventArgs e)
        {
            transportView.isEditData = false;
        }



    }
}
