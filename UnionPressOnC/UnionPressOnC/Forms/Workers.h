#pragma once
#include "Classes/Logger.h"
#include "Views/IWorkersView.h"
#include "Repositories/CWorkersRepository.h"
#include "Exports/WordExport.h"
#include "Exports/ExcelExport.h"

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Workers
	/// </summary>
	public ref class Workers : public System::Windows::Forms::Form
	{
	public:
		Workers(void)
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
		~Workers()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TabControl^ tabControlW;
	protected:
	private: System::Windows::Forms::TabPage^ pageMain;
	private: OwnControls::Controls::Modern_TextBox^ txtW;
	private: System::Windows::Forms::Button^ btnEdit;
	public: System::Windows::Forms::Button^ btnSearch;
	private:
	private: System::Windows::Forms::DataGridView^ gridW;
	public:
	public: System::Windows::Forms::Button^ btnAddW;
	private:
	private: System::Windows::Forms::Label^ lblTitle;
	public:
	public: System::Windows::Forms::Button^ btnDelW;
	private:
	public: System::Windows::Forms::Button^ btnLoadW;
	public: System::Windows::Forms::Button^ btnExportW;
	private: System::Windows::Forms::TabPage^ pageSettings;
	public:
	private: OwnControls::Controls::Modern_TextBox^ txtSurname;
	private: OwnControls::Controls::Modern_TextBox^ txtName;
	private: OwnControls::Controls::Modern_TextBox^ txtNumber;
	private: OwnControls::Controls::Modern_TextBox^ txtFatherName;
	private: OwnControls::Controls::Modern_TextBox^ txtSpecial;
	public: System::Windows::Forms::Button^ btnCancelSettings;
	private:
	public: System::Windows::Forms::Button^ btnSaveSettings;
	private: System::Windows::Forms::Label^ lblNumber;
	public:
	private: System::Windows::Forms::Label^ lblSpecial;
	private: System::Windows::Forms::Label^ lblFatherName;
	private: System::Windows::Forms::Label^ lblName;
	private: System::Windows::Forms::Label^ lblSurname;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Workers::typeid));
			this->tabControlW = (gcnew System::Windows::Forms::TabControl());
			this->pageMain = (gcnew System::Windows::Forms::TabPage());
			this->txtW = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnEdit = (gcnew System::Windows::Forms::Button());
			this->btnSearch = (gcnew System::Windows::Forms::Button());
			this->gridW = (gcnew System::Windows::Forms::DataGridView());
			this->btnAddW = (gcnew System::Windows::Forms::Button());
			this->lblTitle = (gcnew System::Windows::Forms::Label());
			this->btnDelW = (gcnew System::Windows::Forms::Button());
			this->btnLoadW = (gcnew System::Windows::Forms::Button());
			this->btnExportW = (gcnew System::Windows::Forms::Button());
			this->pageSettings = (gcnew System::Windows::Forms::TabPage());
			this->txtSurname = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtName = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtNumber = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtFatherName = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtSpecial = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnCancelSettings = (gcnew System::Windows::Forms::Button());
			this->btnSaveSettings = (gcnew System::Windows::Forms::Button());
			this->lblNumber = (gcnew System::Windows::Forms::Label());
			this->lblSpecial = (gcnew System::Windows::Forms::Label());
			this->lblFatherName = (gcnew System::Windows::Forms::Label());
			this->lblName = (gcnew System::Windows::Forms::Label());
			this->lblSurname = (gcnew System::Windows::Forms::Label());
			this->tabControlW->SuspendLayout();
			this->pageMain->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridW))->BeginInit();
			this->pageSettings->SuspendLayout();
			this->SuspendLayout();
			// 
			// tabControlW
			// 
			this->tabControlW->Controls->Add(this->pageMain);
			this->tabControlW->Controls->Add(this->pageSettings);
			this->tabControlW->Dock = System::Windows::Forms::DockStyle::Fill;
			this->tabControlW->Location = System::Drawing::Point(0, 0);
			this->tabControlW->Name = L"tabControlW";
			this->tabControlW->SelectedIndex = 0;
			this->tabControlW->Size = System::Drawing::Size(769, 444);
			this->tabControlW->TabIndex = 12;
			// 
			// pageMain
			// 
			this->pageMain->BackColor = System::Drawing::Color::Transparent;
			this->pageMain->Controls->Add(this->txtW);
			this->pageMain->Controls->Add(this->btnEdit);
			this->pageMain->Controls->Add(this->btnSearch);
			this->pageMain->Controls->Add(this->gridW);
			this->pageMain->Controls->Add(this->btnAddW);
			this->pageMain->Controls->Add(this->lblTitle);
			this->pageMain->Controls->Add(this->btnDelW);
			this->pageMain->Controls->Add(this->btnLoadW);
			this->pageMain->Controls->Add(this->btnExportW);
			this->pageMain->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->pageMain->Location = System::Drawing::Point(4, 22);
			this->pageMain->Name = L"pageMain";
			this->pageMain->Padding = System::Windows::Forms::Padding(3);
			this->pageMain->Size = System::Drawing::Size(761, 418);
			this->pageMain->TabIndex = 0;
			this->pageMain->Text = L"Главная";
			// 
			// txtW
			// 
			this->txtW->BackColor = System::Drawing::SystemColors::Window;
			this->txtW->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtW->BorderFocusColor = System::Drawing::Color::Red;
			this->txtW->BorderRadius = 0;
			this->txtW->BorderSize = 1;
			this->txtW->ForeColor = System::Drawing::Color::DimGray;
			this->txtW->Location = System::Drawing::Point(9, 32);
			this->txtW->Margin = System::Windows::Forms::Padding(4);
			this->txtW->MultiLine = false;
			this->txtW->Name = L"txtW";
			this->txtW->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtW->PasswordStyle = false;
			this->txtW->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtW->PlaceholderText = L"";
			this->txtW->Size = System::Drawing::Size(543, 27);
			this->txtW->TabIndex = 11;
			this->txtW->Texts = L"";
			this->txtW->UnderLineStyle = true;
			// 
			// btnEdit
			// 
			this->btnEdit->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnEdit->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnEdit->FlatAppearance->BorderSize = 0;
			this->btnEdit->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnEdit->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnEdit->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnEdit->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnEdit->Location = System::Drawing::Point(570, 216);
			this->btnEdit->Name = L"btnEdit";
			this->btnEdit->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnEdit->Size = System::Drawing::Size(180, 55);
			this->btnEdit->TabIndex = 10;
			this->btnEdit->Text = L"Изменить";
			this->btnEdit->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnEdit->UseVisualStyleBackColor = false;
			// 
			// btnSearch
			// 
			this->btnSearch->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSearch->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnSearch->FlatAppearance->BorderSize = 0;
			this->btnSearch->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSearch->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSearch->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSearch->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSearch->Location = System::Drawing::Point(570, 33);
			this->btnSearch->Name = L"btnSearch";
			this->btnSearch->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSearch->Size = System::Drawing::Size(180, 55);
			this->btnSearch->TabIndex = 9;
			this->btnSearch->Text = L"Поиск";
			this->btnSearch->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSearch->UseVisualStyleBackColor = false;
			// 
			// gridW
			// 
			this->gridW->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left));
			this->gridW->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->gridW->Location = System::Drawing::Point(6, 66);
			this->gridW->Name = L"gridW";
			this->gridW->Size = System::Drawing::Size(546, 336);
			this->gridW->TabIndex = 0;
			// 
			// btnAddW
			// 
			this->btnAddW->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnAddW->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAddW->FlatAppearance->BorderSize = 0;
			this->btnAddW->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAddW->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAddW->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnAddW->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnAddW->Location = System::Drawing::Point(570, 155);
			this->btnAddW->Name = L"btnAddW";
			this->btnAddW->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnAddW->Size = System::Drawing::Size(180, 55);
			this->btnAddW->TabIndex = 2;
			this->btnAddW->Text = L"Добавить";
			this->btnAddW->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnAddW->UseVisualStyleBackColor = false;
			// 
			// lblTitle
			// 
			this->lblTitle->AutoSize = true;
			this->lblTitle->Font = (gcnew System::Drawing::Font(L"Archive", 20, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblTitle->Location = System::Drawing::Point(1, 1);
			this->lblTitle->Name = L"lblTitle";
			this->lblTitle->Size = System::Drawing::Size(273, 30);
			this->lblTitle->TabIndex = 7;
			this->lblTitle->Text = L"поиск работника:";
			// 
			// btnDelW
			// 
			this->btnDelW->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnDelW->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDelW->FlatAppearance->BorderSize = 0;
			this->btnDelW->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDelW->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnDelW->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDelW->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnDelW->Location = System::Drawing::Point(570, 277);
			this->btnDelW->Name = L"btnDelW";
			this->btnDelW->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnDelW->Size = System::Drawing::Size(180, 55);
			this->btnDelW->TabIndex = 4;
			this->btnDelW->Text = L"Удалить";
			this->btnDelW->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnDelW->UseVisualStyleBackColor = false;
			// 
			// btnLoadW
			// 
			this->btnLoadW->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnLoadW->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnLoadW->FlatAppearance->BorderSize = 0;
			this->btnLoadW->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnLoadW->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnLoadW->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnLoadW->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnLoadW->Location = System::Drawing::Point(570, 94);
			this->btnLoadW->Name = L"btnLoadW";
			this->btnLoadW->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnLoadW->Size = System::Drawing::Size(180, 55);
			this->btnLoadW->TabIndex = 6;
			this->btnLoadW->Text = L"Загрузить";
			this->btnLoadW->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnLoadW->UseVisualStyleBackColor = false;
			// 
			// btnExportW
			// 
			this->btnExportW->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnExportW->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExportW->FlatAppearance->BorderSize = 0;
			this->btnExportW->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExportW->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnExportW->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnExportW->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExportW->Location = System::Drawing::Point(570, 338);
			this->btnExportW->Name = L"btnExportW";
			this->btnExportW->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnExportW->Size = System::Drawing::Size(180, 55);
			this->btnExportW->TabIndex = 5;
			this->btnExportW->Text = L"Экспорт";
			this->btnExportW->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnExportW->UseVisualStyleBackColor = false;
			// 
			// pageSettings
			// 
			this->pageSettings->Controls->Add(this->txtSurname);
			this->pageSettings->Controls->Add(this->txtName);
			this->pageSettings->Controls->Add(this->txtNumber);
			this->pageSettings->Controls->Add(this->txtFatherName);
			this->pageSettings->Controls->Add(this->txtSpecial);
			this->pageSettings->Controls->Add(this->btnCancelSettings);
			this->pageSettings->Controls->Add(this->btnSaveSettings);
			this->pageSettings->Controls->Add(this->lblNumber);
			this->pageSettings->Controls->Add(this->lblSpecial);
			this->pageSettings->Controls->Add(this->lblFatherName);
			this->pageSettings->Controls->Add(this->lblName);
			this->pageSettings->Controls->Add(this->lblSurname);
			this->pageSettings->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->pageSettings->Location = System::Drawing::Point(4, 22);
			this->pageSettings->Name = L"pageSettings";
			this->pageSettings->Padding = System::Windows::Forms::Padding(3);
			this->pageSettings->Size = System::Drawing::Size(761, 418);
			this->pageSettings->TabIndex = 1;
			this->pageSettings->Text = L"Настройки";
			this->pageSettings->UseVisualStyleBackColor = true;
			// 
			// txtSurname
			// 
			this->txtSurname->BackColor = System::Drawing::SystemColors::Window;
			this->txtSurname->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtSurname->BorderFocusColor = System::Drawing::Color::Red;
			this->txtSurname->BorderRadius = 0;
			this->txtSurname->BorderSize = 1;
			this->txtSurname->ForeColor = System::Drawing::Color::DimGray;
			this->txtSurname->Location = System::Drawing::Point(219, 30);
			this->txtSurname->Margin = System::Windows::Forms::Padding(4);
			this->txtSurname->MultiLine = false;
			this->txtSurname->Name = L"txtSurname";
			this->txtSurname->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSurname->PasswordStyle = false;
			this->txtSurname->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSurname->PlaceholderText = L"";
			this->txtSurname->Size = System::Drawing::Size(167, 27);
			this->txtSurname->TabIndex = 0;
			this->txtSurname->Texts = L"";
			this->txtSurname->UnderLineStyle = true;
			// 
			// txtName
			// 
			this->txtName->BackColor = System::Drawing::SystemColors::Window;
			this->txtName->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtName->BorderFocusColor = System::Drawing::Color::Red;
			this->txtName->BorderRadius = 0;
			this->txtName->BorderSize = 1;
			this->txtName->ForeColor = System::Drawing::Color::DimGray;
			this->txtName->Location = System::Drawing::Point(421, 30);
			this->txtName->Margin = System::Windows::Forms::Padding(4);
			this->txtName->MultiLine = false;
			this->txtName->Name = L"txtName";
			this->txtName->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtName->PasswordStyle = false;
			this->txtName->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtName->PlaceholderText = L"";
			this->txtName->Size = System::Drawing::Size(167, 27);
			this->txtName->TabIndex = 1;
			this->txtName->Texts = L"";
			this->txtName->UnderLineStyle = true;
			// 
			// txtNumber
			// 
			this->txtNumber->BackColor = System::Drawing::SystemColors::Window;
			this->txtNumber->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtNumber->BorderFocusColor = System::Drawing::Color::Red;
			this->txtNumber->BorderRadius = 0;
			this->txtNumber->BorderSize = 1;
			this->txtNumber->ForeColor = System::Drawing::Color::DimGray;
			this->txtNumber->Location = System::Drawing::Point(219, 189);
			this->txtNumber->Margin = System::Windows::Forms::Padding(4);
			this->txtNumber->MultiLine = false;
			this->txtNumber->Name = L"txtNumber";
			this->txtNumber->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtNumber->PasswordStyle = false;
			this->txtNumber->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtNumber->PlaceholderText = L"";
			this->txtNumber->Size = System::Drawing::Size(167, 27);
			this->txtNumber->TabIndex = 4;
			this->txtNumber->Texts = L"";
			this->txtNumber->UnderLineStyle = true;
			// 
			// txtFatherName
			// 
			this->txtFatherName->BackColor = System::Drawing::SystemColors::Window;
			this->txtFatherName->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtFatherName->BorderFocusColor = System::Drawing::Color::Red;
			this->txtFatherName->BorderRadius = 0;
			this->txtFatherName->BorderSize = 1;
			this->txtFatherName->ForeColor = System::Drawing::Color::DimGray;
			this->txtFatherName->Location = System::Drawing::Point(219, 108);
			this->txtFatherName->Margin = System::Windows::Forms::Padding(4);
			this->txtFatherName->MultiLine = false;
			this->txtFatherName->Name = L"txtFatherName";
			this->txtFatherName->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtFatherName->PasswordStyle = false;
			this->txtFatherName->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtFatherName->PlaceholderText = L"";
			this->txtFatherName->Size = System::Drawing::Size(167, 27);
			this->txtFatherName->TabIndex = 2;
			this->txtFatherName->Texts = L"";
			this->txtFatherName->UnderLineStyle = true;
			// 
			// txtSpecial
			// 
			this->txtSpecial->BackColor = System::Drawing::SystemColors::Window;
			this->txtSpecial->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtSpecial->BorderFocusColor = System::Drawing::Color::Red;
			this->txtSpecial->BorderRadius = 0;
			this->txtSpecial->BorderSize = 1;
			this->txtSpecial->ForeColor = System::Drawing::Color::DimGray;
			this->txtSpecial->Location = System::Drawing::Point(421, 108);
			this->txtSpecial->Margin = System::Windows::Forms::Padding(4);
			this->txtSpecial->MultiLine = false;
			this->txtSpecial->Name = L"txtSpecial";
			this->txtSpecial->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSpecial->PasswordStyle = false;
			this->txtSpecial->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSpecial->PlaceholderText = L"";
			this->txtSpecial->Size = System::Drawing::Size(167, 27);
			this->txtSpecial->TabIndex = 3;
			this->txtSpecial->Texts = L"";
			this->txtSpecial->UnderLineStyle = true;
			// 
			// btnCancelSettings
			// 
			this->btnCancelSettings->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnCancelSettings->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(51)),
				static_cast<System::Int32>(static_cast<System::Byte>(51)), static_cast<System::Int32>(static_cast<System::Byte>(70)));
			this->btnCancelSettings->FlatAppearance->BorderSize = 0;
			this->btnCancelSettings->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnCancelSettings->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnCancelSettings->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnCancelSettings->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnCancelSettings->Location = System::Drawing::Point(422, 263);
			this->btnCancelSettings->Name = L"btnCancelSettings";
			this->btnCancelSettings->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnCancelSettings->Size = System::Drawing::Size(180, 70);
			this->btnCancelSettings->TabIndex = 6;
			this->btnCancelSettings->Text = L"Назад";
			this->btnCancelSettings->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnCancelSettings->UseVisualStyleBackColor = false;
			// 
			// btnSaveSettings
			// 
			this->btnSaveSettings->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSaveSettings->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(51)), static_cast<System::Int32>(static_cast<System::Byte>(51)),
				static_cast<System::Int32>(static_cast<System::Byte>(70)));
			this->btnSaveSettings->FlatAppearance->BorderSize = 0;
			this->btnSaveSettings->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSaveSettings->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSaveSettings->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSaveSettings->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSaveSettings->Location = System::Drawing::Point(219, 263);
			this->btnSaveSettings->Name = L"btnSaveSettings";
			this->btnSaveSettings->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSaveSettings->Size = System::Drawing::Size(180, 70);
			this->btnSaveSettings->TabIndex = 5;
			this->btnSaveSettings->Text = L"Сохранить";
			this->btnSaveSettings->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSaveSettings->UseVisualStyleBackColor = false;
			// 
			// lblNumber
			// 
			this->lblNumber->AutoSize = true;
			this->lblNumber->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblNumber->Location = System::Drawing::Point(216, 153);
			this->lblNumber->Name = L"lblNumber";
			this->lblNumber->Size = System::Drawing::Size(82, 18);
			this->lblNumber->TabIndex = 8;
			this->lblNumber->Text = L"Телефон";
			// 
			// lblSpecial
			// 
			this->lblSpecial->AutoSize = true;
			this->lblSpecial->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblSpecial->Location = System::Drawing::Point(418, 73);
			this->lblSpecial->Name = L"lblSpecial";
			this->lblSpecial->Size = System::Drawing::Size(142, 18);
			this->lblSpecial->TabIndex = 6;
			this->lblSpecial->Text = L"Специальность";
			// 
			// lblFatherName
			// 
			this->lblFatherName->AutoSize = true;
			this->lblFatherName->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblFatherName->Location = System::Drawing::Point(216, 73);
			this->lblFatherName->Name = L"lblFatherName";
			this->lblFatherName->Size = System::Drawing::Size(88, 18);
			this->lblFatherName->TabIndex = 4;
			this->lblFatherName->Text = L"Отчество";
			// 
			// lblName
			// 
			this->lblName->AutoSize = true;
			this->lblName->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblName->Location = System::Drawing::Point(419, 8);
			this->lblName->Name = L"lblName";
			this->lblName->Size = System::Drawing::Size(42, 18);
			this->lblName->TabIndex = 2;
			this->lblName->Text = L"имя";
			// 
			// lblSurname
			// 
			this->lblSurname->AutoSize = true;
			this->lblSurname->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblSurname->Location = System::Drawing::Point(216, 6);
			this->lblSurname->Name = L"lblSurname";
			this->lblSurname->Size = System::Drawing::Size(87, 18);
			this->lblSurname->TabIndex = 0;
			this->lblSurname->Text = L"Фамилия";
			// 
			// Workers
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(769, 444);
			this->Controls->Add(this->tabControlW);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Workers";
			this->Text = L"Сотрудники";
			this->Load += gcnew System::EventHandler(this, &Workers::Workers_Load);
			this->tabControlW->ResumeLayout(false);
			this->pageMain->ResumeLayout(false);
			this->pageMain->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridW))->EndInit();
			this->pageSettings->ResumeLayout(false);
			this->pageSettings->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Workers_Load(System::Object^ sender, System::EventArgs^ e) {
		Logger logger;
		logger.Log("Открытие формы", "Workers.cs", "Workers", "568");
	}
	public: void SeWorkersListBindingSource(BindingSource^ wList)
	{
		gridW->DataSource = wList;
	}

		  //private: void AssociateAndRaiseViewEvents()
		  //{
		  //	Logger logger;
		  //	//Поиск
		  //	btnSearchPeriod.Click += delegate{ SearchDataEvent ? .Invoke(this, EventArgs.Empty); };
		  //	txtPeriod->KeyDown += (s, e) =>
		  //	{	
		  //		if (e.KeyCode == Keys.Enter)
		  //			SearchDataEvent ? .Invoke(this, EventArgs.Empty);

		  //		logger.Log("Поиск", "PeriodForm.cs", "btnSearchPeriod", "160");

		  //	};
		  //	//Добавить
		  //	btnAddPeriod.Click += delegate
		  //	{
		  //		counter++; counterAdd++;
		  //		Properties.Settings.Default.CountBtnClick = counter;
		  //		Properties.Settings.Default.CounterAdd = counterAdd;
		  //		AddNewDataEvent ? .Invoke(this, EventArgs.Empty);
		  //		tabControlPeriod.TabPages.Remove(pageMain);
		  //		tabControlPeriod.TabPages.Add(pageSettings);
		  //		pageSettings.Text = "Добавление нового периодического издания";

		  //		logger.Log("Добавление", "PeriodForm.cs", "btnAddPeriod", "174");
		  //	};
		  //	//Изменить
		  //	btnEditPeriod.Click += delegate
		  //	{
		  //		counter++; counterEdit++;
		  //		Properties.Settings.Default.CountBtnClick = counter;
		  //		Properties.Settings.Default.CounterEdit = counterEdit;
		  //		EditDataEvent ? .Invoke(this, EventArgs.Empty);
		  //		tabControlPeriod.TabPages.Remove(pageMain);
		  //		tabControlPeriod.TabPages.Add(pageSettings);
		  //		pageSettings.Text = "Изменение периодического издания";

		  //		logger.Log("Редактирование", "PeriodForm.cs", "btnEditPeriod", "188");
		  //	};
		  //	//Сохранить
		  //	btnSaveSettings.Click += delegate
		  //	{
		  //		counter++; counterSave++;
		  //		Properties.Settings.Default.CountBtnClick = counter;
		  //		Properties.Settings.Default.CounterSave = counterSave;
		  //		SaveDataEvent ? .Invoke(this, EventArgs.Empty);
		  //		if (isSuccessful)
		  //		{
		  //			tabControlPeriod.TabPages.Remove(pageSettings);
		  //			tabControlPeriod.TabPages.Add(pageMain);
		  //		}
		  //		MessageBox.Show(Message);


		  //		logger.Log("Сохранение", "PeriodForm.cs", "btnSaveSettings", "201");
		  //	};
		  //	//Отмена
		  //	btnCancelSettings.Click += delegate
		  //	{
		  //		counter++; counterDelete++;
		  //		Properties.Settings.Default.CountBtnClick = counter;
		  //		Properties.Settings.Default.CounterDelete = counterDelete;
		  //		counter++; counterBack++;
		  //		Properties.Settings.Default.CountBtnClick = counter;
		  //		Properties.Settings.Default.CounterBack = counterBack;
		  //		CancelEvent ? .Invoke(this, EventArgs.Empty);
		  //		tabControlPeriod.TabPages.Remove(pageSettings);
		  //		tabControlPeriod.TabPages.Add(pageMain);

		  //		logger.Log("Отмена", "PeriodForm.cs", "btnCancelSettings", "218");
		  //	};
		  //	//Удалить
		  //	btnDelPeriod.Click += delegate
		  //	{
		  //		var result = MessageBox.Show("удалить выбранное периодическое издание?", "Внимание",
		  //			MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		  //		if (result == DialogResult.Yes)
		  //		{
		  //			DeleteDataEvent ? .Invoke(this, EventArgs.Empty);
		  //			MessageBox.Show(Message);
		  //		}
		  //		logger.Log("Удаление", "PeriodForm.cs", "btnDelPeriod", "233");
		  //	};

		  //}

	private: void btnLoadWorkers_Click(Object sender, EventArgs e)
	{

		IWorkersView wdView = this;
		string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
		IWorkersRepository wRepository = gcnew CPeriodRepository(sqlConnectionString);

		Logger logger;
		logger.Log("Загрузка из бд", "Workers.cs", "Workers", "247");
	}

	private: void btnExportWorkers_Click(Object sender, EventArgs e)
	{
		ExportContextMenu.Show();


		Logger logger;
		logger.Log("Экспорт", "Workers.cs", "Workers", "261");
	}

	private: void ExpMenuItemExcel_Click(Object sender, EventArgs e)
	{
		ExcelExport excelExport;
		excelExport.excelExport(gridW);

		Logger logger;
		logger.Log("Экспорт в Excel", "Workers.cs", "ExpMenuItemExcel", "272");
	}

	private: void ExpMenuItemWord_Click(Object sender, EventArgs e)
	{
		SaveFileDialog^ save = gcnew SaveFileDialog();
		WordExport wordExport;

		save->Filter = "Word документы (*.doc)|*.doc";
		save->FileName = "";

		if (save->ShowDialog())
			wordExport.wordExport(gridW, save->FileName);

		Logger logger;
		logger.Log("Экспорт в Word", "Workers.cs", "ExpMenuItemWord", "281");
	}

		   private:
			   String message;
			   bool successful;
			   bool isEdit;

};
}
