#include <string>
using namespace System::ComponentModel;
using namespace System::ComponentModel::DataAnnotations;
using namespace std;


namespace UnionPressOnC {
    
    public class WorkersModel
    {
        //[Фамилия], [Имя], [Отчество], [Должность], [Номер_телефона] 
    public:

        string surname, name, fatherName, special, phoneNumber;

        string getSurname()
        {
            return surname;
        }

        string setSurname(string value)
        {
            return surname = value;
        }

        string getName()
        {
            return name;
        }

        string setName(string value)
        {
            return name = value;
        }

        string getFatherName()
        {
            return fatherName;
        }

        string setFatherName(string value)
        {
            return fatherName = value;
        }

        string getSpecial()
        {
            return special;
        }

        string setSpecial(string value)
        {
            return special = value;
        }

        string getPhoneNumber()
        {
            return phoneNumber;
        }

        string setPhoneNumber(string value)
        {
            return phoneNumber = value;
        }

    };
}
