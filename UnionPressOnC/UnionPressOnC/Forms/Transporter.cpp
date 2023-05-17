

#include <string>
#include "../Forms/Views/ITransportView.h"
#include "../Forms/Models/ITransportRepository.h"
#include "Transporter.h"

using namespace std;
using namespace UnionPressOnC;

TransportModel transport;
ITransportView tView;

string transportDataBegin()
{
    transport.getDataBegin();
    transport.setDataBegin(txtBeginDate->Texts);
}
string transportDataEnd()
{
    transport.getDataEnd();
    transport.setDataEnd(txtEndDate->Texts);
}
string SearchValue()
{
    tView.getSearchValue();
    tView.setSearchValue(txtPeriod->Texts);
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
