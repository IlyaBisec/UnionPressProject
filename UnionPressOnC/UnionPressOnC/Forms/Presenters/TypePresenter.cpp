#include <string>
#include "../Views/ITypeView.h"
#include "../Models/ITypeRepository.h"
using namespace UnionPressOnC;
using namespace  System;
using namespace  System::Collections::Generic;
using namespace  System::Windows::Forms;

namespace UnionPressOnC
{
    public class TypePresenter
    {
    private:
         ITypeView typeView;
         ITypeRepository  typeRepository;
         BindingSource typeBindingSource;
         IEnumerable<TypeModel>typeList;

    public:
        
        TypePresenter(ITypeView typeView, ITypeRepository typeRepository)
        {
            this->typeBindingSource = gcnew BindingSource();
            this->typeView = typeView;
            this->typeRepository = typeRepository;

            this->typeView.SearchDataEvent += Search;
            this->typeView.AddNewDataEvent += AddNew;
            this->typeView.EditDataEvent += LoadSelectedToEdit;
            this->typeView.DeleteDataEvent += DeleteSelected;
            this->typeView.SaveDataEvent += Save;
            this->typeView.CancelEvent += CancelAction;
            this->typeView.SetTypeListBindingSource(typeBindingSource);

            LoadAllList();
        }


    private:
            
        void LoadAllList()
        {
            typeList = typeRepository.GetAllType();
            typeBindingSource.DataSource = typeList;
        }
        
        void Search(Object sender, EventArgs e)
        {
            bool emptyValue = String::IsNullOrWhiteSpace(this->typeView.getSearchValue());
            if (emptyValue == false)
                typeList = typeRepository.GetByValue(this->typeView.getSearchValue());
            else typeList = typeRepository.GetAllType();
            typeBindingSource.DataSource = typeList;
        }
        
        void CancelAction(Object sender, EventArgs e)
        {
            typeView.setIsEditData(false);
            CleanviewFields();
        }
        
        void Save(Object sender, EventArgs e)
        {
            TypeModel typeModel;

            typeModel.type = typeView.getTypePresss();
            try
            {
                //new Common.ModelDataValidation().Validate(typeModel);
                if (typeView.getIsEditData())//Edit model
                {
                    typeRepository.EditData(typeModel);
                    typeView.setMessage("Тип отредактирован");
                }
                else //Add new model
                {
                    typeRepository.AddData(typeModel);
                    typeView.setMessage("Тип добавлен");
                }
                typeView.setIsSuccessful(true);
                LoadAllList();
                CleanviewFields();
            }
            catch (Exception^ ex)
            {
                typeView.setIsSuccessful(false);
                typeView.setMessage(ex->Message);
            }
        }

        
        void CleanviewFields()
        {
            typeView.setTypePresss("");
        }
        
        void DeleteSelected(Object sender, EventArgs e)
        {
            try
            {
                TypeModel type = (TypeModel)typeBindingSource.Current;
                typeRepository.DeleteData(type.type);
                typeView.setIsSuccessful(true);
                typeView.setMessage("Тип удален");
                LoadAllList();
            }
            catch (Exception^)
            {
                typeView.setIsSuccessful(false);
                typeView.setMessage("Ошибка, не удалось удалить тип");
            }
        }
        
        void LoadSelectedToEdit(Object sender, EventArgs e)
        {
            TypeModel type = (TypeModel)typeBindingSource.Current;

            typeView.setTypePresss(type.type);
            typeView.setIsEditData(true);
        }
        
        void AddNew(Object sender, EventArgs e)
        {
            typeView.setIsEditData(false);
        }


    }
}
