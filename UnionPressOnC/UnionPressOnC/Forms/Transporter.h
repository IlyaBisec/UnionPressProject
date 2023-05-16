#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Transporter
	/// </summary>
	public ref class Transporter : public System::Windows::Forms::Form
	{
	public:
		Transporter(void)
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
		~Transporter()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TabControl^ tabControlTransporter;
	protected:
	private: System::Windows::Forms::TabPage^ pageMain;
	private: OwnControls::Controls::Modern_TextBox^ txtSearchTransporter;
	private: System::Windows::Forms::Button^ btnEditTransporter;
	private: System::Windows::Forms::Button^ btnSearchTransporter;
	private: System::Windows::Forms::DataGridView^ gridTransporter;
	private: System::Windows::Forms::Button^ btnAddTransporter;
	private: System::Windows::Forms::Label^ lblTitle;
	private: System::Windows::Forms::Button^ btnDelTransporter;
	private: System::Windows::Forms::Button^ btnLoadTransporter;
	private: System::Windows::Forms::Button^ btnExportTransporter;
	private: System::Windows::Forms::TabPage^ pageSettings;
	private: OwnControls::Controls::Modern_TextBox^ txtBeginDate;
	private: OwnControls::Controls::Modern_TextBox^ txtEndDate;
	private: System::Windows::Forms::Button^ btnCancelSettings;
	private: System::Windows::Forms::Button^ btnSaveSettings;
	private: System::Windows::Forms::Label^ lblEndDate;
	private: System::Windows::Forms::Label^ lblBeginDate;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Transporter::typeid));
			this->tabControlTransporter = (gcnew System::Windows::Forms::TabControl());
			this->pageMain = (gcnew System::Windows::Forms::TabPage());
			this->txtSearchTransporter = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnEditTransporter = (gcnew System::Windows::Forms::Button());
			this->btnSearchTransporter = (gcnew System::Windows::Forms::Button());
			this->gridTransporter = (gcnew System::Windows::Forms::DataGridView());
			this->btnAddTransporter = (gcnew System::Windows::Forms::Button());
			this->lblTitle = (gcnew System::Windows::Forms::Label());
			this->btnDelTransporter = (gcnew System::Windows::Forms::Button());
			this->btnLoadTransporter = (gcnew System::Windows::Forms::Button());
			this->btnExportTransporter = (gcnew System::Windows::Forms::Button());
			this->pageSettings = (gcnew System::Windows::Forms::TabPage());
			this->txtBeginDate = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtEndDate = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnCancelSettings = (gcnew System::Windows::Forms::Button());
			this->btnSaveSettings = (gcnew System::Windows::Forms::Button());
			this->lblEndDate = (gcnew System::Windows::Forms::Label());
			this->lblBeginDate = (gcnew System::Windows::Forms::Label());
			this->tabControlTransporter->SuspendLayout();
			this->pageMain->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridTransporter))->BeginInit();
			this->pageSettings->SuspendLayout();
			this->SuspendLayout();
			// 
			// tabControlTransporter
			// 
			this->tabControlTransporter->Controls->Add(this->pageMain);
			this->tabControlTransporter->Controls->Add(this->pageSettings);
			this->tabControlTransporter->Dock = System::Windows::Forms::DockStyle::Fill;
			this->tabControlTransporter->Location = System::Drawing::Point(0, 0);
			this->tabControlTransporter->Name = L"tabControlTransporter";
			this->tabControlTransporter->SelectedIndex = 0;
			this->tabControlTransporter->Size = System::Drawing::Size(769, 443);
			this->tabControlTransporter->TabIndex = 14;
			// 
			// pageMain
			// 
			this->pageMain->Controls->Add(this->txtSearchTransporter);
			this->pageMain->Controls->Add(this->btnEditTransporter);
			this->pageMain->Controls->Add(this->btnSearchTransporter);
			this->pageMain->Controls->Add(this->gridTransporter);
			this->pageMain->Controls->Add(this->btnAddTransporter);
			this->pageMain->Controls->Add(this->lblTitle);
			this->pageMain->Controls->Add(this->btnDelTransporter);
			this->pageMain->Controls->Add(this->btnLoadTransporter);
			this->pageMain->Controls->Add(this->btnExportTransporter);
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
			// txtSearchTransporter
			// 
			this->txtSearchTransporter->BackColor = System::Drawing::SystemColors::Window;
			this->txtSearchTransporter->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtSearchTransporter->BorderFocusColor = System::Drawing::Color::Red;
			this->txtSearchTransporter->BorderRadius = 0;
			this->txtSearchTransporter->BorderSize = 1;
			this->txtSearchTransporter->ForeColor = System::Drawing::Color::DimGray;
			this->txtSearchTransporter->Location = System::Drawing::Point(9, 35);
			this->txtSearchTransporter->Margin = System::Windows::Forms::Padding(4);
			this->txtSearchTransporter->MultiLine = false;
			this->txtSearchTransporter->Name = L"txtSearchTransporter";
			this->txtSearchTransporter->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSearchTransporter->PasswordStyle = false;
			this->txtSearchTransporter->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSearchTransporter->PlaceholderText = L"";
			this->txtSearchTransporter->Size = System::Drawing::Size(543, 27);
			this->txtSearchTransporter->TabIndex = 14;
			this->txtSearchTransporter->Texts = L"";
			this->txtSearchTransporter->UnderLineStyle = true;
			// 
			// btnEditTransporter
			// 
			this->btnEditTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnEditTransporter->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnEditTransporter->FlatAppearance->BorderSize = 0;
			this->btnEditTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnEditTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnEditTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnEditTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnEditTransporter->Location = System::Drawing::Point(570, 216);
			this->btnEditTransporter->Name = L"btnEditTransporter";
			this->btnEditTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnEditTransporter->Size = System::Drawing::Size(180, 55);
			this->btnEditTransporter->TabIndex = 10;
			this->btnEditTransporter->Text = L"Изменить";
			this->btnEditTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnEditTransporter->UseVisualStyleBackColor = false;
			// 
			// btnSearchTransporter
			// 
			this->btnSearchTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSearchTransporter->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnSearchTransporter->FlatAppearance->BorderSize = 0;
			this->btnSearchTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSearchTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSearchTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSearchTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSearchTransporter->Location = System::Drawing::Point(570, 33);
			this->btnSearchTransporter->Name = L"btnSearchTransporter";
			this->btnSearchTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSearchTransporter->Size = System::Drawing::Size(180, 55);
			this->btnSearchTransporter->TabIndex = 9;
			this->btnSearchTransporter->Text = L"Поиск";
			this->btnSearchTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSearchTransporter->UseVisualStyleBackColor = false;
			// 
			// gridTransporter
			// 
			this->gridTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left));
			this->gridTransporter->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->gridTransporter->Location = System::Drawing::Point(6, 66);
			this->gridTransporter->Name = L"gridTransporter";
			this->gridTransporter->Size = System::Drawing::Size(546, 335);
			this->gridTransporter->TabIndex = 0;
			// 
			// btnAddTransporter
			// 
			this->btnAddTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnAddTransporter->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAddTransporter->FlatAppearance->BorderSize = 0;
			this->btnAddTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAddTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAddTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnAddTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnAddTransporter->Location = System::Drawing::Point(570, 155);
			this->btnAddTransporter->Name = L"btnAddTransporter";
			this->btnAddTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnAddTransporter->Size = System::Drawing::Size(180, 55);
			this->btnAddTransporter->TabIndex = 2;
			this->btnAddTransporter->Text = L"Добавить";
			this->btnAddTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnAddTransporter->UseVisualStyleBackColor = false;
			// 
			// lblTitle
			// 
			this->lblTitle->AutoSize = true;
			this->lblTitle->Font = (gcnew System::Drawing::Font(L"Archive", 20, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblTitle->Location = System::Drawing::Point(1, 1);
			this->lblTitle->Name = L"lblTitle";
			this->lblTitle->Size = System::Drawing::Size(257, 30);
			this->lblTitle->TabIndex = 7;
			this->lblTitle->Text = L"поиск доставки:";
			// 
			// btnDelTransporter
			// 
			this->btnDelTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnDelTransporter->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDelTransporter->FlatAppearance->BorderSize = 0;
			this->btnDelTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDelTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnDelTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDelTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnDelTransporter->Location = System::Drawing::Point(570, 277);
			this->btnDelTransporter->Name = L"btnDelTransporter";
			this->btnDelTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnDelTransporter->Size = System::Drawing::Size(180, 55);
			this->btnDelTransporter->TabIndex = 4;
			this->btnDelTransporter->Text = L"Удалить";
			this->btnDelTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnDelTransporter->UseVisualStyleBackColor = false;
			// 
			// btnLoadTransporter
			// 
			this->btnLoadTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnLoadTransporter->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnLoadTransporter->FlatAppearance->BorderSize = 0;
			this->btnLoadTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnLoadTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnLoadTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnLoadTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnLoadTransporter->Location = System::Drawing::Point(570, 94);
			this->btnLoadTransporter->Name = L"btnLoadTransporter";
			this->btnLoadTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnLoadTransporter->Size = System::Drawing::Size(180, 55);
			this->btnLoadTransporter->TabIndex = 6;
			this->btnLoadTransporter->Text = L"Загрузить";
			this->btnLoadTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnLoadTransporter->UseVisualStyleBackColor = false;
			// 
			// btnExportTransporter
			// 
			this->btnExportTransporter->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnExportTransporter->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExportTransporter->FlatAppearance->BorderSize = 0;
			this->btnExportTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExportTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnExportTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnExportTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExportTransporter->Location = System::Drawing::Point(570, 338);
			this->btnExportTransporter->Name = L"btnExportTransporter";
			this->btnExportTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnExportTransporter->Size = System::Drawing::Size(180, 55);
			this->btnExportTransporter->TabIndex = 5;
			this->btnExportTransporter->Text = L"Экспорт";
			this->btnExportTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnExportTransporter->UseVisualStyleBackColor = false;
			// 
			// pageSettings
			// 
			this->pageSettings->Controls->Add(this->txtBeginDate);
			this->pageSettings->Controls->Add(this->txtEndDate);
			this->pageSettings->Controls->Add(this->btnCancelSettings);
			this->pageSettings->Controls->Add(this->btnSaveSettings);
			this->pageSettings->Controls->Add(this->lblEndDate);
			this->pageSettings->Controls->Add(this->lblBeginDate);
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
			// txtBeginDate
			// 
			this->txtBeginDate->BackColor = System::Drawing::SystemColors::Window;
			this->txtBeginDate->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtBeginDate->BorderFocusColor = System::Drawing::Color::Red;
			this->txtBeginDate->BorderRadius = 0;
			this->txtBeginDate->BorderSize = 1;
			this->txtBeginDate->ForeColor = System::Drawing::Color::DimGray;
			this->txtBeginDate->Location = System::Drawing::Point(219, 124);
			this->txtBeginDate->Margin = System::Windows::Forms::Padding(4);
			this->txtBeginDate->MultiLine = false;
			this->txtBeginDate->Name = L"txtBeginDate";
			this->txtBeginDate->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtBeginDate->PasswordStyle = false;
			this->txtBeginDate->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtBeginDate->PlaceholderText = L"";
			this->txtBeginDate->Size = System::Drawing::Size(169, 27);
			this->txtBeginDate->TabIndex = 0;
			this->txtBeginDate->Texts = L"";
			this->txtBeginDate->UnderLineStyle = true;
			// 
			// txtEndDate
			// 
			this->txtEndDate->BackColor = System::Drawing::SystemColors::Window;
			this->txtEndDate->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtEndDate->BorderFocusColor = System::Drawing::Color::Red;
			this->txtEndDate->BorderRadius = 0;
			this->txtEndDate->BorderSize = 1;
			this->txtEndDate->ForeColor = System::Drawing::Color::DimGray;
			this->txtEndDate->Location = System::Drawing::Point(422, 124);
			this->txtEndDate->Margin = System::Windows::Forms::Padding(4);
			this->txtEndDate->MultiLine = false;
			this->txtEndDate->Name = L"txtEndDate";
			this->txtEndDate->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtEndDate->PasswordStyle = false;
			this->txtEndDate->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtEndDate->PlaceholderText = L"";
			this->txtEndDate->Size = System::Drawing::Size(169, 27);
			this->txtEndDate->TabIndex = 1;
			this->txtEndDate->Texts = L"";
			this->txtEndDate->UnderLineStyle = true;
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
			this->btnCancelSettings->TabIndex = 3;
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
			this->btnSaveSettings->TabIndex = 2;
			this->btnSaveSettings->Text = L"Сохранить";
			this->btnSaveSettings->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSaveSettings->UseVisualStyleBackColor = false;
			// 
			// lblEndDate
			// 
			this->lblEndDate->AutoSize = true;
			this->lblEndDate->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblEndDate->Location = System::Drawing::Point(419, 89);
			this->lblEndDate->Name = L"lblEndDate";
			this->lblEndDate->Size = System::Drawing::Size(147, 18);
			this->lblEndDate->TabIndex = 4;
			this->lblEndDate->Text = L"дата окончания";
			// 
			// lblBeginDate
			// 
			this->lblBeginDate->AutoSize = true;
			this->lblBeginDate->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblBeginDate->Location = System::Drawing::Point(227, 89);
			this->lblBeginDate->Name = L"lblBeginDate";
			this->lblBeginDate->Size = System::Drawing::Size(115, 18);
			this->lblBeginDate->TabIndex = 0;
			this->lblBeginDate->Text = L"дата начала";
			// 
			// Transporter
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(769, 443);
			this->Controls->Add(this->tabControlTransporter);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Transporter";
			this->Text = L"Доставка";
			this->tabControlTransporter->ResumeLayout(false);
			this->pageMain->ResumeLayout(false);
			this->pageMain->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridTransporter))->EndInit();
			this->pageSettings->ResumeLayout(false);
			this->pageSettings->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}
