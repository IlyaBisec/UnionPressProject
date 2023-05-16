#pragma once


namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MainForm
	/// </summary>
	public ref class MainForm : public System::Windows::Forms::Form
	{
	public:
		MainForm(void)
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
		~MainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ pnlImage;
	protected:
	private: System::Windows::Forms::Label^ lblMainName;
	private: System::Windows::Forms::Button^ btnMainHide;
	private: System::Windows::Forms::Button^ btnMainClose;
	private: OwnControls::Controls::Modern_Button^ btnConnect;
	private: OwnControls::Controls::Modern_Button^ btnExit;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MainForm::typeid));
			this->pnlImage = (gcnew System::Windows::Forms::Panel());
			this->lblMainName = (gcnew System::Windows::Forms::Label());
			this->btnMainHide = (gcnew System::Windows::Forms::Button());
			this->btnMainClose = (gcnew System::Windows::Forms::Button());
			this->btnConnect = (gcnew OwnControls::Controls::Modern_Button());
			this->btnExit = (gcnew OwnControls::Controls::Modern_Button());
			this->SuspendLayout();
			// 
			// pnlImage
			// 
			this->pnlImage->BackColor = System::Drawing::Color::Transparent;
			this->pnlImage->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pnlImage.BackgroundImage")));
			this->pnlImage->Location = System::Drawing::Point(3, 2);
			this->pnlImage->Name = L"pnlImage";
			this->pnlImage->Size = System::Drawing::Size(23, 22);
			this->pnlImage->TabIndex = 0;
			// 
			// lblMainName
			// 
			this->lblMainName->AutoSize = true;
			this->lblMainName->BackColor = System::Drawing::Color::Transparent;
			this->lblMainName->Font = (gcnew System::Drawing::Font(L"Archive", 12));
			this->lblMainName->ForeColor = System::Drawing::Color::White;
			this->lblMainName->Location = System::Drawing::Point(32, 5);
			this->lblMainName->Name = L"lblMainName";
			this->lblMainName->Size = System::Drawing::Size(132, 18);
			this->lblMainName->TabIndex = 1;
			this->lblMainName->Text = L"Главное меню";
			// 
			// btnMainHide
			// 
			this->btnMainHide->BackColor = System::Drawing::Color::Transparent;
			this->btnMainHide->FlatAppearance->BorderSize = 0;
			this->btnMainHide->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnMainHide->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->btnMainHide->ForeColor = System::Drawing::Color::White;
			this->btnMainHide->Location = System::Drawing::Point(257, -1);
			this->btnMainHide->Name = L"btnMainHide";
			this->btnMainHide->Size = System::Drawing::Size(22, 23);
			this->btnMainHide->TabIndex = 9;
			this->btnMainHide->Text = L"____";
			this->btnMainHide->UseVisualStyleBackColor = false;
			this->btnMainHide->Click += gcnew System::EventHandler(this, &MainForm::btnMainHide_Click);
			// 
			// btnMainClose
			// 
			this->btnMainClose->BackColor = System::Drawing::Color::Transparent;
			this->btnMainClose->FlatAppearance->BorderSize = 0;
			this->btnMainClose->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnMainClose->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->btnMainClose->ForeColor = System::Drawing::Color::White;
			this->btnMainClose->Location = System::Drawing::Point(277, 1);
			this->btnMainClose->Name = L"btnMainClose";
			this->btnMainClose->Size = System::Drawing::Size(22, 23);
			this->btnMainClose->TabIndex = 10;
			this->btnMainClose->Text = L"X";
			this->btnMainClose->UseVisualStyleBackColor = false;
			this->btnMainClose->Click += gcnew System::EventHandler(this, &MainForm::btnMainClose_Click);
			// 
			// btnConnect
			// 
			this->btnConnect->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(31)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnConnect->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(31)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnConnect->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnConnect->BorderRadius = 7;
			this->btnConnect->BorderSize = 0;
			this->btnConnect->FlatAppearance->BorderSize = 0;
			this->btnConnect->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnConnect->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F));
			this->btnConnect->ForeColor = System::Drawing::Color::White;
			this->btnConnect->Location = System::Drawing::Point(87, 155);
			this->btnConnect->Name = L"btnConnect";
			this->btnConnect->Size = System::Drawing::Size(124, 40);
			this->btnConnect->TabIndex = 6;
			this->btnConnect->Text = L"Войти";
			this->btnConnect->TextColor = System::Drawing::Color::White;
			this->btnConnect->UseVisualStyleBackColor = false;
			this->btnConnect->Click += gcnew System::EventHandler(this, &MainForm::btnConnect_Click);
			// 
			// btnExit
			// 
			this->btnExit->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(31)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExit->BackgroundColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(31)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnExit->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnExit->BorderRadius = 7;
			this->btnExit->BorderSize = 0;
			this->btnExit->FlatAppearance->BorderSize = 0;
			this->btnExit->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExit->Font = (gcnew System::Drawing::Font(L"Archive", 9.75F));
			this->btnExit->ForeColor = System::Drawing::Color::White;
			this->btnExit->Location = System::Drawing::Point(87, 212);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Size = System::Drawing::Size(124, 40);
			this->btnExit->TabIndex = 7;
			this->btnExit->Text = L"Выйти";
			this->btnExit->TextColor = System::Drawing::Color::White;
			this->btnExit->UseVisualStyleBackColor = false;
			this->btnExit->Click += gcnew System::EventHandler(this, &MainForm::btnExit_Click);
			// 
			// MainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"$this.BackgroundImage")));
			this->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Center;
			this->ClientSize = System::Drawing::Size(300, 375);
			this->Controls->Add(this->btnExit);
			this->Controls->Add(this->btnConnect);
			this->Controls->Add(this->btnMainClose);
			this->Controls->Add(this->btnMainHide);
			this->Controls->Add(this->lblMainName);
			this->Controls->Add(this->pnlImage);
			this->DoubleBuffered = true;
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"MainForm";
			this->Text = L"Союз печати";
			this->Load += gcnew System::EventHandler(this, &MainForm::MainForm_Load);
			this->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &MainForm::MainForm_MouseDown);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

#pragma region MainForm buttons
		private: System::Void btnConnect_Click(System::Object^ sender, System::EventArgs^ e);
		private: System::Void btnExit_Click(System::Object^ sender, System::EventArgs^ e);
		private: System::Void btnMainHide_Click(System::Object^ sender, System::EventArgs^ e);
		private: System::Void btnMainClose_Click(System::Object^ sender, System::EventArgs^ e);
#pragma endregion

	private: System::Void MainForm_Load(System::Object^ sender, System::EventArgs^ e);
	private: System::Void MainForm_MouseDown(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e);

		   private: int counter = 0;
		   private: int counterConnect = 0;
		   private: int counterExit = 0;
				 /* private:  void timer1_Tick(System::Object^ sender, EventArgs e)
				  {
					  var settings = Properties.Settings.Default;
					  i += 1;
					  string mm;
					  string ss;
					  string hh = (i / 3600).ToString();
					  if ((i % 3600) / 60 > 9)
					  {
						  mm = ((i % 3600) / 60).ToString();
					  }
					  else
					  {
						  mm = "0" + ((i % 3600) / 60).ToString();
					  }
					  if ((i % 3600) % 60 > 9)
					  {
						  ss = ((i % 3600) % 60).ToString();
					  }
					  else
					  {
						  ss = "0" + ((i % 3600) % 60).ToString();
					  }
					  settings.AppsTime = hh + ":" + mm + ":" + ss;
					  if (i < 0)
						  timer1.Stop();
				  }*/

};
}
