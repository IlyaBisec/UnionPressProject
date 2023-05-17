#include "Workers.h"
#include "Views/IWorkersView.h"
#include "Repositories/CWorkersRepository.h"
#include <string>

using namespace std;
using namespace UnionPressOnC;

WorkersModel wModel;
IWorkersView wView;


string workersSurname()
{
    wModel.getSrokSubscribe();
    wModel.setSurname(txtSurname->Texts);
}
string workersName()
{
    wModel.getName();
    wModel.setName(txtName->Texts);
}
string workersFatherName()
{
    wModel.getFatherName();
    wModel.setFatherName(txtFatherName->Texts);
}
string workersSpecial()
{
    wModel.getSpecial();
    wModel.setSpecial(txtSpecial->Texts);
}
string workersPhone()
{
    wModel.getPhoneNumber();
    wModel.setPhoneNumber(txtNumber->Texts);
}
string SearchValue()
{
    wView.getSearchValue();
    wView.setSearchValue(txtW->Texts);
}
bool isEditData()
{
    wView.getIsEditData();
    wView.setIsEditData(isEdit->Texts);
}
bool isSuccessful()
{
    wView.getIsSuccessful();
    wView.setIsSuccessful(successful);
}
string Message()
{
    wView.getMessage();

}
