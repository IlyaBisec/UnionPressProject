#include <string>

using namespace System;
using namespace System::Windows::Forms;
using namespace System::Data::SqlClient;
using namespace System::Data;

public class LoginPass
{
public:

	void registrationAccount(std::string login, std::string password,
		std::string name, std::string surname, std::string age,
		std::string sex, String^ connectionString);

	void authorisationAccount(std::string login, std::string password, String connectionString);

	bool registerCheck(std::string login, std::string password, String connectionString);

	bool RegisterCheck(std::string login, String connectionString);
};


