#include <string>
using namespace System::ComponentModel;
using namespace System::ComponentModel::DataAnnotations;
using namespace std;


namespace UnionPressOnC {
    public class PressModel
    {

    public: 
        
        string caption, periodOutput;

        string getCaption()
        {
            return caption;
        }

        string setCaption(string value)
        {
            return caption = value;
        }

        string getPeriodOutput()
        {
            return periodOutput;
        }

        string setPeriodOutput(string value)
        {
            return periodOutput = value;
        }
    }
}
