#include <string>
using namespace System::ComponentModel;
using namespace System::ComponentModel::DataAnnotations;
using namespace std;


namespace UnionPressOnC {
    public class TransportModel
    {
    public:
        string dataBegin, dataEnd;

        string getDataBegin()
        {
            return dataBegin;
        }

        string setDataBegin(string value)
        {
            return dataBegin = value;
        }

        string getDataEnd()
        {
            return dataEnd;
        }

        string setDataEnd(string value)
        {
            return dataEnd = value;
        }
    };
}
