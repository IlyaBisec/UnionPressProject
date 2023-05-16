#include <string>
using namespace System::ComponentModel;
using namespace System::ComponentModel::DataAnnotations;
using namespace std;


namespace UnionPressOnC {

	public class PeriodModel
	{
    public:

		string srokSubscribe, sell, transferChoice, popularity;

    public: 
        
        string getSrokSubscribe()
        {
            return srokSubscribe;
        }

        string setSrokSubscribe(string value)
        {
            return srokSubscribe = value;
        }

        string getSell()
        {
            return sell;
        }

        string setSell(string value)
        {
            return sell = value;
        }

        string getTransferChoice()
        {
            return transferChoice;
        }

        string setTransferChoice(string value)
        {
            return transferChoice = value;
        }

        string getPopularity()
        {
            return popularity;
        }

        string setPopularity(string value)
        {
            return popularity = value;
        }

	};
}