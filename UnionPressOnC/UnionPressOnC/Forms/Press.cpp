#include <string>
#include "../Forms/Views/IPressView.h"
#include "../Forms/Models/IPressRepository.h"
#include "Press.h"

using namespace std;
using namespace UnionPressOnC;


IPressView pView;
PressModel pModel;


string pressCaption()
{
    pModel.getCaption()();
    pModel.setCaption(txtCaption->Texts);
}
string pressPeriodOutput()
{
    pModel.getPeriodOutput();
    pModel.setPeriodOutput(txtPeriodOutput->Texts)
}
string SearchValue()
{
    pView.getSearchValue();
    pView.setSearchValue(txtPeriod->Texts);
}
bool isEditData()
{
    pView.getIsEditData();
    pView.setIsEditData(isEdit->Texts);
}
bool isSuccessful()
{
    pView.getIsSuccessful();
    pView.setIsSuccessful(successful);
}
string Message()
{
    pView.getMessage();

}
