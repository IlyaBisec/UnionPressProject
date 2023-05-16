#include <string>
using namespace System::ComponentModel;
using namespace System::ComponentModel::DataAnnotations;
using namespace std;

namespace UnionPressOnC {
    public class TypeModel
    {
    public:

        string type;

        string getType()
        {
            return type;
        }

        string setType(string value)
        {
            return type = value;
        }
    };
}
