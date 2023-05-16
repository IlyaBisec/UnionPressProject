#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MainPage
	/// </summary>
	public ref class MainPage : public System::Windows::Forms::Form
	{
	public:
		MainPage(void)
		{
			InitializeComponent();
			timer1 = gcnew Timer();
			timer1->Interval = 2000;
			timer1->Tick += gcnew EventHandler(timer1_Tick);
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MainPage()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ btnSlideShow;
	protected:
	private: System::Windows::Forms::PictureBox^ picBoxSlide;
	private: System::Windows::Forms::Timer^ timer1;
	private: System::ComponentModel::IContainer^ components;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MainPage::typeid));
			this->btnSlideShow = (gcnew System::Windows::Forms::Button());
			this->picBoxSlide = (gcnew System::Windows::Forms::PictureBox());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picBoxSlide))->BeginInit();
			this->SuspendLayout();
			// 
			// btnSlideShow
			// 
			this->btnSlideShow->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnSlideShow->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(30)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->btnSlideShow->FlatAppearance->BorderSize = 0;
			this->btnSlideShow->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnSlideShow->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnSlideShow->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnSlideShow->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnSlideShow->Location = System::Drawing::Point(235, 446);
			this->btnSlideShow->Name = L"btnSlideShow";
			this->btnSlideShow->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnSlideShow->Size = System::Drawing::Size(290, 55);
			this->btnSlideShow->TabIndex = 12;
			this->btnSlideShow->Text = L"Запустить показ";
			this->btnSlideShow->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnSlideShow->UseVisualStyleBackColor = false;
			this->btnSlideShow->Click += gcnew System::EventHandler(this, &MainPage::btnSlideShow_Click);
			// 
			// picBoxSlide
			// 
			this->picBoxSlide->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->picBoxSlide->ErrorImage = nullptr;
			this->picBoxSlide->ImageLocation = L"";
			this->picBoxSlide->InitialImage = nullptr;
			this->picBoxSlide->Location = System::Drawing::Point(12, 12);
			this->picBoxSlide->Name = L"picBoxSlide";
			this->picBoxSlide->Size = System::Drawing::Size(742, 406);
			this->picBoxSlide->TabIndex = 11;
			this->picBoxSlide->TabStop = false;
			// 
			// timer1
			// 
			this->timer1->Tick += gcnew System::EventHandler(this, &MainPage::timer1_Tick);
			// 
			// MainPage
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(766, 513);
			this->Controls->Add(this->btnSlideShow);
			this->Controls->Add(this->picBoxSlide);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"MainPage";
			this->Text = L"Главная страница";
			this->Load += gcnew System::EventHandler(this, &MainPage::MainPage_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picBoxSlide))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void MainPage_Load(System::Object^ sender, System::EventArgs^ e);
	private: System::Void btnSlideShow_Click(System::Object^ sender, System::EventArgs^ e);
		

	private: System::Void timer1_Tick(System::Object^ sender, System::EventArgs^ e);
	//private: static async Task DownLoadFile()

		//   using (var httpClient = new HttpClient())
		//   {
		//	   WebClient client = new WebClient();
		//	   Uri uri = new Uri("https://drive.google.com/drive/folders/1zuhQzzy0cJJZRlYRNAVYudXM8mc11Pb6?usp=sharing");
		//	   client.DownloadFileAsync(uri, "*.png");

		//	   File.WriteAllBytes(Environment.CurrentDirectory + @"\DownloadingImageFromDisk\" + uri.Segments[2],
		//		   await httpClient.GetByteArrayAsync(uri));
		//   }
		//}
};
}
