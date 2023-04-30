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
    public class PressPresenter
    {
        private IPressView pressView;
        private IPressRepository pressRepository;
        private BindingSource pressbindingSource;
        private IEnumerable<PressModel> pressList;



        public PressPresenter(IPressView pressView, IPressRepository pressRepository)
        {
            this.pressbindingSource = new BindingSource();
            this.pressView = pressView;
            this.pressRepository = pressRepository;

            this.pressView.SearchDataEvent += Search;
            this.pressView.AddNewDataEvent += AddNew;
            this.pressView.EditDataEvent += LoadSelectedToEdit;
            this.pressView.DeleteDataEvent += DeleteSelected;
            this.pressView.SaveDataEvent += Save;
            this.pressView.CancelEvent += CancelAction;
            this.pressView.SetPressListBindingSource(pressbindingSource);
            //Load pet list view
            LoadAllList();


        }


        private void LoadAllList()
        {
            pressList = pressRepository.GetAll();
            pressbindingSource.DataSource = pressList;
        }
        private void Search(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.pressView.SearchValue);
            if (emptyValue == false)
                pressList = pressRepository.GetByValue(this.pressView.SearchValue);
            else pressList = pressRepository.GetAll();
            pressbindingSource.DataSource = pressList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            pressView.isEditData = false;
            CleanviewFields();
        }
        private void Save(object sender, EventArgs e)
        {
            var pressModel = new PressModel();

            pressModel.Caption = pressView.PressCaption;
            pressModel.PeriodOutput = pressView.PressOutput;
            try
            {
                new Common.ModelDataValidation().Validate(pressModel);
                if (pressView.isEditData)
                {
                    pressRepository.EditData(pressModel);
                    pressView.Message = "Издание отредактировано";
                }
                else 
                {
                    pressRepository.AddData(pressModel);
                    pressView.Message = "Издание добавлено";
                }
                pressView.isSuccessful = true;
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                pressView.isSuccessful = false;
                pressView.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            pressView.PressCaption = "";
            pressView.PressOutput = "";
        }
        private void DeleteSelected(object sender, EventArgs e)
        {
            try
            {
                var press = (PressModel)pressbindingSource.Current;
                pressRepository.DeleteData(press.Caption);
                pressView.isSuccessful = true;
                pressView.Message = "Издание удалено";
                LoadAllList();
            }
            catch (Exception)
            {
                pressView.isSuccessful = false;
                pressView.Message = "Ошибка, не удалось удалить издание";
            }
        }
        private void LoadSelectedToEdit(object sender, EventArgs e)
        {
            var press = (PressModel)pressbindingSource.Current;

            pressView.PressCaption = press.Caption;
            pressView.PressOutput = press.PeriodOutput;
            pressView.isEditData = true;
        }
        private void AddNew(object sender, EventArgs e)
        {
            pressView.isEditData = false;
        }



    }
}
