#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для AboutAuthor
	/// </summary>
	public ref class AboutAuthor : public System::Windows::Forms::Form
	{
	public:
		AboutAuthor(void)
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
		~AboutAuthor()
		{
			if (components)
			{
				delete components;
			}
		}
	private: OwnControls::Controls::Modern_PictureBox^ picBoxAuthorAvatar;
	protected:
	private: OwnControls::Controls::Modern_Button^ btnUnderstand;
	private: System::Windows::Forms::Label^ lblVersionName;
	private: System::Windows::Forms::Label^ lblSpecialName;
	private: System::Windows::Forms::Label^ lblGroupName;
	private: System::Windows::Forms::Label^ lblAuthorName;
	private: System::Windows::Forms::Label^ lblApplicationName;
	private: System::Windows::Forms::Label^ lblVersion;
	private: System::Windows::Forms::Label^ lblSpecial;
	private: System::Windows::Forms::Label^ lblGroup;
	private: System::Windows::Forms::Label^ lblAuthor;
	private: System::Windows::Forms::Label^ lblApplication;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(AboutAuthor::typeid));
			this->picBoxAuthorAvatar = (gcnew OwnControls::Controls::Modern_PictureBox());
			this->btnUnderstand = (gcnew OwnControls::Controls::Modern_Button());
			this->lblVersionName = (gcnew System::Windows::Forms::Label());
			this->lblSpecialName = (gcnew System::Windows::Forms::Label());
			this->lblGroupName = (gcnew System::Windows::Forms::Label());
			this->lblAuthorName = (gcnew System::Windows::Forms::Label());
			this->lblApplicationName = (gcnew System::Windows::Forms::Label());
			this->lblVersion = (gcnew System::Windows::Forms::Label());
			this->lblSpecial = (gcnew System::Windows::Forms::Label());
			this->lblGroup = (gcnew System::Windows::Forms::Label());
			this->lblAuthor = (gcnew System::Windows::Forms::Label());
			this->lblApplication = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picBoxAuthorAvatar))->BeginInit();
			this->SuspendLayout();
			// 
			// picBoxAuthorAvatar
			// 
			this->picBoxAuthorAvatar->BorderCapStyle = System::Drawing::Drawing2D::DashCap::Flat;
			this->picBoxAuthorAvatar->BorderColor = System::Drawing::Color::RoyalBlue;
			this->picBoxAuthorAvatar->BorderColor2 = System::Drawing::Color::HotPink;
			this->picBoxAuthorAvatar->BorderLineStyle = System::Drawing::Drawing2D::DashStyle::Solid;
			this->picBoxAuthorAvatar->BorderSize = 2;
			this->picBoxAuthorAvatar->GradientAngle = 50;
			this->picBoxAuthorAvatar->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"picBoxAuthorAvatar.Image")));
			this->picBoxAuthorAvatar->Location = System::Drawing::Point(297, 11);
			this->picBoxAuthorAvatar->Name = L"picBoxAuthorAvatar";
			this->picBoxAuthorAvatar->Size = System::Drawing::Size(120, 120);
			this->picBoxAuthorAvatar->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->picBoxAuthorAvatar->TabIndex = 31;
			this->picBoxAuthorAvatar->TabStop = false;
			// 
			// btnUnderstand
			// 
			this->btnUnderstand->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnUnderstand->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnUnderstand->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnUnderstand->BorderRadius = 10;
			this->btnUnderstand->BorderSize = 0;
			this->btnUnderstand->FlatAppearance->BorderSize = 0;
			this->btnUnderstand->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnUnderstand->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnUnderstand->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnUnderstand->Location = System::Drawing::Point(88, 144);
			this->btnUnderstand->Name = L"btnUnderstand";
			this->btnUnderstand->Size = System::Drawing::Size(239, 52);
			this->btnUnderstand->TabIndex = 30;
			this->btnUnderstand->Text = L"понятно";
			this->btnUnderstand->TextColor = System::Drawing::Color::Gainsboro;
			this->btnUnderstand->UseVisualStyleBackColor = false;
			this->btnUnderstand->Click += gcnew System::EventHandler(this, &AboutAuthor::btnUnderstand_Click);
			// 
			// lblVersionName
			// 
			this->lblVersionName->AutoSize = true;
			this->lblVersionName->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblVersionName->Location = System::Drawing::Point(146, 112);
			this->lblVersionName->Name = L"lblVersionName";
			this->lblVersionName->Size = System::Drawing::Size(43, 14);
			this->lblVersionName->TabIndex = 29;
			this->lblVersionName->Text = L"2.0.12";
			// 
			// lblSpecialName
			// 
			this->lblSpecialName->AutoSize = true;
			this->lblSpecialName->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblSpecialName->Location = System::Drawing::Point(146, 86);
			this->lblSpecialName->Name = L"lblSpecialName";
			this->lblSpecialName->Size = System::Drawing::Size(100, 14);
			this->lblSpecialName->TabIndex = 28;
			this->lblSpecialName->Text = L"программист";
			// 
			// lblGroupName
			// 
			this->lblGroupName->AutoSize = true;
			this->lblGroupName->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblGroupName->Location = System::Drawing::Point(146, 60);
			this->lblGroupName->Name = L"lblGroupName";
			this->lblGroupName->Size = System::Drawing::Size(50, 14);
			this->lblGroupName->TabIndex = 27;
			this->lblGroupName->Text = L"ист-21";
			// 
			// lblAuthorName
			// 
			this->lblAuthorName->AutoSize = true;
			this->lblAuthorName->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblAuthorName->Location = System::Drawing::Point(146, 35);
			this->lblAuthorName->Name = L"lblAuthorName";
			this->lblAuthorName->Size = System::Drawing::Size(96, 14);
			this->lblAuthorName->TabIndex = 26;
			this->lblAuthorName->Text = L"ilya borisov";
			// 
			// lblApplicationName
			// 
			this->lblApplicationName->AutoSize = true;
			this->lblApplicationName->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblApplicationName->Location = System::Drawing::Point(146, 11);
			this->lblApplicationName->Name = L"lblApplicationName";
			this->lblApplicationName->Size = System::Drawing::Size(93, 14);
			this->lblApplicationName->TabIndex = 25;
			this->lblApplicationName->Text = L"Union press";
			// 
			// lblVersion
			// 
			this->lblVersion->AutoSize = true;
			this->lblVersion->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblVersion->Location = System::Drawing::Point(12, 112);
			this->lblVersion->Name = L"lblVersion";
			this->lblVersion->Size = System::Drawing::Size(58, 14);
			this->lblVersion->TabIndex = 24;
			this->lblVersion->Text = L"версия";
			// 
			// lblSpecial
			// 
			this->lblSpecial->AutoSize = true;
			this->lblSpecial->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblSpecial->Location = System::Drawing::Point(12, 86);
			this->lblSpecial->Name = L"lblSpecial";
			this->lblSpecial->Size = System::Drawing::Size(116, 14);
			this->lblSpecial->TabIndex = 23;
			this->lblSpecial->Text = L"специальность";
			// 
			// lblGroup
			// 
			this->lblGroup->AutoSize = true;
			this->lblGroup->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblGroup->Location = System::Drawing::Point(12, 60);
			this->lblGroup->Name = L"lblGroup";
			this->lblGroup->Size = System::Drawing::Size(57, 14);
			this->lblGroup->TabIndex = 22;
			this->lblGroup->Text = L"группа";
			// 
			// lblAuthor
			// 
			this->lblAuthor->AutoSize = true;
			this->lblAuthor->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblAuthor->Location = System::Drawing::Point(12, 35);
			this->lblAuthor->Name = L"lblAuthor";
			this->lblAuthor->Size = System::Drawing::Size(48, 14);
			this->lblAuthor->TabIndex = 21;
			this->lblAuthor->Text = L"автор";
			// 
			// lblApplication
			// 
			this->lblApplication->AutoSize = true;
			this->lblApplication->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblApplication->Location = System::Drawing::Point(12, 11);
			this->lblApplication->Name = L"lblApplication";
			this->lblApplication->Size = System::Drawing::Size(96, 14);
			this->lblApplication->TabIndex = 20;
			this->lblApplication->Text = L"Приложение";
			// 
			// AboutAuthor
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(429, 206);
			this->Controls->Add(this->picBoxAuthorAvatar);
			this->Controls->Add(this->btnUnderstand);
			this->Controls->Add(this->lblVersionName);
			this->Controls->Add(this->lblSpecialName);
			this->Controls->Add(this->lblGroupName);
			this->Controls->Add(this->lblAuthorName);
			this->Controls->Add(this->lblApplicationName);
			this->Controls->Add(this->lblVersion);
			this->Controls->Add(this->lblSpecial);
			this->Controls->Add(this->lblGroup);
			this->Controls->Add(this->lblAuthor);
			this->Controls->Add(this->lblApplication);
			this->Name = L"AboutAuthor";
			this->Text = L"Его величество";
			this->Load += gcnew System::EventHandler(this, &AboutAuthor::AboutAuthor_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picBoxAuthorAvatar))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btnUnderstand_Click(System::Object^ sender, System::EventArgs^ e);
private: System::Void AboutAuthor_Load(System::Object^ sender, System::EventArgs^ e);
};
}
