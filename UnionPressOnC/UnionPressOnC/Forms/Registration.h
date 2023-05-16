#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Registration
	/// </summary>
	public ref class Registration : public System::Windows::Forms::Form
	{
	public:
		Registration(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~Registration()
		{
			if (components)
			{
				delete components;
			}
		}
	private: OwnControls::Controls::Modern_PictureBox^ modern_PictureBox1;
	protected:
	public: OwnControls::Controls::Modern_TextBox^ txtPassword;
	public: OwnControls::Controls::Modern_TextBox^ txtSex;
	public: OwnControls::Controls::Modern_TextBox^ txtSurname;
	public: OwnControls::Controls::Modern_TextBox^ txtLogin;
	public: OwnControls::Controls::Modern_TextBox^ txtAge;
	public: OwnControls::Controls::Modern_TextBox^ txtName;
	public: System::Windows::Forms::Label^ lblSex;
	public: System::Windows::Forms::Label^ lblAge;
	public: System::Windows::Forms::Label^ lblPassword;
	public: System::Windows::Forms::Label^ lblSurname;
	public: System::Windows::Forms::Label^ lblLogin;
	public: System::Windows::Forms::Label^ lblName;
	public: OwnControls::Controls::Modern_Button^ btnRegistration;
	public: OwnControls::Controls::Modern_Button^ btnAuthorisation;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Registration::typeid));
			this->modern_PictureBox1 = (gcnew OwnControls::Controls::Modern_PictureBox());
			this->txtPassword = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtSex = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtSurname = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtLogin = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtAge = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtName = (gcnew OwnControls::Controls::Modern_TextBox());
			this->lblSex = (gcnew System::Windows::Forms::Label());
			this->lblAge = (gcnew System::Windows::Forms::Label());
			this->lblPassword = (gcnew System::Windows::Forms::Label());
			this->lblSurname = (gcnew System::Windows::Forms::Label());
			this->lblLogin = (gcnew System::Windows::Forms::Label());
			this->lblName = (gcnew System::Windows::Forms::Label());
			this->btnRegistration = (gcnew OwnControls::Controls::Modern_Button());
			this->btnAuthorisation = (gcnew OwnControls::Controls::Modern_Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->modern_PictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// modern_PictureBox1
			// 
			this->modern_PictureBox1->BorderCapStyle = System::Drawing::Drawing2D::DashCap::Flat;
			this->modern_PictureBox1->BorderColor = System::Drawing::Color::RoyalBlue;
			this->modern_PictureBox1->BorderColor2 = System::Drawing::Color::HotPink;
			this->modern_PictureBox1->BorderLineStyle = System::Drawing::Drawing2D::DashStyle::Solid;
			this->modern_PictureBox1->BorderSize = 2;
			this->modern_PictureBox1->GradientAngle = 50;
			this->modern_PictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"modern_PictureBox1.Image")));
			this->modern_PictureBox1->Location = System::Drawing::Point(12, 12);
			this->modern_PictureBox1->Name = L"modern_PictureBox1";
			this->modern_PictureBox1->Size = System::Drawing::Size(142, 142);
			this->modern_PictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->modern_PictureBox1->TabIndex = 23;
			this->modern_PictureBox1->TabStop = false;
			// 
			// txtPassword
			// 
			this->txtPassword->BackColor = System::Drawing::SystemColors::Control;
			this->txtPassword->BorderColor = System::Drawing::Color::MediumSlateBlue;
			this->txtPassword->BorderFocusColor = System::Drawing::Color::HotPink;
			this->txtPassword->BorderRadius = 0;
			this->txtPassword->BorderSize = 2;
			this->txtPassword->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtPassword->ForeColor = System::Drawing::Color::DimGray;
			this->txtPassword->Location = System::Drawing::Point(337, 163);
			this->txtPassword->Margin = System::Windows::Forms::Padding(4);
			this->txtPassword->MultiLine = false;
			this->txtPassword->Name = L"txtPassword";
			this->txtPassword->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtPassword->PasswordStyle = true;
			this->txtPassword->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtPassword->PlaceholderText = L"";
			this->txtPassword->Size = System::Drawing::Size(119, 27);
			this->txtPassword->TabIndex = 111;
			this->txtPassword->Texts = L"";
			this->txtPassword->UnderLineStyle = true;
			// 
			// txtSex
			// 
			this->txtSex->BackColor = System::Drawing::SystemColors::Control;
			this->txtSex->BorderColor = System::Drawing::Color::MediumSlateBlue;
			this->txtSex->BorderFocusColor = System::Drawing::Color::HotPink;
			this->txtSex->BorderRadius = 0;
			this->txtSex->BorderSize = 2;
			this->txtSex->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtSex->ForeColor = System::Drawing::Color::DimGray;
			this->txtSex->Location = System::Drawing::Point(336, 102);
			this->txtSex->Margin = System::Windows::Forms::Padding(4);
			this->txtSex->MultiLine = false;
			this->txtSex->Name = L"txtSex";
			this->txtSex->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSex->PasswordStyle = false;
			this->txtSex->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSex->PlaceholderText = L"";
			this->txtSex->Size = System::Drawing::Size(120, 27);
			this->txtSex->TabIndex = 109;
			this->txtSex->Texts = L"";
			this->txtSex->UnderLineStyle = true;
			// 
			// txtSurname
			// 
			this->txtSurname->BackColor = System::Drawing::SystemColors::Control;
			this->txtSurname->BorderColor = System::Drawing::Color::MediumSlateBlue;
			this->txtSurname->BorderFocusColor = System::Drawing::Color::HotPink;
			this->txtSurname->BorderRadius = 0;
			this->txtSurname->BorderSize = 2;
			this->txtSurname->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtSurname->ForeColor = System::Drawing::Color::DimGray;
			this->txtSurname->Location = System::Drawing::Point(336, 39);
			this->txtSurname->Margin = System::Windows::Forms::Padding(4);
			this->txtSurname->MultiLine = false;
			this->txtSurname->Name = L"txtSurname";
			this->txtSurname->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSurname->PasswordStyle = false;
			this->txtSurname->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSurname->PlaceholderText = L"";
			this->txtSurname->Size = System::Drawing::Size(120, 27);
			this->txtSurname->TabIndex = 107;
			this->txtSurname->Texts = L"";
			this->txtSurname->UnderLineStyle = true;
			// 
			// txtLogin
			// 
			this->txtLogin->BackColor = System::Drawing::SystemColors::Control;
			this->txtLogin->BorderColor = System::Drawing::Color::MediumSlateBlue;
			this->txtLogin->BorderFocusColor = System::Drawing::Color::HotPink;
			this->txtLogin->BorderRadius = 0;
			this->txtLogin->BorderSize = 2;
			this->txtLogin->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtLogin->ForeColor = System::Drawing::Color::DimGray;
			this->txtLogin->Location = System::Drawing::Point(209, 163);
			this->txtLogin->Margin = System::Windows::Forms::Padding(4);
			this->txtLogin->MultiLine = false;
			this->txtLogin->Name = L"txtLogin";
			this->txtLogin->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtLogin->PasswordStyle = false;
			this->txtLogin->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtLogin->PlaceholderText = L"";
			this->txtLogin->Size = System::Drawing::Size(119, 27);
			this->txtLogin->TabIndex = 110;
			this->txtLogin->Texts = L"";
			this->txtLogin->UnderLineStyle = true;
			// 
			// txtAge
			// 
			this->txtAge->BackColor = System::Drawing::SystemColors::Control;
			this->txtAge->BorderColor = System::Drawing::Color::MediumSlateBlue;
			this->txtAge->BorderFocusColor = System::Drawing::Color::HotPink;
			this->txtAge->BorderRadius = 0;
			this->txtAge->BorderSize = 2;
			this->txtAge->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtAge->ForeColor = System::Drawing::Color::DimGray;
			this->txtAge->Location = System::Drawing::Point(208, 102);
			this->txtAge->Margin = System::Windows::Forms::Padding(4);
			this->txtAge->MultiLine = false;
			this->txtAge->Name = L"txtAge";
			this->txtAge->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtAge->PasswordStyle = false;
			this->txtAge->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtAge->PlaceholderText = L"";
			this->txtAge->Size = System::Drawing::Size(120, 27);
			this->txtAge->TabIndex = 108;
			this->txtAge->Texts = L"";
			this->txtAge->UnderLineStyle = true;
			// 
			// txtName
			// 
			this->txtName->BackColor = System::Drawing::SystemColors::Control;
			this->txtName->BorderColor = System::Drawing::Color::MediumSlateBlue;
			this->txtName->BorderFocusColor = System::Drawing::Color::HotPink;
			this->txtName->BorderRadius = 0;
			this->txtName->BorderSize = 2;
			this->txtName->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtName->ForeColor = System::Drawing::Color::DimGray;
			this->txtName->Location = System::Drawing::Point(208, 39);
			this->txtName->Margin = System::Windows::Forms::Padding(4);
			this->txtName->MultiLine = false;
			this->txtName->Name = L"txtName";
			this->txtName->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtName->PasswordStyle = false;
			this->txtName->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtName->PlaceholderText = L"";
			this->txtName->Size = System::Drawing::Size(120, 27);
			this->txtName->TabIndex = 106;
			this->txtName->Texts = L"";
			this->txtName->UnderLineStyle = true;
			// 
			// lblSex
			// 
			this->lblSex->AutoSize = true;
			this->lblSex->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->lblSex->ForeColor = System::Drawing::Color::MediumPurple;
			this->lblSex->Location = System::Drawing::Point(333, 84);
			this->lblSex->Name = L"lblSex";
			this->lblSex->Size = System::Drawing::Size(33, 14);
			this->lblSex->TabIndex = 115;
			this->lblSex->Text = L"пол";
			// 
			// lblAge
			// 
			this->lblAge->AutoSize = true;
			this->lblAge->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->lblAge->ForeColor = System::Drawing::Color::MediumPurple;
			this->lblAge->Location = System::Drawing::Point(202, 84);
			this->lblAge->Name = L"lblAge";
			this->lblAge->Size = System::Drawing::Size(63, 14);
			this->lblAge->TabIndex = 114;
			this->lblAge->Text = L"возраст";
			// 
			// lblPassword
			// 
			this->lblPassword->AutoSize = true;
			this->lblPassword->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->lblPassword->ForeColor = System::Drawing::Color::MediumPurple;
			this->lblPassword->Location = System::Drawing::Point(334, 145);
			this->lblPassword->Name = L"lblPassword";
			this->lblPassword->Size = System::Drawing::Size(58, 14);
			this->lblPassword->TabIndex = 117;
			this->lblPassword->Text = L"пароль";
			// 
			// lblSurname
			// 
			this->lblSurname->AutoSize = true;
			this->lblSurname->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->lblSurname->ForeColor = System::Drawing::Color::MediumPurple;
			this->lblSurname->Location = System::Drawing::Point(334, 23);
			this->lblSurname->Name = L"lblSurname";
			this->lblSurname->Size = System::Drawing::Size(72, 14);
			this->lblSurname->TabIndex = 113;
			this->lblSurname->Text = L"Фамилия";
			// 
			// lblLogin
			// 
			this->lblLogin->AutoSize = true;
			this->lblLogin->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->lblLogin->ForeColor = System::Drawing::Color::MediumPurple;
			this->lblLogin->Location = System::Drawing::Point(203, 145);
			this->lblLogin->Name = L"lblLogin";
			this->lblLogin->Size = System::Drawing::Size(49, 14);
			this->lblLogin->TabIndex = 116;
			this->lblLogin->Text = L"Логин";
			// 
			// lblName
			// 
			this->lblName->AutoSize = true;
			this->lblName->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->lblName->ForeColor = System::Drawing::Color::MediumPurple;
			this->lblName->Location = System::Drawing::Point(203, 21);
			this->lblName->Name = L"lblName";
			this->lblName->Size = System::Drawing::Size(35, 14);
			this->lblName->TabIndex = 112;
			this->lblName->Text = L"Имя";
			// 
			// btnRegistration
			// 
			this->btnRegistration->BackColor = System::Drawing::Color::MediumPurple;
			this->btnRegistration->BackgroundColor = System::Drawing::Color::MediumPurple;
			this->btnRegistration->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnRegistration->BorderRadius = 20;
			this->btnRegistration->BorderSize = 0;
			this->btnRegistration->FlatAppearance->BorderSize = 0;
			this->btnRegistration->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnRegistration->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnRegistration->ForeColor = System::Drawing::Color::White;
			this->btnRegistration->Location = System::Drawing::Point(40, 250);
			this->btnRegistration->Name = L"btnRegistration";
			this->btnRegistration->Size = System::Drawing::Size(198, 61);
			this->btnRegistration->TabIndex = 118;
			this->btnRegistration->Text = L"Зарегистрироваться";
			this->btnRegistration->TextColor = System::Drawing::Color::White;
			this->btnRegistration->UseVisualStyleBackColor = false;
			this->btnRegistration->Click += gcnew System::EventHandler(this, &Registration::btnRegistration_Click);
			// 
			// btnAuthorisation
			// 
			this->btnAuthorisation->BackColor = System::Drawing::Color::MediumPurple;
			this->btnAuthorisation->BackgroundColor = System::Drawing::Color::MediumPurple;
			this->btnAuthorisation->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnAuthorisation->BorderRadius = 20;
			this->btnAuthorisation->BorderSize = 0;
			this->btnAuthorisation->FlatAppearance->BorderSize = 0;
			this->btnAuthorisation->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAuthorisation->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnAuthorisation->ForeColor = System::Drawing::Color::White;
			this->btnAuthorisation->Location = System::Drawing::Point(275, 250);
			this->btnAuthorisation->Name = L"btnAuthorisation";
			this->btnAuthorisation->Size = System::Drawing::Size(198, 61);
			this->btnAuthorisation->TabIndex = 119;
			this->btnAuthorisation->Text = L"Авторизоваться";
			this->btnAuthorisation->TextColor = System::Drawing::Color::White;
			this->btnAuthorisation->UseVisualStyleBackColor = false;
			this->btnAuthorisation->Click += gcnew System::EventHandler(this, &Registration::btnAuthorisation_Click);
			// 
			// Registration
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(504, 335);
			this->Controls->Add(this->btnRegistration);
			this->Controls->Add(this->btnAuthorisation);
			this->Controls->Add(this->txtPassword);
			this->Controls->Add(this->txtSex);
			this->Controls->Add(this->txtSurname);
			this->Controls->Add(this->txtLogin);
			this->Controls->Add(this->txtAge);
			this->Controls->Add(this->txtName);
			this->Controls->Add(this->lblSex);
			this->Controls->Add(this->lblAge);
			this->Controls->Add(this->lblPassword);
			this->Controls->Add(this->lblSurname);
			this->Controls->Add(this->lblLogin);
			this->Controls->Add(this->lblName);
			this->Controls->Add(this->modern_PictureBox1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Registration";
			this->Text = L"Регистрация";
			this->Load += gcnew System::EventHandler(this, &Registration::Registration_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->modern_PictureBox1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btnRegistration_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void btnAuthorisation_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Registration_Load(System::Object^ sender, System::EventArgs^ e);

	//for chnage application theme
	private: void ColorSet();

	private: int counter = 0;


};
}
