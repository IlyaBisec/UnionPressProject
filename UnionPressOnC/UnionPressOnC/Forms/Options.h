#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Options
	/// </summary>
	public ref class Options : public System::Windows::Forms::Form
	{
	public:
		Options(void)
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
		~Options()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ panelStyles;
	protected:
	private: System::Windows::Forms::RadioButton^ radioButton1;
	private: System::Windows::Forms::RadioButton^ radioButton2;
	private: System::Windows::Forms::RadioButton^ rdBtnStyleNight;
	private: OwnControls::Controls::Modern_Button^ btnDropOptions;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::RadioButton^ rdBtnStyleClassic;
	private: OwnControls::Controls::Modern_ToggleButton^ toggleBtnMoving;
	private: System::Windows::Forms::Label^ label10;
	private: OwnControls::Controls::Modern_Button^ btnDefTextBoxColor;
	private: OwnControls::Controls::Modern_Button^ btnTextBoxColor;
	private: System::Windows::Forms::Label^ label9;
	private: OwnControls::Controls::Modern_Button^ btnDefAllFontColor;
	private: System::Windows::Forms::Label^ label8;
	private: OwnControls::Controls::Modern_Button^ btnColorAllFontColor;
	private: OwnControls::Controls::Modern_Button^ btnDefWinBorderColor;
	private: OwnControls::Controls::Modern_Button^ btnDefFontColor;
	private: OwnControls::Controls::Modern_Button^ btnDefBtnColor;
	private: OwnControls::Controls::Modern_Button^ btnButtonColor;
	private: System::Windows::Forms::Label^ label7;
	private: OwnControls::Controls::Modern_Button^ btnColorWinFont;
	private: OwnControls::Controls::Modern_Button^ btnColorWinBorder;
	private: OwnControls::Controls::Modern_Button^ btnAboutA;
	private: System::Windows::Forms::Label^ label6;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TrackBar^ trackBarSizeWinBorder;
	private: System::Windows::Forms::TrackBar^ trackBarRadWinBorder;
	private: System::Windows::Forms::TrackBar^ trackBarFontSize;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Options::typeid));
			this->panelStyles = (gcnew System::Windows::Forms::Panel());
			this->rdBtnStyleNight = (gcnew System::Windows::Forms::RadioButton());
			this->btnDropOptions = (gcnew OwnControls::Controls::Modern_Button());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->rdBtnStyleClassic = (gcnew System::Windows::Forms::RadioButton());
			this->toggleBtnMoving = (gcnew OwnControls::Controls::Modern_ToggleButton());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->btnDefTextBoxColor = (gcnew OwnControls::Controls::Modern_Button());
			this->btnTextBoxColor = (gcnew OwnControls::Controls::Modern_Button());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->btnDefAllFontColor = (gcnew OwnControls::Controls::Modern_Button());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->btnColorAllFontColor = (gcnew OwnControls::Controls::Modern_Button());
			this->btnDefWinBorderColor = (gcnew OwnControls::Controls::Modern_Button());
			this->btnDefFontColor = (gcnew OwnControls::Controls::Modern_Button());
			this->btnDefBtnColor = (gcnew OwnControls::Controls::Modern_Button());
			this->btnButtonColor = (gcnew OwnControls::Controls::Modern_Button());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->btnColorWinFont = (gcnew OwnControls::Controls::Modern_Button());
			this->btnColorWinBorder = (gcnew OwnControls::Controls::Modern_Button());
			this->btnAboutA = (gcnew OwnControls::Controls::Modern_Button());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->trackBarSizeWinBorder = (gcnew System::Windows::Forms::TrackBar());
			this->trackBarRadWinBorder = (gcnew System::Windows::Forms::TrackBar());
			this->trackBarFontSize = (gcnew System::Windows::Forms::TrackBar());
			this->radioButton1 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton2 = (gcnew System::Windows::Forms::RadioButton());
			this->panelStyles->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarSizeWinBorder))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarRadWinBorder))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarFontSize))->BeginInit();
			this->SuspendLayout();
			// 
			// panelStyles
			// 
			this->panelStyles->Controls->Add(this->radioButton1);
			this->panelStyles->Controls->Add(this->radioButton2);
			this->panelStyles->Controls->Add(this->rdBtnStyleNight);
			this->panelStyles->Controls->Add(this->btnDropOptions);
			this->panelStyles->Controls->Add(this->label5);
			this->panelStyles->Controls->Add(this->rdBtnStyleClassic);
			this->panelStyles->Dock = System::Windows::Forms::DockStyle::Right;
			this->panelStyles->Location = System::Drawing::Point(427, 0);
			this->panelStyles->Name = L"panelStyles";
			this->panelStyles->Size = System::Drawing::Size(339, 514);
			this->panelStyles->TabIndex = 41;
			// 
			// rdBtnStyleNight
			// 
			this->rdBtnStyleNight->Appearance = System::Windows::Forms::Appearance::Button;
			this->rdBtnStyleNight->AutoSize = true;
			this->rdBtnStyleNight->FlatAppearance->BorderColor = System::Drawing::Color::White;
			this->rdBtnStyleNight->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->rdBtnStyleNight->Location = System::Drawing::Point(27, 242);
			this->rdBtnStyleNight->Name = L"rdBtnStyleNight";
			this->rdBtnStyleNight->Size = System::Drawing::Size(8, 8);
			this->rdBtnStyleNight->TabIndex = 19;
			this->rdBtnStyleNight->UseVisualStyleBackColor = true;
			// 
			// btnDropOptions
			// 
			this->btnDropOptions->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDropOptions->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDropOptions->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnDropOptions->BorderRadius = 10;
			this->btnDropOptions->BorderSize = 0;
			this->btnDropOptions->FlatAppearance->BorderSize = 0;
			this->btnDropOptions->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDropOptions->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnDropOptions->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDropOptions->Location = System::Drawing::Point(46, 452);
			this->btnDropOptions->Name = L"btnDropOptions";
			this->btnDropOptions->Size = System::Drawing::Size(239, 38);
			this->btnDropOptions->TabIndex = 18;
			this->btnDropOptions->Text = L"Сбросить изменения";
			this->btnDropOptions->TextColor = System::Drawing::Color::Gainsboro;
			this->btnDropOptions->UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->BackColor = System::Drawing::Color::Transparent;
			this->label5->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label5->Location = System::Drawing::Point(23, 11);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(157, 18);
			this->label5->TabIndex = 10;
			this->label5->Text = L"фон приложения";
			// 
			// rdBtnStyleClassic
			// 
			this->rdBtnStyleClassic->Appearance = System::Windows::Forms::Appearance::Button;
			this->rdBtnStyleClassic->AutoSize = true;
			this->rdBtnStyleClassic->FlatAppearance->BorderColor = System::Drawing::Color::White;
			this->rdBtnStyleClassic->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->rdBtnStyleClassic->Location = System::Drawing::Point(27, 33);
			this->rdBtnStyleClassic->Name = L"rdBtnStyleClassic";
			this->rdBtnStyleClassic->Size = System::Drawing::Size(8, 8);
			this->rdBtnStyleClassic->TabIndex = 11;
			this->rdBtnStyleClassic->UseVisualStyleBackColor = true;
			// 
			// toggleBtnMoving
			// 
			this->toggleBtnMoving->AutoSize = true;
			this->toggleBtnMoving->Location = System::Drawing::Point(225, 101);
			this->toggleBtnMoving->MinimumSize = System::Drawing::Size(180, 22);
			this->toggleBtnMoving->Name = L"toggleBtnMoving";
			this->toggleBtnMoving->OffBackColor = System::Drawing::Color::Gray;
			this->toggleBtnMoving->OffToggleColor = System::Drawing::Color::Gainsboro;
			this->toggleBtnMoving->OnBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(30)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->toggleBtnMoving->OnToggleColor = System::Drawing::Color::WhiteSmoke;
			this->toggleBtnMoving->Size = System::Drawing::Size(180, 22);
			this->toggleBtnMoving->TabIndex = 57;
			this->toggleBtnMoving->UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->BackColor = System::Drawing::Color::Transparent;
			this->label10->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label10->Location = System::Drawing::Point(222, 70);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(188, 18);
			this->label10->TabIndex = 56;
			this->label10->Text = L"вкл перетаскивание";
			// 
			// btnDefTextBoxColor
			// 
			this->btnDefTextBoxColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefTextBoxColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefTextBoxColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnDefTextBoxColor->BorderRadius = 5;
			this->btnDefTextBoxColor->BorderSize = 0;
			this->btnDefTextBoxColor->FlatAppearance->BorderSize = 0;
			this->btnDefTextBoxColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDefTextBoxColor->Font = (gcnew System::Drawing::Font(L"Archive", 10));
			this->btnDefTextBoxColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDefTextBoxColor->Location = System::Drawing::Point(295, 411);
			this->btnDefTextBoxColor->Name = L"btnDefTextBoxColor";
			this->btnDefTextBoxColor->Size = System::Drawing::Size(93, 33);
			this->btnDefTextBoxColor->TabIndex = 55;
			this->btnDefTextBoxColor->Text = L"default";
			this->btnDefTextBoxColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnDefTextBoxColor->UseVisualStyleBackColor = false;
			// 
			// btnTextBoxColor
			// 
			this->btnTextBoxColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnTextBoxColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnTextBoxColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnTextBoxColor->BorderRadius = 10;
			this->btnTextBoxColor->BorderSize = 0;
			this->btnTextBoxColor->FlatAppearance->BorderSize = 0;
			this->btnTextBoxColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnTextBoxColor->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnTextBoxColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnTextBoxColor->Location = System::Drawing::Point(21, 411);
			this->btnTextBoxColor->Name = L"btnTextBoxColor";
			this->btnTextBoxColor->Size = System::Drawing::Size(239, 33);
			this->btnTextBoxColor->TabIndex = 54;
			this->btnTextBoxColor->Text = L"жми";
			this->btnTextBoxColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnTextBoxColor->UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->BackColor = System::Drawing::Color::Transparent;
			this->label9->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label9->Location = System::Drawing::Point(17, 386);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(163, 18);
			this->label9->TabIndex = 53;
			this->label9->Text = L"Цвет полей ввода";
			// 
			// btnDefAllFontColor
			// 
			this->btnDefAllFontColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefAllFontColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefAllFontColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnDefAllFontColor->BorderRadius = 5;
			this->btnDefAllFontColor->BorderSize = 0;
			this->btnDefAllFontColor->FlatAppearance->BorderSize = 0;
			this->btnDefAllFontColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDefAllFontColor->Font = (gcnew System::Drawing::Font(L"Archive", 10));
			this->btnDefAllFontColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDefAllFontColor->Location = System::Drawing::Point(295, 280);
			this->btnDefAllFontColor->Name = L"btnDefAllFontColor";
			this->btnDefAllFontColor->Size = System::Drawing::Size(93, 33);
			this->btnDefAllFontColor->TabIndex = 52;
			this->btnDefAllFontColor->Text = L"default";
			this->btnDefAllFontColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnDefAllFontColor->UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->BackColor = System::Drawing::Color::Transparent;
			this->label8->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label8->Location = System::Drawing::Point(18, 258);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(111, 18);
			this->label8->TabIndex = 51;
			this->label8->Text = L"Цвет текста";
			// 
			// btnColorAllFontColor
			// 
			this->btnColorAllFontColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnColorAllFontColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnColorAllFontColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnColorAllFontColor->BorderRadius = 10;
			this->btnColorAllFontColor->BorderSize = 0;
			this->btnColorAllFontColor->FlatAppearance->BorderSize = 0;
			this->btnColorAllFontColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnColorAllFontColor->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnColorAllFontColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnColorAllFontColor->Location = System::Drawing::Point(21, 280);
			this->btnColorAllFontColor->Name = L"btnColorAllFontColor";
			this->btnColorAllFontColor->Size = System::Drawing::Size(239, 33);
			this->btnColorAllFontColor->TabIndex = 50;
			this->btnColorAllFontColor->Text = L"жми";
			this->btnColorAllFontColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnColorAllFontColor->UseVisualStyleBackColor = false;
			// 
			// btnDefWinBorderColor
			// 
			this->btnDefWinBorderColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefWinBorderColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefWinBorderColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnDefWinBorderColor->BorderRadius = 5;
			this->btnDefWinBorderColor->BorderSize = 0;
			this->btnDefWinBorderColor->FlatAppearance->BorderSize = 0;
			this->btnDefWinBorderColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDefWinBorderColor->Font = (gcnew System::Drawing::Font(L"Archive", 10));
			this->btnDefWinBorderColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDefWinBorderColor->Location = System::Drawing::Point(295, 157);
			this->btnDefWinBorderColor->Name = L"btnDefWinBorderColor";
			this->btnDefWinBorderColor->Size = System::Drawing::Size(93, 33);
			this->btnDefWinBorderColor->TabIndex = 49;
			this->btnDefWinBorderColor->Text = L"default";
			this->btnDefWinBorderColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnDefWinBorderColor->UseVisualStyleBackColor = false;
			// 
			// btnDefFontColor
			// 
			this->btnDefFontColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefFontColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefFontColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnDefFontColor->BorderRadius = 5;
			this->btnDefFontColor->BorderSize = 0;
			this->btnDefFontColor->FlatAppearance->BorderSize = 0;
			this->btnDefFontColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDefFontColor->Font = (gcnew System::Drawing::Font(L"Archive", 10));
			this->btnDefFontColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDefFontColor->Location = System::Drawing::Point(295, 220);
			this->btnDefFontColor->Name = L"btnDefFontColor";
			this->btnDefFontColor->Size = System::Drawing::Size(93, 33);
			this->btnDefFontColor->TabIndex = 48;
			this->btnDefFontColor->Text = L"default";
			this->btnDefFontColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnDefFontColor->UseVisualStyleBackColor = false;
			// 
			// btnDefBtnColor
			// 
			this->btnDefBtnColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefBtnColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnDefBtnColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnDefBtnColor->BorderRadius = 5;
			this->btnDefBtnColor->BorderSize = 0;
			this->btnDefBtnColor->FlatAppearance->BorderSize = 0;
			this->btnDefBtnColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnDefBtnColor->Font = (gcnew System::Drawing::Font(L"Archive", 10));
			this->btnDefBtnColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnDefBtnColor->Location = System::Drawing::Point(295, 344);
			this->btnDefBtnColor->Name = L"btnDefBtnColor";
			this->btnDefBtnColor->Size = System::Drawing::Size(93, 33);
			this->btnDefBtnColor->TabIndex = 47;
			this->btnDefBtnColor->Text = L"default";
			this->btnDefBtnColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnDefBtnColor->UseVisualStyleBackColor = false;
			// 
			// btnButtonColor
			// 
			this->btnButtonColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnButtonColor->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnButtonColor->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnButtonColor->BorderRadius = 10;
			this->btnButtonColor->BorderSize = 0;
			this->btnButtonColor->FlatAppearance->BorderSize = 0;
			this->btnButtonColor->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnButtonColor->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnButtonColor->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnButtonColor->Location = System::Drawing::Point(21, 344);
			this->btnButtonColor->Name = L"btnButtonColor";
			this->btnButtonColor->Size = System::Drawing::Size(239, 33);
			this->btnButtonColor->TabIndex = 46;
			this->btnButtonColor->Text = L"жми";
			this->btnButtonColor->TextColor = System::Drawing::Color::Gainsboro;
			this->btnButtonColor->UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->BackColor = System::Drawing::Color::Transparent;
			this->label7->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label7->Location = System::Drawing::Point(17, 319);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(115, 18);
			this->label7->TabIndex = 45;
			this->label7->Text = L"Цвет кнопок";
			// 
			// btnColorWinFont
			// 
			this->btnColorWinFont->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnColorWinFont->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnColorWinFont->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnColorWinFont->BorderRadius = 10;
			this->btnColorWinFont->BorderSize = 0;
			this->btnColorWinFont->FlatAppearance->BorderSize = 0;
			this->btnColorWinFont->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnColorWinFont->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnColorWinFont->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnColorWinFont->Location = System::Drawing::Point(21, 220);
			this->btnColorWinFont->Name = L"btnColorWinFont";
			this->btnColorWinFont->Size = System::Drawing::Size(239, 33);
			this->btnColorWinFont->TabIndex = 44;
			this->btnColorWinFont->Text = L"жми";
			this->btnColorWinFont->TextColor = System::Drawing::Color::Gainsboro;
			this->btnColorWinFont->UseVisualStyleBackColor = false;
			// 
			// btnColorWinBorder
			// 
			this->btnColorWinBorder->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnColorWinBorder->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)),
				static_cast<System::Int32>(static_cast<System::Byte>(100)), static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnColorWinBorder->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnColorWinBorder->BorderRadius = 10;
			this->btnColorWinBorder->BorderSize = 0;
			this->btnColorWinBorder->FlatAppearance->BorderSize = 0;
			this->btnColorWinBorder->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnColorWinBorder->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnColorWinBorder->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnColorWinBorder->Location = System::Drawing::Point(20, 157);
			this->btnColorWinBorder->Name = L"btnColorWinBorder";
			this->btnColorWinBorder->Size = System::Drawing::Size(239, 33);
			this->btnColorWinBorder->TabIndex = 43;
			this->btnColorWinBorder->Text = L"жми";
			this->btnColorWinBorder->TextColor = System::Drawing::Color::Gainsboro;
			this->btnColorWinBorder->UseVisualStyleBackColor = false;
			// 
			// btnAboutA
			// 
			this->btnAboutA->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAboutA->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnAboutA->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnAboutA->BorderRadius = 10;
			this->btnAboutA->BorderSize = 0;
			this->btnAboutA->FlatAppearance->BorderSize = 0;
			this->btnAboutA->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnAboutA->Font = (gcnew System::Drawing::Font(L"Archive", 9.5F));
			this->btnAboutA->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnAboutA->Location = System::Drawing::Point(19, 463);
			this->btnAboutA->Name = L"btnAboutA";
			this->btnAboutA->Size = System::Drawing::Size(183, 38);
			this->btnAboutA->TabIndex = 42;
			this->btnAboutA->Text = L"Об Авторе";
			this->btnAboutA->TextColor = System::Drawing::Color::Gainsboro;
			this->btnAboutA->UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->BackColor = System::Drawing::Color::Transparent;
			this->label6->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label6->Location = System::Drawing::Point(18, 197);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(211, 18);
			this->label6->TabIndex = 40;
			this->label6->Text = L"Цвет текста на кнопках";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->BackColor = System::Drawing::Color::Transparent;
			this->label4->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label4->Location = System::Drawing::Point(18, 133);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(160, 18);
			this->label4->TabIndex = 39;
			this->label4->Text = L"Цвет границ окна";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::Color::Transparent;
			this->label3->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label3->Location = System::Drawing::Point(15, 66);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(180, 18);
			this->label3->TabIndex = 38;
			this->label3->Text = L"размер границ окна";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::Color::Transparent;
			this->label1->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label1->Location = System::Drawing::Point(222, 11);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(181, 18);
			this->label1->TabIndex = 37;
			this->label1->Text = L"радиус границ окна";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::Color::Transparent;
			this->label2->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->label2->Location = System::Drawing::Point(15, 11);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(131, 18);
			this->label2->TabIndex = 36;
			this->label2->Text = L"Размер текста";
			// 
			// trackBarSizeWinBorder
			// 
			this->trackBarSizeWinBorder->BackColor = System::Drawing::SystemColors::Control;
			this->trackBarSizeWinBorder->LargeChange = 3;
			this->trackBarSizeWinBorder->Location = System::Drawing::Point(7, 87);
			this->trackBarSizeWinBorder->Maximum = 20;
			this->trackBarSizeWinBorder->Minimum = 1;
			this->trackBarSizeWinBorder->Name = L"trackBarSizeWinBorder";
			this->trackBarSizeWinBorder->Size = System::Drawing::Size(195, 45);
			this->trackBarSizeWinBorder->TabIndex = 35;
			this->trackBarSizeWinBorder->TickStyle = System::Windows::Forms::TickStyle::Both;
			this->trackBarSizeWinBorder->Value = 1;
			// 
			// trackBarRadWinBorder
			// 
			this->trackBarRadWinBorder->LargeChange = 3;
			this->trackBarRadWinBorder->Location = System::Drawing::Point(219, 29);
			this->trackBarRadWinBorder->Maximum = 20;
			this->trackBarRadWinBorder->Minimum = 1;
			this->trackBarRadWinBorder->Name = L"trackBarRadWinBorder";
			this->trackBarRadWinBorder->Size = System::Drawing::Size(195, 45);
			this->trackBarRadWinBorder->TabIndex = 34;
			this->trackBarRadWinBorder->TickStyle = System::Windows::Forms::TickStyle::Both;
			this->trackBarRadWinBorder->Value = 1;
			// 
			// trackBarFontSize
			// 
			this->trackBarFontSize->LargeChange = 1;
			this->trackBarFontSize->Location = System::Drawing::Point(7, 29);
			this->trackBarFontSize->Maximum = 12;
			this->trackBarFontSize->Minimum = 5;
			this->trackBarFontSize->Name = L"trackBarFontSize";
			this->trackBarFontSize->Size = System::Drawing::Size(195, 45);
			this->trackBarFontSize->TabIndex = 33;
			this->trackBarFontSize->TickStyle = System::Windows::Forms::TickStyle::Both;
			this->trackBarFontSize->Value = 5;
			// 
			// radioButton1
			// 
			this->radioButton1->Appearance = System::Windows::Forms::Appearance::Button;
			this->radioButton1->AutoSize = true;
			this->radioButton1->FlatAppearance->BorderColor = System::Drawing::Color::White;
			this->radioButton1->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->radioButton1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"radioButton1.Image")));
			this->radioButton1->Location = System::Drawing::Point(46, 258);
			this->radioButton1->Name = L"radioButton1";
			this->radioButton1->Size = System::Drawing::Size(258, 173);
			this->radioButton1->TabIndex = 21;
			this->radioButton1->UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this->radioButton2->Appearance = System::Windows::Forms::Appearance::Button;
			this->radioButton2->AutoSize = true;
			this->radioButton2->FlatAppearance->BorderColor = System::Drawing::Color::White;
			this->radioButton2->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->radioButton2->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"radioButton2.Image")));
			this->radioButton2->Location = System::Drawing::Point(46, 42);
			this->radioButton2->Name = L"radioButton2";
			this->radioButton2->Size = System::Drawing::Size(258, 173);
			this->radioButton2->TabIndex = 20;
			this->radioButton2->UseVisualStyleBackColor = true;
			// 
			// Options
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(766, 514);
			this->Controls->Add(this->panelStyles);
			this->Controls->Add(this->toggleBtnMoving);
			this->Controls->Add(this->label10);
			this->Controls->Add(this->btnDefTextBoxColor);
			this->Controls->Add(this->btnTextBoxColor);
			this->Controls->Add(this->label9);
			this->Controls->Add(this->btnDefAllFontColor);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->btnColorAllFontColor);
			this->Controls->Add(this->btnDefWinBorderColor);
			this->Controls->Add(this->btnDefFontColor);
			this->Controls->Add(this->btnDefBtnColor);
			this->Controls->Add(this->btnButtonColor);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->btnColorWinFont);
			this->Controls->Add(this->btnColorWinBorder);
			this->Controls->Add(this->btnAboutA);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->trackBarSizeWinBorder);
			this->Controls->Add(this->trackBarRadWinBorder);
			this->Controls->Add(this->trackBarFontSize);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Options";
			this->Text = L"Настройки";
			this->panelStyles->ResumeLayout(false);
			this->panelStyles->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarSizeWinBorder))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarRadWinBorder))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarFontSize))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	};
}
