#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ Authorisation
	/// </summary>
	public ref class Authorisation : public System::Windows::Forms::Form
	{
	public:
		Authorisation(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~Authorisation()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label2;
	protected:
	private: System::Windows::Forms::Label^ label1;
	public: OwnControls::Controls::Modern_TextBox^ txtPassword;
	public: OwnControls::Controls::Modern_TextBox^ txtLogin;
	public: OwnControls::Controls::Modern_PictureBox^ modern_PictureBox1;
	public: OwnControls::Controls::Modern_Button^ btnAuthorisation;

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Authorisation::typeid));
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->txtPassword = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtLogin = (gcnew OwnControls::Controls::Modern_TextBox());
			this->modern_PictureBox1 = (gcnew OwnControls::Controls::Modern_PictureBox());
			this->btnAuthorisation = (gcnew OwnControls::Controls::Modern_Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->modern_PictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->label2->ForeColor = System::Drawing::Color::MediumPurple;
			this->label2->Location = System::Drawing::Point(191, 93);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(58, 14);
			this->label2->TabIndex = 11;
			this->label2->Text = L"ѕароль";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->label1->ForeColor = System::Drawing::Color::MediumPurple;
			this->label1->Location = System::Drawing::Point(191, 12);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(49, 14);
			this->label1->TabIndex = 10;
			this->label1->Text = L"Ћогин";
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
			this->txtPassword->ForeColor = System::Drawing::Color::Black;
			this->txtPassword->Location = System::Drawing::Point(194, 126);
			this->txtPassword->Margin = System::Windows::Forms::Padding(4);
			this->txtPassword->MultiLine = false;
			this->txtPassword->Name = L"txtPassword";
			this->txtPassword->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtPassword->PasswordStyle = true;
			this->txtPassword->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtPassword->PlaceholderText = L"";
			this->txtPassword->Size = System::Drawing::Size(212, 27);
			this->txtPassword->TabIndex = 9;
			this->txtPassword->Texts = L"";
			this->txtPassword->UnderLineStyle = true;
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
			this->txtLogin->ForeColor = System::Drawing::Color::Black;
			this->txtLogin->Location = System::Drawing::Point(194, 32);
			this->txtLogin->Margin = System::Windows::Forms::Padding(4);
			this->txtLogin->MultiLine = false;
			this->txtLogin->Name = L"txtLogin";
			this->txtLogin->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtLogin->PasswordStyle = false;
			this->txtLogin->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtLogin->PlaceholderText = L"";
			this->txtLogin->Size = System::Drawing::Size(212, 27);
			this->txtLogin->TabIndex = 8;
			this->txtLogin->Texts = L"";
			this->txtLogin->UnderLineStyle = true;
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
			this->modern_PictureBox1->TabIndex = 7;
			this->modern_PictureBox1->TabStop = false;
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
			this->btnAuthorisation->Location = System::Drawing::Point(126, 208);
			this->btnAuthorisation->Name = L"btnAuthorisation";
			this->btnAuthorisation->Size = System::Drawing::Size(198, 61);
			this->btnAuthorisation->TabIndex = 6;
			this->btnAuthorisation->Text = L"јвторизоватьс€";
			this->btnAuthorisation->TextColor = System::Drawing::Color::White;
			this->btnAuthorisation->UseVisualStyleBackColor = false;
			this->btnAuthorisation->Click += gcnew System::EventHandler(this, &Authorisation::btnAuthorisation_Click);
			// 
			// Authorisation
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(473, 292);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->txtPassword);
			this->Controls->Add(this->txtLogin);
			this->Controls->Add(this->modern_PictureBox1);
			this->Controls->Add(this->btnAuthorisation);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Authorisation";
			this->Text = L"јвторизаци€";
			this->Load += gcnew System::EventHandler(this, &Authorisation::Authorisation_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->modern_PictureBox1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void Authorisation_Load(System::Object^ sender, System::EventArgs^ e);
	private: System::Void btnAuthorisation_Click(System::Object^ sender, System::EventArgs^ e);

	public: int counter = 0;

	private: void ColorSet();

};
}
