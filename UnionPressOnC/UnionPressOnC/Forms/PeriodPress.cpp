#include <string>
#include "../Forms/Views/IPeriodView.h"
#include "../Forms/Models/IPeriodRepository.h"
#include "PeriodPress.h"

using namespace std;
using namespace UnionPressOnC;

PeriodModel period;
IPeriodView pView;

string periodSrokSubscribe()
{
    period.getSrokSubscribe();
    period.setSrokSubscribe(txtSrok->Texts);
}
string periodSell()
{
    period.getSell();
    period.setSell(txtSell->Texts)
}
string periodTransferChoice()
{
    period.getTransferChoice();
    period.setTransferChoice(txtChoiceTransp->Texts);
}
string periodPopularity()
{
    period.getPopularity();
    period.setPopularity(txtPopularity->Texts);
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
