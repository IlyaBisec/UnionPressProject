#pragma once
#include "Classes/Logger.h"
#include "Exports/ExcelExport.h"
#include "Exports/WordExport.h"

using namespace UnionPressOnC;

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для PeriodPress
	/// </summary>
	public ref class PeriodPress : public System::Windows::Forms::Form
	{
	public:
		PeriodPress(void)
		{
			InitializeComponent();
			//AssociateAndRaiseViewEvents();
			tabControlPeriod->TabPages->Remove(pageSettings);
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~PeriodPress()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TabControl^ tabControlPeriod;
	protected:
	private: System::Windows::Forms::TabPage^ pageMain;
	public: OwnControls::Controls::Modern_TextBox^ txtPeriod;
	public: System::Windows::Forms::Button^ btnEditPeriod;
	public: System::Windows::Forms::Button^ btnSearchPeriod;
	public: System::Windows::Forms::DataGridView^ gridPeriod;
	public: System::Windows::Forms::Button^ btnAddPeriod;
	private: System::Windows::Forms::Label^ lblTitle;
	public: System::Windows::Forms::Button^ btnDelPeriod;
	public: System::Windows::Forms::Button^ btnLoadPeriod;
	public: System::Windows::Forms::Button^ btnExportPeriod;
	private: System::Windows::Forms::TabPage^ pageSettings;
	public: OwnControls::Controls::Modern_TextBox^ txtChoiceTransp;
	public: OwnControls::Controls::Modern_TextBox^ txtSell;
	public: OwnControls::Controls::Modern_TextBox^ txtPopularity;
	public: OwnControls::Controls::Modern_TextBox^ txtSrok;
	public: System::Windows::Forms::Button^ btnCancelSettings;
	public : System::Windows::Forms::Button^ btnSaveSettings;
	private: System::Windows::Forms::Label^ lblPopularity;
	private: System::Windows::Forms::Label^ lblChoiceTransp;
	private: System::Windows::Forms::Label^ lblSell;
	private: System::Windows::Forms::Label^ lblSrok;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(PeriodPress::typeid));
			this->tabControlPeriod = (gcnew System::Windows::Forms::TabControl());
			this->pageMain = (gcnew System::Windows::Forms::TabPage());
			this->txtPeriod = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnEditPeriod = (gcnew System::Windows::Forms::Button());
			this->btnSearchPeriod = (gcnew System::Windows::Forms::Button());
			this->gridPeriod = (gcnew System::Windows::Forms::DataGridView());
			this->btnAddPeriod = (gcnew System::Windows::Forms::Button());
			this->lblTitle = (gcnew System::Windows::Forms::Label());
			this->btnDelPeriod = (gcnew System::Windows::Forms::Button());
			this->btnLoadPeriod = (gcnew System::Windows::Forms::Button());
			this->btnExportPeriod = (gcnew System::Windows::Forms::Button());
			this->pageSettings = (gcnew System::Windows::Forms::TabPage());
			this->txtChoiceTransp = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtSell = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtPopularity = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtSrok = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnCancelSettings = (gcnew System::Windows::Forms::Button());
			this->btnSaveSettings = (gcnew System::Windows::Forms::Button());
			this->lblPopularity = (gcnew System::Windows::Forms::Label());
			this->lblChoiceTransp = (gcnew System::Windows::Forms::Label());
			this->lblSell = (gcnew System::Windows::Forms::Label());
			this->lblSrok = (gcnew System::Windows::Forms::Label());
			this->tabControlPeriod->SuspendLayout();
			this->pageMain->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridPeriod))->BeginInit();
			this->pageSettings->SuspendLayout();
			this->SuspendLayout();
			// 
			// tabControlPeriod
			// 
			this->tabControlPeriod->Controls->Add(this->pageMain);
			this->tabControlPeriod->Controls->Add(this->pageSettings);
			this->tabControlPeriod->Dock = System::Windows::Forms::DockStyle::Fill;
			this->tabControlPeriod->Location = System::Drawing::Point(0, 0);
			this->tabControlPeriod->Name = L"tabControlPeriod";
			this->tabControlPeriod->SelectedIndex = 0;
			this->tabControlPeriod->Size = System::Drawing::Size(769, 443);
			this->tabControlPeriod->TabIndex = 14;
			// 
			// pageMain
			// 
			this->pageMain->Controls->Add(this->txtPeriod);
			this->pageMain->Controls->Add(this->btnEditPeriod);
			this->pageMain->Controls->Add(this->btnSearchPeriod);
			this->pageMain->Controls->Add(this->gridPeriod);
			this->pageMain->Controls->Add(this->btnAddPeriod);
			this->pageMain->Controls->Add(this->lblTitle);
			this->pageMain->Controls->Add(this->btnDelPeriod);
			this->pageMain->Controls->Add(this->btnLoadPeriod);
			this->pageMain->Controls->Add(this->btnExportPeriod);
			this->pageMain->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->pageMain->Location = System::Drawing::Point(4, 22);
			this->pageMain->Name = L"pageMain";
			this->pageMain->Padding = System::Windows::Forms::Padding(3);
			this->pageMain->Size = System::Drawing::Size(761, 417);
			this->pageMain->TabIndex = 0;
			this->pageMain->Text = L"Главная";
			this->pageMain->UseVisualStyleBackColor = true;
			// 
			// txtPeriod
			// 
			this->txtPeriod->BackColor = System::Drawing::SystemColors::Window;
			this->txtPeriod->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtPeriod->BorderFocusColor = System::Drawing::Color::Red;
			this->txtPeriod->BorderRadius = 0;
			this->txtPeriod->BorderSize = 1;
			this->txtPeriod->ForeColor = System::Drawing::Color::DimGray;
			this->txtPeriod->Location = System::Drawing::Point(6, 35);
			this->txtPeriod->Margin = System::Windows::Forms::Padding(4);
			this->txtPeriod->MultiLine = false;
			this->txtPeriod->Name = L"txtPeriod";
			this->txtPeriod->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtPeriod->PasswordStyle = false;
			this->txtPeriod->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtPeriod->PlaceholderText = L"";
			this->txtPeriod->Size = System::Drawing::Size(546, 27);
			this->txtPeriod->TabIndex = 14;
			this->txtPeriod->Texts = L"";
			this->txtPeriod->UnderLineStyle = true;
			// 
			// btnEditPeriod
			// 
			this->btnEditPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnEditPeriod->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnEditPeriod->FlatAppearance->BorderSize = 0;
			this->btnEditPeriod->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnEditPeriod->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnEditPeriod->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnEditPeriod->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnEditPeriod->Location = System::Drawing::Point(570, 216);
			this->btnEditPeriod->Name = L"btnEditPeriod";
			this->btnEditPeriod->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnEditPeriod->Size = System::Drawing::Size(180, 55);
			this->btnEditPeriod->TabIndex = 10;
			this->btnEditPeriod->Text = L"Изменить";
			this->btnEditPeriod->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnEditPeriod->UseVisualStyleBackColor = false;
			// 
			// btnSearchPeriod
			// 
			this->btnSearchPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSearchPeriod->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnSearchPeriod->FlatAppearance->BorderSize = 0;
			this->btnSearchPeriod->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSearchPeriod->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSearchPeriod->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSearchPeriod->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSearchPeriod->Location = System::Drawing::Point(570, 33);
			this->btnSearchPeriod->Name = L"btnSearchPeriod";
			this->btnSearchPeriod->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSearchPeriod->Size = System::Drawing::Size(180, 55);
			this->btnSearchPeriod->TabIndex = 9;
			this->btnSearchPeriod->Text = L"Поиск";
			this->btnSearchPeriod->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSearchPeriod->UseVisualStyleBackColor = false;
			// 
			// gridPeriod
			// 
			this->gridPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left));
			this->gridPeriod->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->gridPeriod->Location = System::Drawing::Point(6, 66);
			this->gridPeriod->Name = L"gridPeriod";
			this->gridPeriod->Size = System::Drawing::Size(546, 335);
			this->gridPeriod->TabIndex = 0;
			// 
			// btnAddPeriod
			// 
			this->btnAddPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnAddPeriod->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAddPeriod->FlatAppearance->BorderSize = 0;
			this->btnAddPeriod->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAddPeriod->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAddPeriod->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnAddPeriod->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnAddPeriod->Location = System::Drawing::Point(570, 155);
			this->btnAddPeriod->Name = L"btnAddPeriod";
			this->btnAddPeriod->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnAddPeriod->Size = System::Drawing::Size(180, 55);
			this->btnAddPeriod->TabIndex = 2;
			this->btnAddPeriod->Text = L"Добавить";
			this->btnAddPeriod->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnAddPeriod->UseVisualStyleBackColor = false;
			// 
			// lblTitle
			// 
			this->lblTitle->AutoSize = true;
			this->lblTitle->Font = (gcnew System::Drawing::Font(L"Archive", 20, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblTitle->Location = System::Drawing::Point(1, 1);
			this->lblTitle->Name = L"lblTitle";
			this->lblTitle->Size = System::Drawing::Size(377, 30);
			this->lblTitle->TabIndex = 7;
			this->lblTitle->Text = L"поиск периодич. печати:";
			// 
			// btnDelPeriod
			// 
			this->btnDelPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnDelPeriod->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDelPeriod->FlatAppearance->BorderSize = 0;
			this->btnDelPeriod->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDelPeriod->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnDelPeriod->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDelPeriod->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnDelPeriod->Location = System::Drawing::Point(570, 277);
			this->btnDelPeriod->Name = L"btnDelPeriod";
			this->btnDelPeriod->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnDelPeriod->Size = System::Drawing::Size(180, 55);
			this->btnDelPeriod->TabIndex = 4;
			this->btnDelPeriod->Text = L"Удалить";
			this->btnDelPeriod->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnDelPeriod->UseVisualStyleBackColor = false;
			// 
			// btnLoadPeriod
			// 
			this->btnLoadPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnLoadPeriod->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnLoadPeriod->FlatAppearance->BorderSize = 0;
			this->btnLoadPeriod->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnLoadPeriod->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnLoadPeriod->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnLoadPeriod->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnLoadPeriod->Location = System::Drawing::Point(570, 94);
			this->btnLoadPeriod->Name = L"btnLoadPeriod";
			this->btnLoadPeriod->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnLoadPeriod->Size = System::Drawing::Size(180, 55);
			this->btnLoadPeriod->TabIndex = 6;
			this->btnLoadPeriod->Text = L"Загрузить";
			this->btnLoadPeriod->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnLoadPeriod->UseVisualStyleBackColor = false;
			// 
			// btnExportPeriod
			// 
			this->btnExportPeriod->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnExportPeriod->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExportPeriod->FlatAppearance->BorderSize = 0;
			this->btnExportPeriod->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExportPeriod->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnExportPeriod->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnExportPeriod->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExportPeriod->Location = System::Drawing::Point(570, 338);
			this->btnExportPeriod->Name = L"btnExportPeriod";
			this->btnExportPeriod->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnExportPeriod->Size = System::Drawing::Size(180, 55);
			this->btnExportPeriod->TabIndex = 5;
			this->btnExportPeriod->Text = L"Экспорт";
			this->btnExportPeriod->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnExportPeriod->UseVisualStyleBackColor = false;
			// 
			// pageSettings
			// 
			this->pageSettings->Controls->Add(this->txtChoiceTransp);
			this->pageSettings->Controls->Add(this->txtSell);
			this->pageSettings->Controls->Add(this->txtPopularity);
			this->pageSettings->Controls->Add(this->txtSrok);
			this->pageSettings->Controls->Add(this->btnCancelSettings);
			this->pageSettings->Controls->Add(this->btnSaveSettings);
			this->pageSettings->Controls->Add(this->lblPopularity);
			this->pageSettings->Controls->Add(this->lblChoiceTransp);
			this->pageSettings->Controls->Add(this->lblSell);
			this->pageSettings->Controls->Add(this->lblSrok);
			this->pageSettings->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->pageSettings->Location = System::Drawing::Point(4, 22);
			this->pageSettings->Name = L"pageSettings";
			this->pageSettings->Padding = System::Windows::Forms::Padding(3);
			this->pageSettings->Size = System::Drawing::Size(761, 417);
			this->pageSettings->TabIndex = 1;
			this->pageSettings->Text = L"Настройки";
			this->pageSettings->UseVisualStyleBackColor = true;
			// 
			// txtChoiceTransp
			// 
			this->txtChoiceTransp->BackColor = System::Drawing::SystemColors::Window;
			this->txtChoiceTransp->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtChoiceTransp->BorderFocusColor = System::Drawing::Color::Red;
			this->txtChoiceTransp->BorderRadius = 0;
			this->txtChoiceTransp->BorderSize = 1;
			this->txtChoiceTransp->ForeColor = System::Drawing::Color::DimGray;
			this->txtChoiceTransp->Location = System::Drawing::Point(219, 137);
			this->txtChoiceTransp->Margin = System::Windows::Forms::Padding(4);
			this->txtChoiceTransp->MultiLine = false;
			this->txtChoiceTransp->Name = L"txtChoiceTransp";
			this->txtChoiceTransp->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtChoiceTransp->PasswordStyle = false;
			this->txtChoiceTransp->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtChoiceTransp->PlaceholderText = L"";
			this->txtChoiceTransp->Size = System::Drawing::Size(167, 27);
			this->txtChoiceTransp->TabIndex = 2;
			this->txtChoiceTransp->Texts = L"";
			this->txtChoiceTransp->UnderLineStyle = true;
			// 
			// txtSell
			// 
			this->txtSell->BackColor = System::Drawing::SystemColors::Window;
			this->txtSell->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtSell->BorderFocusColor = System::Drawing::Color::Red;
			this->txtSell->BorderRadius = 0;
			this->txtSell->BorderSize = 1;
			this->txtSell->ForeColor = System::Drawing::Color::DimGray;
			this->txtSell->Location = System::Drawing::Point(421, 60);
			this->txtSell->Margin = System::Windows::Forms::Padding(4);
			this->txtSell->MultiLine = false;
			this->txtSell->Name = L"txtSell";
			this->txtSell->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSell->PasswordStyle = false;
			this->txtSell->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSell->PlaceholderText = L"";
			this->txtSell->Size = System::Drawing::Size(167, 27);
			this->txtSell->TabIndex = 1;
			this->txtSell->Texts = L"";
			this->txtSell->UnderLineStyle = true;
			// 
			// txtPopularity
			// 
			this->txtPopularity->BackColor = System::Drawing::SystemColors::Window;
			this->txtPopularity->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtPopularity->BorderFocusColor = System::Drawing::Color::Red;
			this->txtPopularity->BorderRadius = 0;
			this->txtPopularity->BorderSize = 1;
			this->txtPopularity->ForeColor = System::Drawing::Color::DimGray;
			this->txtPopularity->Location = System::Drawing::Point(421, 137);
			this->txtPopularity->Margin = System::Windows::Forms::Padding(4);
			this->txtPopularity->MultiLine = false;
			this->txtPopularity->Name = L"txtPopularity";
			this->txtPopularity->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtPopularity->PasswordStyle = false;
			this->txtPopularity->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtPopularity->PlaceholderText = L"";
			this->txtPopularity->Size = System::Drawing::Size(167, 27);
			this->txtPopularity->TabIndex = 3;
			this->txtPopularity->Texts = L"";
			this->txtPopularity->UnderLineStyle = true;
			// 
			// txtSrok
			// 
			this->txtSrok->BackColor = System::Drawing::SystemColors::Window;
			this->txtSrok->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtSrok->BorderFocusColor = System::Drawing::Color::Red;
			this->txtSrok->BorderRadius = 0;
			this->txtSrok->BorderSize = 1;
			this->txtSrok->ForeColor = System::Drawing::Color::DimGray;
			this->txtSrok->Location = System::Drawing::Point(219, 60);
			this->txtSrok->Margin = System::Windows::Forms::Padding(4);
			this->txtSrok->MultiLine = false;
			this->txtSrok->Name = L"txtSrok";
			this->txtSrok->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSrok->PasswordStyle = false;
			this->txtSrok->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSrok->PlaceholderText = L"";
			this->txtSrok->Size = System::Drawing::Size(167, 27);
			this->txtSrok->TabIndex = 0;
			this->txtSrok->Texts = L"";
			this->txtSrok->UnderLineStyle = true;
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
			this->btnCancelSettings->TabIndex = 5;
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
			this->btnSaveSettings->TabIndex = 4;
			this->btnSaveSettings->Text = L"Сохранить";
			this->btnSaveSettings->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSaveSettings->UseVisualStyleBackColor = false;
			// 
			// lblPopularity
			// 
			this->lblPopularity->AutoSize = true;
			this->lblPopularity->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblPopularity->Location = System::Drawing::Point(418, 102);
			this->lblPopularity->Name = L"lblPopularity";
			this->lblPopularity->Size = System::Drawing::Size(132, 18);
			this->lblPopularity->TabIndex = 6;
			this->lblPopularity->Text = L"популярность";
			// 
			// lblChoiceTransp
			// 
			this->lblChoiceTransp->AutoSize = true;
			this->lblChoiceTransp->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblChoiceTransp->Location = System::Drawing::Point(216, 102);
			this->lblChoiceTransp->Name = L"lblChoiceTransp";
			this->lblChoiceTransp->Size = System::Drawing::Size(156, 18);
			this->lblChoiceTransp->TabIndex = 4;
			this->lblChoiceTransp->Text = L"способ доставки";
			// 
			// lblSell
			// 
			this->lblSell->AutoSize = true;
			this->lblSell->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblSell->Location = System::Drawing::Point(419, 37);
			this->lblSell->Name = L"lblSell";
			this->lblSell->Size = System::Drawing::Size(99, 18);
			this->lblSell->TabIndex = 2;
			this->lblSell->Text = L"стоимость";
			// 
			// lblSrok
			// 
			this->lblSrok->AutoSize = true;
			this->lblSrok->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblSrok->Location = System::Drawing::Point(216, 35);
			this->lblSrok->Name = L"lblSrok";
			this->lblSrok->Size = System::Drawing::Size(137, 18);
			this->lblSrok->TabIndex = 0;
			this->lblSrok->Text = L"Срок подписки";
			// 
			// PeriodPress
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(769, 443);
			this->Controls->Add(this->tabControlPeriod);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"PeriodPress";
			this->Text = L"Периодические издания";
			this->Load += gcnew System::EventHandler(this, &PeriodPress::PeriodPress_Load);
			this->tabControlPeriod->ResumeLayout(false);
			this->pageMain->ResumeLayout(false);
			this->pageMain->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridPeriod))->EndInit();
			this->pageSettings->ResumeLayout(false);
			this->pageSettings->PerformLayout();
			this->ResumeLayout(false);

		}

