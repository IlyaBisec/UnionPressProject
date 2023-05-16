#include "PeriodModel.cpp"
using namespace System::Collections::Generic;

namespace UnionPressOnC
{
	public __interface IPeriodRepository
	{
		void AddData(PeriodModel periodModel);
		void EditData(PeriodModel periodModel);
		void DeleteData(string transferChoice);
		IEnumerable<PeriodModel> GetAll();
		IEnumerable<PeriodModel> GetByValue(string value);

	};
}