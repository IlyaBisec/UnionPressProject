#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для TypePress
	/// </summary>
	public ref class TypePress : public System::Windows::Forms::Form
	{
	public:
		TypePress(void)
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
		~TypePress()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TabControl^ tabControlType;
	protected:
	private: System::Windows::Forms::TabPage^ pageMain;
	private: OwnControls::Controls::Modern_TextBox^ txtType;
	private: System::Windows::Forms::Button^ btnEditType;
	private: System::Windows::Forms::Button^ btnSearchType;
	private: System::Windows::Forms::DataGridView^ gridType;
	private: System::Windows::Forms::Button^ btnAddType;
	private: System::Windows::Forms::Label^ lblTitle;
	private: System::Windows::Forms::Button^ btnDelType;
	private: System::Windows::Forms::Button^ btnLoadType;
	private: System::Windows::Forms::Button^ btnExportType;
	private: System::Windows::Forms::TabPage^ pageSettings;
	private: OwnControls::Controls::Modern_TextBox^ txtSettingsType;
	private: System::Windows::Forms::Button^ btnCancelSettings;
	private: System::Windows::Forms::Button^ btnSaveSettings;
	private: System::Windows::Forms::Label^ lblType;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(TypePress::typeid));
			this->tabControlType = (gcnew System::Windows::Forms::TabControl());
			this->pageMain = (gcnew System::Windows::Forms::TabPage());
			this->txtType = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnEditType = (gcnew System::Windows::Forms::Button());
			this->btnSearchType = (gcnew System::Windows::Forms::Button());
			this->gridType = (gcnew System::Windows::Forms::DataGridView());
			this->btnAddType = (gcnew System::Windows::Forms::Button());
			this->lblTitle = (gcnew System::Windows::Forms::Label());
			this->btnDelType = (gcnew System::Windows::Forms::Button());
			this->btnLoadType = (gcnew System::Windows::Forms::Button());
			this->btnExportType = (gcnew System::Windows::Forms::Button());
			this->pageSettings = (gcnew System::Windows::Forms::TabPage());
			this->txtSettingsType = (gcnew OwnControls::Controls::Modern_TextBox());
			this->btnCancelSettings = (gcnew System::Windows::Forms::Button());
			this->btnSaveSettings = (gcnew System::Windows::Forms::Button());
			this->lblType = (gcnew System::Windows::Forms::Label());
			this->tabControlType->SuspendLayout();
			this->pageMain->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridType))->BeginInit();
			this->pageSettings->SuspendLayout();
			this->SuspendLayout();
			// 
			// tabControlType
			// 
			this->tabControlType->Controls->Add(this->pageMain);
			this->tabControlType->Controls->Add(this->pageSettings);
			this->tabControlType->Dock = System::Windows::Forms::DockStyle::Fill;
			this->tabControlType->Location = System::Drawing::Point(0, 0);
			this->tabControlType->Name = L"tabControlType";
			this->tabControlType->SelectedIndex = 0;
			this->tabControlType->Size = System::Drawing::Size(769, 443);
			this->tabControlType->TabIndex = 13;
			// 
			// pageMain
			// 
			this->pageMain->Controls->Add(this->txtType);
			this->pageMain->Controls->Add(this->btnEditType);
			this->pageMain->Controls->Add(this->btnSearchType);
			this->pageMain->Controls->Add(this->gridType);
			this->pageMain->Controls->Add(this->btnAddType);
			this->pageMain->Controls->Add(this->lblTitle);
			this->pageMain->Controls->Add(this->btnDelType);
			this->pageMain->Controls->Add(this->btnLoadType);
			this->pageMain->Controls->Add(this->btnExportType);
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
			// txtType
			// 
			this->txtType->BackColor = System::Drawing::SystemColors::Window;
			this->txtType->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtType->BorderFocusColor = System::Drawing::Color::Red;
			this->txtType->BorderRadius = 0;
			this->txtType->BorderSize = 1;
			this->txtType->ForeColor = System::Drawing::Color::DimGray;
			this->txtType->Location = System::Drawing::Point(9, 35);
			this->txtType->Margin = System::Windows::Forms::Padding(4);
			this->txtType->MultiLine = false;
			this->txtType->Name = L"txtType";
			this->txtType->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtType->PasswordStyle = false;
			this->txtType->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtType->PlaceholderText = L"";
			this->txtType->Size = System::Drawing::Size(543, 27);
			this->txtType->TabIndex = 12;
			this->txtType->Texts = L"";
			this->txtType->UnderLineStyle = true;
			// 
			// btnEditType
			// 
			this->btnEditType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnEditType->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnEditType->FlatAppearance->BorderSize = 0;
			this->btnEditType->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnEditType->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnEditType->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnEditType->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnEditType->Location = System::Drawing::Point(570, 216);
			this->btnEditType->Name = L"btnEditType";
			this->btnEditType->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnEditType->Size = System::Drawing::Size(180, 55);
			this->btnEditType->TabIndex = 10;
			this->btnEditType->Text = L"Изменить";
			this->btnEditType->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnEditType->UseVisualStyleBackColor = false;
			// 
			// btnSearchType
			// 
			this->btnSearchType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSearchType->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnSearchType->FlatAppearance->BorderSize = 0;
			this->btnSearchType->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSearchType->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSearchType->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSearchType->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSearchType->Location = System::Drawing::Point(570, 33);
			this->btnSearchType->Name = L"btnSearchType";
			this->btnSearchType->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSearchType->Size = System::Drawing::Size(180, 55);
			this->btnSearchType->TabIndex = 9;
			this->btnSearchType->Text = L"Поиск";
			this->btnSearchType->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSearchType->UseVisualStyleBackColor = false;
			// 
			// gridType
			// 
			this->gridType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left));
			this->gridType->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->gridType->Location = System::Drawing::Point(6, 66);
			this->gridType->Name = L"gridType";
			this->gridType->Size = System::Drawing::Size(546, 335);
			this->gridType->TabIndex = 0;
			// 
			// btnAddType
			// 
			this->btnAddType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnAddType->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAddType->FlatAppearance->BorderSize = 0;
			this->btnAddType->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAddType->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAddType->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnAddType->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnAddType->Location = System::Drawing::Point(570, 155);
			this->btnAddType->Name = L"btnAddType";
			this->btnAddType->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnAddType->Size = System::Drawing::Size(180, 55);
			this->btnAddType->TabIndex = 2;
			this->btnAddType->Text = L"Добавить";
			this->btnAddType->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnAddType->UseVisualStyleBackColor = false;
			// 
			// lblTitle
			// 
			this->lblTitle->AutoSize = true;
			this->lblTitle->Font = (gcnew System::Drawing::Font(L"Archive", 20, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblTitle->Location = System::Drawing::Point(1, 1);
			this->lblTitle->Name = L"lblTitle";
			this->lblTitle->Size = System::Drawing::Size(298, 30);
			this->lblTitle->TabIndex = 7;
			this->lblTitle->Text = L"поиск тип издания:";
			// 
			// btnDelType
			// 
			this->btnDelType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnDelType->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDelType->FlatAppearance->BorderSize = 0;
			this->btnDelType->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDelType->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnDelType->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDelType->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnDelType->Location = System::Drawing::Point(570, 277);
			this->btnDelType->Name = L"btnDelType";
			this->btnDelType->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnDelType->Size = System::Drawing::Size(180, 55);
			this->btnDelType->TabIndex = 4;
			this->btnDelType->Text = L"Удалить";
			this->btnDelType->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnDelType->UseVisualStyleBackColor = false;
			// 
			// btnLoadType
			// 
			this->btnLoadType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnLoadType->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnLoadType->FlatAppearance->BorderSize = 0;
			this->btnLoadType->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnLoadType->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnLoadType->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnLoadType->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnLoadType->Location = System::Drawing::Point(570, 94);
			this->btnLoadType->Name = L"btnLoadType";
			this->btnLoadType->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnLoadType->Size = System::Drawing::Size(180, 55);
			this->btnLoadType->TabIndex = 6;
			this->btnLoadType->Text = L"Загрузить";
			this->btnLoadType->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnLoadType->UseVisualStyleBackColor = false;
			// 
			// btnExportType
			// 
			this->btnExportType->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnExportType->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExportType->FlatAppearance->BorderSize = 0;
			this->btnExportType->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExportType->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnExportType->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnExportType->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExportType->Location = System::Drawing::Point(570, 338);
			this->btnExportType->Name = L"btnExportType";
			this->btnExportType->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnExportType->Size = System::Drawing::Size(180, 55);
			this->btnExportType->TabIndex = 5;
			this->btnExportType->Text = L"Экспорт";
			this->btnExportType->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnExportType->UseVisualStyleBackColor = false;
			// 
			// pageSettings
			// 
			this->pageSettings->Controls->Add(this->txtSettingsType);
			this->pageSettings->Controls->Add(this->btnCancelSettings);
			this->pageSettings->Controls->Add(this->btnSaveSettings);
			this->pageSettings->Controls->Add(this->lblType);
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
			// txtSettingsType
			// 
			this->txtSettingsType->BackColor = System::Drawing::SystemColors::Window;
			this->txtSettingsType->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->txtSettingsType->BorderFocusColor = System::Drawing::Color::Red;
			this->txtSettingsType->BorderRadius = 0;
			this->txtSettingsType->BorderSize = 1;
			this->txtSettingsType->ForeColor = System::Drawing::Color::DimGray;
			this->txtSettingsType->Location = System::Drawing::Point(290, 134);
			this->txtSettingsType->Margin = System::Windows::Forms::Padding(4);
			this->txtSettingsType->MultiLine = false;
			this->txtSettingsType->Name = L"txtSettingsType";
			this->txtSettingsType->Padding = System::Windows::Forms::Padding(10, 7, 10, 7);
			this->txtSettingsType->PasswordStyle = false;
			this->txtSettingsType->PlaceholderColor = System::Drawing::Color::DarkGray;
			this->txtSettingsType->PlaceholderText = L"";
			this->txtSettingsType->Size = System::Drawing::Size(167, 27);
			this->txtSettingsType->TabIndex = 0;
			this->txtSettingsType->Texts = L"";
			this->txtSettingsType->UnderLineStyle = true;
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
			this->btnCancelSettings->TabIndex = 2;
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
			this->btnSaveSettings->TabIndex = 1;
			this->btnSaveSettings->Text = L"Сохранить";
			this->btnSaveSettings->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSaveSettings->UseVisualStyleBackColor = false;
			// 
			// lblType
			// 
			this->lblType->AutoSize = true;
			this->lblType->Font = (gcnew System::Drawing::Font(L"Archive", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblType->Location = System::Drawing::Point(360, 86);
			this->lblType->Name = L"lblType";
			this->lblType->Size = System::Drawing::Size(39, 18);
			this->lblType->TabIndex = 0;
			this->lblType->Text = L"тип";
			// 
			// TypePress
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(769, 443);
			this->Controls->Add(this->tabControlType);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"TypePress";
			this->Text = L"Тип издания";
			this->tabControlType->ResumeLayout(false);
			this->pageMain->ResumeLayout(false);
			this->pageMain->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridType))->EndInit();
			this->pageSettings->ResumeLayout(false);
			this->pageSettings->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}
