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
    public class TypePresenter
    {
        private ITypeView typeView;
        private ITypeRepository  typeRepository;
        private BindingSource typeBindingSource;
        private IEnumerable<TypeModel>typeList;

        public TypePresenter(ITypeView typeView, ITypeRepository typeRepository)
        {
            this.typeBindingSource = new BindingSource();
            this.typeView = typeView;
            this.typeRepository = typeRepository;

            this.typeView.SearchDataEvent += Search;
            this.typeView.AddNewDataEvent += AddNew;
            this.typeView.EditDataEvent += LoadSelectedToEdit;
            this.typeView.DeleteDataEvent += DeleteSelected;
            this.typeView.SaveDataEvent += Save;
            this.typeView.CancelEvent += CancelAction;
            this.typeView.SetTypeListBindingSource(typeBindingSource);

            LoadAllList();


        }


        private void LoadAllList()
        {
            typeList = typeRepository.GetAllType();
            typeBindingSource.DataSource = typeList;
        }
        private void Search(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.typeView.SearchValue);
            if (emptyValue == false)
                typeList = typeRepository.GetByValue(this.typeView.SearchValue);
            else typeList = typeRepository.GetAllType();
            typeBindingSource.DataSource = typeList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            typeView.isEditData = false;
            CleanviewFields();
        }
        private void Save(object sender, EventArgs e)
        {
            var typeModel = new TypeModel();
 
            typeModel.Type = typeView.TypePresss;
            try
            {
                new Common.ModelDataValidation().Validate(typeModel);
                if (typeView.isEditData)//Edit model
                {
                    typeRepository.EditData(typeModel);
                    typeView.Message = "Тип отредактирован";
                }
                else //Add new model
                {
                    typeRepository.AddData(typeModel);
                    typeView.Message = "Тип добавлен";
                }
                typeView.isSuccessful = true;
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                typeView.isSuccessful = false;
                typeView.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            typeView.TypePresss = "";
        }
        private void DeleteSelected(object sender, EventArgs e)
        {
            try
            {
                var type = (TypeModel)typeBindingSource.Current;
                typeRepository.DeleteData(type.Type);
                typeView.isSuccessful = true;
                typeView.Message = "Тип удален";
                LoadAllList();
            }
            catch (Exception)
            {
                typeView.isSuccessful = false;
                typeView.Message = "Ошибка, не удалось удалить тип";
            }
        }
        private void LoadSelectedToEdit(object sender, EventArgs e)
        {
            var type = (TypeModel)typeBindingSource.Current;

            typeView.TypePresss = type.Type;;
            typeView.isEditData = true;
        }
        private void AddNew(object sender, EventArgs e)
        {
            typeView.isEditData = false;
        }


    }
}