#pragma endregion


		private:
			string periodSrokSubscribe();
			String message;
			bool successful;
			bool isEdit;

			private: int counter = 0, searchCount = 0,
				counterLoad = 0, counterAdd = 0,
				counterEdit = 0, counterDelete = 0,
				counterSave = 0, counterBack = 0,
				counterExport = 0;




	private: System::Void PeriodPress_Load(System::Object^ sender, System::EventArgs^ e) {

		Logger logger;
		logger.Log("Открытие формы", "PeriodForm.cs", "PeriodPress", "92");
	}
	public: void SetPeriodListBindingSource(BindingSource^ periodList)
	{
		gridPeriod->DataSource = periodList;
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

	private: void btnLoadPeriod_Click(Object sender, EventArgs e)
	{
		
		IPeriodView periodView = this;
		string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
		IPeriodRepository periodRepository = gcnew CPeriodRepository(sqlConnectionString);

		Logger logger;
		logger.Log("Загрузка из бд", "PeriodForm.cs", "btnLoadPeriod", "247");
	}

	private: void btnExportPeriod_Click(Object sender, EventArgs e)
	{
		ExportContextMenu.Show();


		Logger logger;
		logger.Log("Экспорт", "PeriodForm.cs", "btnExportPeriod", "261");
	}

	private: void ExpMenuItemExcel_Click(Object sender, EventArgs e)
	{
		ExcelExport excelExport;
		excelExport.excelExport(gridPeriod);

		Logger logger;
		logger.Log("Экспорт в Excel", "PeriodForm.cs", "ExpMenuItemExcel", "272");
	}

	private: void ExpMenuItemWord_Click(Object sender, EventArgs e)
	{
		SaveFileDialog^ save = gcnew SaveFileDialog();
		WordExport wordExport;

		save->Filter = "Word документы (*.doc)|*.doc";
		save->FileName = "";

		if (save->ShowDialog())
			wordExport.wordExport(gridPeriod, save->FileName);

		Logger logger;
		logger.Log("Экспорт в Word", "PeriodForm.cs", "ExpMenuItemWord", "281");
	}


};
}
