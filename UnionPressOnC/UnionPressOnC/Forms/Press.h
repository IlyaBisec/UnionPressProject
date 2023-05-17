#pragma once
#include "Classes/Logger.h"
#include "Exports/ExcelExport.h"
#include "Exports/WordExport.h"

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Press
	/// </summary>
	public ref class Press : public System::Windows::Forms::Form
	{
	public:
		Press(void)
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
		~Press()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TabControl^ tabControlPress;
	protected:
	private: System::Windows::Forms::TabPage^ pageMain;
	private: OwnControls::Controls::Modern_TextBox^ txtPress;
	private: System::Windows::Forms::Button^ btnEditPress;
	private: System::Windows::Forms::Button^ btnSearchPress;
	public: System::Windows::Forms::DataGridView^ gridPress;
	private:
	private: System::Windows::Forms::Button^ btnAddPress;
	public:
	private: System::Windows::Forms::Label^ lblTitle;
	private: System::Windows::Forms::Button^ btnDelPress;
	private: System::Windows::Forms::Button^ btnLoadPress;
	private: System::Windows::Forms::Button^ btnExportPress;
	private: System::Windows::Forms::TabPage^ pageSettings;
	private: OwnControls::Controls::Modern_TextBox^ txtPeriodOutput;
	private: OwnControls::Controls::Modern_TextBox^ txtCaption;
	private: System::Windows::Forms::Button^ btnCancelSettings;
	private: System::Windows::Forms::Button^ btnSaveSettings;
	private: System::Windows::Forms::Label^ lblPeriodOutput;
	private: System::Windows::Forms::Label^ lblCaption;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Press::typeid));
			this->tabControlPress = (gcnew System::Windows::Forms::TabControl());
			this->pageMain = (gcnew System::Windows::Forms::TabPage());
			this->txtPress = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnEditPress = (gcnew System::Windows::Forms::Button());
			this->btnSearchPress = (gcnew System::Windows::Forms::Button());
			this->gridPress = (gcnew System::Windows::Forms::DataGridView());
			this->btnAddPress = (gcnew System::Windows::Forms::Button());
			this->lblTitle = (gcnew System::Windows::Forms::Label());
			this->btnDelPress = (gcnew System::Windows::Forms::Button());
			this->btnLoadPress = (gcnew System::Windows::Forms::Button());
			this->btnExportPress = (gcnew System::Windows::Forms::Button());
			this->pageSettings = (gcnew System::Windows::Forms::TabPage());
			this->txtPeriodOutput = (gcnew OwnControls::Controls::Modern_TextBox());
			this->txtCaption = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnCancelSettings = (gcnew System::Windows::Forms::Button());
			this->btnSaveSettings = (gcnew System::Windows::Forms::Button());
			this->lblPeriodOutput = (gcnew System::Windows::Forms::Label());
			this->lblCaption = (gcnew System::Windows::Forms::Label());
			this->tabControlPress->SuspendLayout();
			this->pageMain->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridPress))->BeginInit();
			this->pageSettings->SuspendLayout();
			this->SuspendLayout();
			// 
			// tabControlPress
			// 
			this->tabControlPress->Controls->Add(this->pageMain);
			this->tabControlPress->Controls->Add(this->pageSettings);
			this->tabControlPress->Dock = System::Windows::Forms::DockStyle::Fill;
			this->tabControlPress->Location = System::Drawing::Point(0, 0);
			this->tabControlPress->Name = L"tabControlPress";
			this->tabControlPress->SelectedIndex = 0;
			this->tabControlPress->Size = System::Drawing::Size(769, 443);
			this->tabControlPress->TabIndex = 14;
			// 
			// pageMain
			// 
			this->pageMain->Controls->Add(this->txtPress);
			this->pageMain->Controls->Add(this->btnEditPress);
			this->pageMain->Controls->Add(this->btnSearchPress);
			this->pageMain->Controls->Add(this->gridPress);
			this->pageMain->Controls->Add(this->btnAddPress);
			this->pageMain->Controls->Add(this->lblTitle);
			this->pageMain->Controls->Add(this->btnDelPress);
			this->pageMain->Controls->Add(this->btnLoadPress);
			this->pageMain->Controls->Add(this->btnExportPress);
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
			// txtPress
			// 
			this->txtPress->BackColor = System::Drawing::SystemColors::Window;
			this->txtPress->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtPress->BorderFocusColor = System::Drawing::Color::Red;
			this->txtPress->BorderRadius = 0;
			this->txtPress->BorderSize = 1;
			this->txtPress->ForeColor = System::Drawing::Color::DimGray;
			this->txtPress->Location = System::Drawing::Point(6, 35);
			this->txtPress->Margin = System::Windows::Forms::Padding(4);
			this->txtPress->MultiLine = false;
			this->txtPress->Name = L"txtPress";
			this->txtPress->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtPress->PasswordStyle = false;
			this->txtPress->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtPress->PlaceholderText = L"";
			this->txtPress->Size = System::Drawing::Size(543, 27);
			this->txtPress->TabIndex = 15;
			this->txtPress->Texts = L"";
			this->txtPress->UnderLineStyle = true;
			// 
			// btnEditPress
			// 
			this->btnEditPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnEditPress->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnEditPress->FlatAppearance->BorderSize = 0;
			this->btnEditPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnEditPress->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnEditPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnEditPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnEditPress->Location = System::Drawing::Point(570, 216);
			this->btnEditPress->Name = L"btnEditPress";
			this->btnEditPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnEditPress->Size = System::Drawing::Size(180, 55);
			this->btnEditPress->TabIndex = 10;
			this->btnEditPress->Text = L"Изменить";
			this->btnEditPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnEditPress->UseVisualStyleBackColor = false;
			// 
			// btnSearchPress
			// 
			this->btnSearchPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSearchPress->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnSearchPress->FlatAppearance->BorderSize = 0;
			this->btnSearchPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSearchPress->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSearchPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSearchPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSearchPress->Location = System::Drawing::Point(570, 33);
			this->btnSearchPress->Name = L"btnSearchPress";
			this->btnSearchPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSearchPress->Size = System::Drawing::Size(180, 55);
			this->btnSearchPress->TabIndex = 9;
			this->btnSearchPress->Text = L"Поиск";
			this->btnSearchPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSearchPress->UseVisualStyleBackColor = false;
			// 
			// gridPress
			// 
			this->gridPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left));
			this->gridPress->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->gridPress->Location = System::Drawing::Point(6, 66);
			this->gridPress->Name = L"gridPress";
			this->gridPress->Size = System::Drawing::Size(546, 335);
			this->gridPress->TabIndex = 0;
			// 
			// btnAddPress
			// 
			this->btnAddPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnAddPress->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAddPress->FlatAppearance->BorderSize = 0;
			this->btnAddPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAddPress->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAddPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnAddPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnAddPress->Location = System::Drawing::Point(570, 155);
			this->btnAddPress->Name = L"btnAddPress";
			this->btnAddPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnAddPress->Size = System::Drawing::Size(180, 55);
			this->btnAddPress->TabIndex = 2;
			this->btnAddPress->Text = L"Добавить";
			this->btnAddPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnAddPress->UseVisualStyleBackColor = false;
			// 
			// lblTitle
			// 
			this->lblTitle->AutoSize = true;
			this->lblTitle->Font = (gcnew System::Drawing::Font(L"Archive", 20, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblTitle->Location = System::Drawing::Point(1, 1);
			this->lblTitle->Name = L"lblTitle";
			this->lblTitle->Size = System::Drawing::Size(220, 30);
			this->lblTitle->TabIndex = 7;
			this->lblTitle->Text = L"поиск печати:";
			// 
			// btnDelPress
			// 
			this->btnDelPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnDelPress->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDelPress->FlatAppearance->BorderSize = 0;
			this->btnDelPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDelPress->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnDelPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDelPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnDelPress->Location = System::Drawing::Point(570, 277);
			this->btnDelPress->Name = L"btnDelPress";
			this->btnDelPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnDelPress->Size = System::Drawing::Size(180, 55);
			this->btnDelPress->TabIndex = 4;
			this->btnDelPress->Text = L"Удалить";
			this->btnDelPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnDelPress->UseVisualStyleBackColor = false;
			// 
			// btnLoadPress
			// 
			this->btnLoadPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnLoadPress->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnLoadPress->FlatAppearance->BorderSize = 0;
			this->btnLoadPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnLoadPress->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnLoadPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnLoadPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnLoadPress->Location = System::Drawing::Point(570, 94);
			this->btnLoadPress->Name = L"btnLoadPress";
			this->btnLoadPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnLoadPress->Size = System::Drawing::Size(180, 55);
			this->btnLoadPress->TabIndex = 6;
			this->btnLoadPress->Text = L"Загрузить";
			this->btnLoadPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnLoadPress->UseVisualStyleBackColor = false;
			// 
			// btnExportPress
			// 
			this->btnExportPress->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnExportPress->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExportPress->FlatAppearance->BorderSize = 0;
			this->btnExportPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExportPress->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnExportPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnExportPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExportPress->Location = System::Drawing::Point(570, 338);
			this->btnExportPress->Name = L"btnExportPress";
			this->btnExportPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnExportPress->Size = System::Drawing::Size(180, 55);
			this->btnExportPress->TabIndex = 5;
			this->btnExportPress->Text = L"Экспорт";
			this->btnExportPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnExportPress->UseVisualStyleBackColor = false;
			// 
			// pageSettings
			// 
			this->pageSettings->Controls->Add(this->txtPeriodOutput);
			this->pageSettings->Controls->Add(this->txtCaption);
			this->pageSettings->Controls->Add(this->btnCancelSettings);
			this->pageSettings->Controls->Add(this->btnSaveSettings);
			this->pageSettings->Controls->Add(this->lblPeriodOutput);
			this->pageSettings->Controls->Add(this->lblCaption);
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
			// txtPeriodOutput
			// 
			this->txtPeriodOutput->BackColor = System::Drawing::SystemColors::Window;
			this->txtPeriodOutput->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtPeriodOutput->BorderFocusColor = System::Drawing::Color::Red;
			this->txtPeriodOutput->BorderRadius = 0;
			this->txtPeriodOutput->BorderSize = 1;
			this->txtPeriodOutput->ForeColor = System::Drawing::Color::DimGray;
			this->txtPeriodOutput->Location = System::Drawing::Point(315, 171);
			this->txtPeriodOutput->Margin = System::Windows::Forms::Padding(4);
			this->txtPeriodOutput->MultiLine = false;
			this->txtPeriodOutput->Name = L"txtPeriodOutput";
			this->txtPeriodOutput->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtPeriodOutput->PasswordStyle = false;
			this->txtPeriodOutput->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtPeriodOutput->PlaceholderText = L"";
			this->txtPeriodOutput->Size = System::Drawing::Size(167, 27);
			this->txtPeriodOutput->TabIndex = 1;
			this->txtPeriodOutput->Texts = L"";
			this->txtPeriodOutput->UnderLineStyle = true;
			// 
			// txtCaption
			// 
			this->txtCaption->BackColor = System::Drawing::SystemColors::Window;
			this->txtCaption->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtCaption->BorderFocusColor = System::Drawing::Color::Red;
			this->txtCaption->BorderRadius = 0;
			this->txtCaption->BorderSize = 1;
			this->txtCaption->ForeColor = System::Drawing::Color::DimGray;
			this->txtCaption->Location = System::Drawing::Point(315, 75);
			this->txtCaption->Margin = System::Windows::Forms::Padding(4);
			this->txtCaption->MultiLine = false;
			this->txtCaption->Name = L"txtCaption";
			this->txtCaption->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtCaption->PasswordStyle = false;
			this->txtCaption->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtCaption->PlaceholderText = L"";
			this->txtCaption->Size = System::Drawing::Size(167, 27);
			this->txtCaption->TabIndex = 0;
			this->txtCaption->Texts = L"";
			this->txtCaption->UnderLineStyle = true;
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
			// lblPeriodOutput
			// 
			this->lblPeriodOutput->AutoSize = true;
			this->lblPeriodOutput->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblPeriodOutput->Location = System::Drawing::Point(329, 119);
			this->lblPeriodOutput->Name = L"lblPeriodOutput";
			this->lblPeriodOutput->Size = System::Drawing::Size(141, 18);
			this->lblPeriodOutput->TabIndex = 2;
			this->lblPeriodOutput->Text = L"период выхода";
			// 
			// lblCaption
			// 
			this->lblCaption->AutoSize = true;
			this->lblCaption->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblCaption->Location = System::Drawing::Point(334, 38);
			this->lblCaption->Name = L"lblCaption";
			this->lblCaption->Size = System::Drawing::Size(136, 18);
			this->lblCaption->TabIndex = 0;
			this->lblCaption->Text = L"наименование";
			// 
			// Press
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(769, 443);
			this->Controls->Add(this->tabControlPress);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Press";
			this->Text = L"Издания";
			this->Load += gcnew System::EventHandler(this, &Press::Press_Load);
			this->tabControlPress->ResumeLayout(false);
			this->pageMain->ResumeLayout(false);
			this->pageMain->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridPress))->EndInit();
			this->pageSettings->ResumeLayout(false);
			this->pageSettings->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Press_Load(System::Object^ sender, System::EventArgs^ e) {

		Logger logger;
		logger.Log("Открытие формы", "PressForm.cs", "PressForm", "445");
	}
		   private:
			  // string periodSrokSubscribe();
			   String message;
			   bool successful;
			   bool isEdit;


			public: void SetPeriodListBindingSource(BindingSource^ pList)
			{
				gridPress->DataSource = pList;
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

	private: void btnLoadPress_Click(Object sender, EventArgs e)
	{

		IPressView pView = this;
		string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
		IPressRepository pRepository = gcnew IPressRepository(sqlConnectionString);

		Logger logger;
		logger.Log("Загрузка из бд", "PressForm.cs", "btnLoadPress", "247");
	}

	private: void btnExportPress_Click(Object sender, EventArgs e)
	{
		ExportContextMenu.Show();


		Logger logger;
		logger.Log("Экспорт", "PressForm.cs", "btnExportPress", "261");
	}

	private: void ExpMenuItemExcel_Click(Object sender, EventArgs e)
	{
		ExcelExport excelExport;
		excelExport.excelExport(gridPress);

		Logger logger;
		logger.Log("Экспорт в Excel", "PressForm.cs", "ExpMenuItemExcel", "272");
	}

	private: void ExpMenuItemWord_Click(Object sender, EventArgs e)
	{
		SaveFileDialog^ save = gcnew SaveFileDialog();
		WordExport wordExport;

		save->Filter = "Word документы (*.doc)|*.doc";
		save->FileName = "";

		if (save->ShowDialog())
			wordExport.wordExport(gridPress, save->FileName);

		Logger logger;
		logger.Log("Экспорт в Word", "PressForm.cs", "ExpMenuItemWord", "281");
	}
};
}
