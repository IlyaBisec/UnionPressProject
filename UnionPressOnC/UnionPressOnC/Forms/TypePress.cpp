
#include <string>
#include "../Forms/Views/ITypeView.h"
#include "../Forms/Models/ITypeRepository.h"
#include "TypePress.h"

using namespace std;
using namespace UnionPressOnC;

TypeModel type;
ITypeView tView;

string typePress()
{
    type.getTypePresss();
    type.setTypePresss(txtSettingsType->Texts);
}
string SearchValue()
{
    tView.getSearchValue();
    tView.setSearchValue(txtType->Texts);
}
bool isEditData()
{
    tView.getIsEditData();
    tView.setIsEditData(isEdit->Texts);
}
bool isSuccessful()
{
    tView.getIsSuccessful();
    tView.setIsSuccessful(successful);
}
string Message()
{
    tView.getMessage();

}
