#pragma once
#include "Classes/FunctionsDB.h"
#include <cstddef>
#include "C:/Program Files (x86)/Reference Assemblies/Microsoft/Framework/.NETFramework/v4.8/System.Drawing.dll"

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для TabelsAndPanels
	/// </summary>
	public ref class TabelsAndPanels : public System::Windows::Forms::Form
	{
	public:
		TabelsAndPanels(void)
		{
			InitializeComponent();
		}

	private:
		Button currentButton;
		 Form activeForm;

		////statistics
		//private int counterWorkers = 0, counterPress = 0,
		//	counterTypePress = 0, counterPeriodPress = 0,
		//	counterGraphic = 0, counterOptions = 0,
		//	counterStatistics = 0, counterLogoMainPage = 0,
		//	counterExit = 0, counterDostavka = 0;


		FunctionsDB functionsDB;
		// private int btnIndex;

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~TabelsAndPanels()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ panelMenu;
	protected:
	private: System::Windows::Forms::Button^ btnExit;
	private: System::Windows::Forms::Button^ btnOptions;
	private: System::Windows::Forms::Button^ btnStatistics;
	private: System::Windows::Forms::Button^ btnGraph;
	private: System::Windows::Forms::Button^ btnPeriodPress;
	private: System::Windows::Forms::Button^ btnTypePress;
	private: System::Windows::Forms::Button^ btnPresss;
	private: System::Windows::Forms::Button^ btnTransporter;
	private: System::Windows::Forms::Button^ btnWorkers;
	private: System::Windows::Forms::Panel^ panelLogo;
	private: System::Windows::Forms::Label^ lblLogo1;
	private: System::Windows::Forms::Panel^ panelTitle;
	private: System::Windows::Forms::Panel^ pnlControlBoxContainer;
	private: OwnControls::Controls::Modern_Button^ btnCollapse;
	private: OwnControls::Controls::Modern_Button^ btnExpand;
	private: System::Windows::Forms::Label^ lblTitle;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(TabelsAndPanels::typeid));
			this->panelMenu = (gcnew System::Windows::Forms::Panel());
			this->btnExit = (gcnew System::Windows::Forms::Button());
			this->btnOptions = (gcnew System::Windows::Forms::Button());
			this->btnStatistics = (gcnew System::Windows::Forms::Button());
			this->btnGraph = (gcnew System::Windows::Forms::Button());
			this->btnPeriodPress = (gcnew System::Windows::Forms::Button());
			this->btnTypePress = (gcnew System::Windows::Forms::Button());
			this->btnPresss = (gcnew System::Windows::Forms::Button());
			this->btnTransporter = (gcnew System::Windows::Forms::Button());
			this->btnWorkers = (gcnew System::Windows::Forms::Button());
			this->panelLogo = (gcnew System::Windows::Forms::Panel());
			this->lblLogo1 = (gcnew System::Windows::Forms::Label());
			this->panelTitle = (gcnew System::Windows::Forms::Panel());
			this->pnlControlBoxContainer = (gcnew System::Windows::Forms::Panel());
			this->btnCollapse = (gcnew OwnControls::Controls::Modern_Button());
			this->btnExpand = (gcnew OwnControls::Controls::Modern_Button());
			this->lblTitle = (gcnew System::Windows::Forms::Label());
			this->panelMenu->SuspendLayout();
			this->panelLogo->SuspendLayout();
			this->panelTitle->SuspendLayout();
			this->pnlControlBoxContainer->SuspendLayout();
			this->SuspendLayout();
			// 
			// panelMenu
			// 
			this->panelMenu->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(51)), static_cast<System::Int32>(static_cast<System::Byte>(51)),
				static_cast<System::Int32>(static_cast<System::Byte>(70)));
			this->panelMenu->Controls->Add(this->btnExit);
			this->panelMenu->Controls->Add(this->btnOptions);
			this->panelMenu->Controls->Add(this->btnStatistics);
			this->panelMenu->Controls->Add(this->btnGraph);
			this->panelMenu->Controls->Add(this->btnPeriodPress);
			this->panelMenu->Controls->Add(this->btnTypePress);
			this->panelMenu->Controls->Add(this->btnPresss);
			this->panelMenu->Controls->Add(this->btnTransporter);
			this->panelMenu->Controls->Add(this->btnWorkers);
			this->panelMenu->Controls->Add(this->panelLogo);
			this->panelMenu->Dock = System::Windows::Forms::DockStyle::Left;
			this->panelMenu->Location = System::Drawing::Point(0, 0);
			this->panelMenu->Name = L"panelMenu";
			this->panelMenu->Size = System::Drawing::Size(170, 631);
			this->panelMenu->TabIndex = 1;
			// 
			// btnExit
			// 
			this->btnExit->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnExit->FlatAppearance->BorderSize = 0;
			this->btnExit->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExit->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnExit->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnExit->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnExit.Image")));
			this->btnExit->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExit->Location = System::Drawing::Point(0, 560);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnExit->Size = System::Drawing::Size(170, 60);
			this->btnExit->TabIndex = 9;
			this->btnExit->Text = L"Выход";
			this->btnExit->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnExit->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnExit->UseVisualStyleBackColor = true;
			// 
			// btnOptions
			// 
			this->btnOptions->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnOptions->FlatAppearance->BorderSize = 0;
			this->btnOptions->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnOptions->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnOptions->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnOptions->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnOptions.Image")));
			this->btnOptions->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnOptions->Location = System::Drawing::Point(0, 500);
			this->btnOptions->Name = L"btnOptions";
			this->btnOptions->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnOptions->Size = System::Drawing::Size(170, 60);
			this->btnOptions->TabIndex = 8;
			this->btnOptions->Text = L"  Настройки";
			this->btnOptions->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnOptions->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnOptions->UseVisualStyleBackColor = true;
			// 
			// btnStatistics
			// 
			this->btnStatistics->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnStatistics->FlatAppearance->BorderSize = 0;
			this->btnStatistics->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnStatistics->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnStatistics->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnStatistics->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnStatistics.Image")));
			this->btnStatistics->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnStatistics->Location = System::Drawing::Point(0, 440);
			this->btnStatistics->Name = L"btnStatistics";
			this->btnStatistics->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnStatistics->Size = System::Drawing::Size(170, 60);
			this->btnStatistics->TabIndex = 7;
			this->btnStatistics->Text = L"  Статистика";
			this->btnStatistics->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnStatistics->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnStatistics->UseVisualStyleBackColor = true;
			// 
			// btnGraph
			// 
			this->btnGraph->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnGraph->FlatAppearance->BorderSize = 0;
			this->btnGraph->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnGraph->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnGraph->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnGraph->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnGraph.Image")));
			this->btnGraph->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnGraph->Location = System::Drawing::Point(0, 380);
			this->btnGraph->Name = L"btnGraph";
			this->btnGraph->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnGraph->Size = System::Drawing::Size(170, 60);
			this->btnGraph->TabIndex = 6;
			this->btnGraph->Text = L"График";
			this->btnGraph->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnGraph->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnGraph->UseVisualStyleBackColor = true;
			// 
			// btnPeriodPress
			// 
			this->btnPeriodPress->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnPeriodPress->FlatAppearance->BorderSize = 0;
			this->btnPeriodPress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnPeriodPress->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F));
			this->btnPeriodPress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnPeriodPress->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnPeriodPress.Image")));
			this->btnPeriodPress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnPeriodPress->Location = System::Drawing::Point(0, 320);
			this->btnPeriodPress->Name = L"btnPeriodPress";
			this->btnPeriodPress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnPeriodPress->Size = System::Drawing::Size(170, 60);
			this->btnPeriodPress->TabIndex = 5;
			this->btnPeriodPress->Text = L"   Период.    издания";
			this->btnPeriodPress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnPeriodPress->UseVisualStyleBackColor = true;
			// 
			// btnTypePress
			// 
			this->btnTypePress->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnTypePress->FlatAppearance->BorderSize = 0;
			this->btnTypePress->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnTypePress->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F));
			this->btnTypePress->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnTypePress->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnTypePress.Image")));
			this->btnTypePress->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnTypePress->Location = System::Drawing::Point(0, 260);
			this->btnTypePress->Name = L"btnTypePress";
			this->btnTypePress->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnTypePress->Size = System::Drawing::Size(170, 60);
			this->btnTypePress->TabIndex = 4;
			this->btnTypePress->Text = L"  Тип изданий";
			this->btnTypePress->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnTypePress->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnTypePress->UseVisualStyleBackColor = true;
			// 
			// btnPresss
			// 
			this->btnPresss->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnPresss->FlatAppearance->BorderSize = 0;
			this->btnPresss->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnPresss->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F));
			this->btnPresss->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnPresss->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnPresss.Image")));
			this->btnPresss->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnPresss->Location = System::Drawing::Point(0, 200);
			this->btnPresss->Name = L"btnPresss";
			this->btnPresss->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnPresss->Size = System::Drawing::Size(170, 60);
			this->btnPresss->TabIndex = 3;
			this->btnPresss->Text = L"  Издания";
			this->btnPresss->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnPresss->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnPresss->UseVisualStyleBackColor = true;
			// 
			// btnTransporter
			// 
			this->btnTransporter->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnTransporter->FlatAppearance->BorderSize = 0;
			this->btnTransporter->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnTransporter->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F));
			this->btnTransporter->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnTransporter->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnTransporter.Image")));
			this->btnTransporter->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnTransporter->Location = System::Drawing::Point(0, 140);
			this->btnTransporter->Name = L"btnTransporter";
			this->btnTransporter->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnTransporter->Size = System::Drawing::Size(170, 60);
			this->btnTransporter->TabIndex = 2;
			this->btnTransporter->Text = L"  Доставка";
			this->btnTransporter->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnTransporter->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnTransporter->UseVisualStyleBackColor = true;
			// 
			// btnWorkers
			// 
			this->btnWorkers->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnWorkers->FlatAppearance->BorderSize = 0;
			this->btnWorkers->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnWorkers->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnWorkers->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnWorkers->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnWorkers.Image")));
			this->btnWorkers->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnWorkers->Location = System::Drawing::Point(0, 80);
			this->btnWorkers->Name = L"btnWorkers";
			this->btnWorkers->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnWorkers->Size = System::Drawing::Size(170, 60);
			this->btnWorkers->TabIndex = 1;
			this->btnWorkers->Text = L"Сотрудники";
			this->btnWorkers->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnWorkers->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnWorkers->UseVisualStyleBackColor = true;
			// 
			// panelLogo
			// 
			this->panelLogo->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(37)),
				static_cast<System::Int32>(static_cast<System::Byte>(70)));
			this->panelLogo->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Center;
			this->panelLogo->Controls->Add(this->lblLogo1);
			this->panelLogo->Dock = System::Windows::Forms::DockStyle::Top;
			this->panelLogo->Location = System::Drawing::Point(0, 0);
			this->panelLogo->Name = L"panelLogo";
			this->panelLogo->Size = System::Drawing::Size(170, 80);
			this->panelLogo->TabIndex = 0;
			// 
			// lblLogo1
			// 
			this->lblLogo1->AutoSize = true;
			this->lblLogo1->BackColor = System::Drawing::Color::Transparent;
			this->lblLogo1->Font = (gcnew System::Drawing::Font(L"Archive", 35, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::World,
				static_cast<System::Byte>(204)));
			this->lblLogo1->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(0)), static_cast<System::Int32>(static_cast<System::Byte>(183)),
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->lblLogo1->Location = System::Drawing::Point(12, -1);
			this->lblLogo1->Name = L"lblLogo1";
			this->lblLogo1->Size = System::Drawing::Size(152, 78);
			this->lblLogo1->TabIndex = 0;
			this->lblLogo1->Text = L" UNION \r\nPRESS";
			this->lblLogo1->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// panelTitle
			// 
			this->panelTitle->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(38)), static_cast<System::Int32>(static_cast<System::Byte>(100)),
				static_cast<System::Int32>(static_cast<System::Byte>(200)));
			this->panelTitle->Controls->Add(this->pnlControlBoxContainer);
			this->panelTitle->Controls->Add(this->lblTitle);
			this->panelTitle->Dock = System::Windows::Forms::DockStyle::Top;
			this->panelTitle->Location = System::Drawing::Point(170, 0);
			this->panelTitle->Name = L"panelTitle";
			this->panelTitle->Size = System::Drawing::Size(782, 74);
			this->panelTitle->TabIndex = 2;
			// 
			// pnlControlBoxContainer
			// 
			this->pnlControlBoxContainer->Controls->Add(this->btnCollapse);
			this->pnlControlBoxContainer->Controls->Add(this->btnExpand);
			this->pnlControlBoxContainer->Dock = System::Windows::Forms::DockStyle::Right;
			this->pnlControlBoxContainer->Location = System::Drawing::Point(689, 0);
			this->pnlControlBoxContainer->Name = L"pnlControlBoxContainer";
			this->pnlControlBoxContainer->Size = System::Drawing::Size(93, 74);
			this->pnlControlBoxContainer->TabIndex = 3;
			// 
			// btnCollapse
			// 
			this->btnCollapse->BackColor = System::Drawing::Color::Transparent;
			this->btnCollapse->BackgroundColor = System::Drawing::Color::Transparent;
			this->btnCollapse->BorderColor = System::Drawing::Color::PaleVioletRed;
			this->btnCollapse->BorderRadius = 0;
			this->btnCollapse->BorderSize = 0;
			this->btnCollapse->FlatAppearance->BorderSize = 0;
			this->btnCollapse->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnCollapse->ForeColor = System::Drawing::Color::White;
			this->btnCollapse->Location = System::Drawing::Point(3, 3);
			this->btnCollapse->Name = L"btnCollapse";
			this->btnCollapse->Size = System::Drawing::Size(35, 26);
			this->btnCollapse->TabIndex = 1;
			this->btnCollapse->Text = L"_____";
			this->btnCollapse->TextColor = System::Drawing::Color::White;
			this->btnCollapse->UseVisualStyleBackColor = false;
			// 
			// btnExpand
			// 
			this->btnExpand->BackColor = System::Drawing::Color::Transparent;
			this->btnExpand->BackgroundColor = System::Drawing::Color::Transparent;
			this->btnExpand->BorderColor = System::Drawing::Color::White;
			this->btnExpand->BorderRadius = 0;
			this->btnExpand->BorderSize = 1;
			this->btnExpand->FlatAppearance->BorderSize = 0;
			this->btnExpand->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExpand->ForeColor = System::Drawing::Color::White;
			this->btnExpand->Location = System::Drawing::Point(44, 8);
			this->btnExpand->Name = L"btnExpand";
			this->btnExpand->Size = System::Drawing::Size(24, 17);
			this->btnExpand->TabIndex = 2;
			this->btnExpand->TextColor = System::Drawing::Color::White;
			this->btnExpand->UseVisualStyleBackColor = false;
			// 
			// lblTitle
			// 
			this->lblTitle->AutoSize = true;
			this->lblTitle->Dock = System::Windows::Forms::DockStyle::Left;
			this->lblTitle->Font = (gcnew System::Drawing::Font(L"Archive", 40));
			this->lblTitle->ForeColor = System::Drawing::Color::Gainsboro;
			this->lblTitle->Location = System::Drawing::Point(0, 0);
			this->lblTitle->Name = L"lblTitle";
			this->lblTitle->Size = System::Drawing::Size(565, 60);
			this->lblTitle->TabIndex = 0;
			this->lblTitle->Text = L"Главная страница";
			this->lblTitle->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			// 
			// TabelsAndPanels
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(952, 631);
			this->Controls->Add(this->panelTitle);
			this->Controls->Add(this->panelMenu);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"TabelsAndPanels";
			this->Text = L"Главная страница";
			this->panelMenu->ResumeLayout(false);
			this->panelLogo->ResumeLayout(false);
			this->panelLogo->PerformLayout();
			this->panelTitle->ResumeLayout(false);
			this->panelTitle->PerformLayout();
			this->pnlControlBoxContainer->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion


#pragma region Dragging
			//Dragging
			

		private:
			
		void panelTitle_MouseDown(Object^ sender, MouseEventArgs e)
		{

			Logger logger;
			logger.Log("Перетаскивание формы", "TablesAndPanels.h", "patelTittle", "45");
		}

		void lblTitle_MouseDown(Object^ sender, MouseEventArgs e)
		{
			/*if (Properties.Settings.Default.IsMoving == true)
				ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);*/

			Logger logger;
			logger.Log("Перетаскивание формы", "TablesAndPanels.h", "lblTittle", "55");

		}
		
		void TabelsAndPanels_MouseDown(Object^ sender, MouseEventArgs e)
		{
			/*if (Properties.Settings.Default.IsMoving == true)
				ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);*/

			Logger logger;
			logger.Log("Перетаскивание формы", "TablesAndPanels.h", "TabelsAndPanel", "65");
		}
			
			private:
				GraphicsPath GetRoundedPath(Rectangle rect, float radius)
			{
				GraphicsPath path = new GraphicsPath();
				float curveSize = radius * 2F;
				path.StartFigure();
				path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
				path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
				path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
				path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
				path.CloseFigure();
				return path;
			}

			private:
				
			void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
			{
				if (this->WindowState != FormWindowState::Minimized)
				{
					using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
						using (Pen penBorder = new Pen(borderColor, borderSize))
						using (Matrix transform = new Matrix())
					{
						graph.SmoothingMode = SmoothingMode.AntiAlias;
						form.Region = new Region(roundPath);
						if (borderSize >= 1)
						{
							Rectangle rect = form.ClientRectangle;
							float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
							float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
							transform.Scale(scaleX, scaleY);
							transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
							graph.Transform = transform;
							graph.DrawPath(penBorder, roundPath);
						}
					}
				}
			}

			void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
			{
				// float radius = Properties.Settings.Default.RadiusWinBorder;
				using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
					using (Pen penBorder = new Pen(borderColor, 1))
				{
					graph.SmoothingMode = SmoothingMode.AntiAlias;
					control.Region = new Region(roundPath);
					graph.DrawPath(penBorder, roundPath);
				}
			}

			void DrawPath(Rectangle rect, Graphics graph, Color color)
			{
				using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
					using (Pen penBorder = new Pen(color, 3))
				{
					graph.DrawPath(penBorder, roundPath);
				}
			}

			private FormBoundsColors GetFormBoundsColors()
			{
				var fbColor = new FormBoundsColors();
				using (var bmp = new Bitmap(1, 1))
					using (Graphics graph = Graphics.FromImage(bmp))
				{
					Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
					//Top Left
					rectBmp.X = this.Bounds.X - 1;
					rectBmp.Y = this.Bounds.Y;
					graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
					fbColor.TopLeftColor = bmp.GetPixel(0, 0);
					//Top Right
					rectBmp.X = this.Bounds.Right;
					rectBmp.Y = this.Bounds.Y;
					graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
					fbColor.TopRightColor = bmp.GetPixel(0, 0);
					//Bottom Left
					rectBmp.X = this.Bounds.X;
					rectBmp.Y = this.Bounds.Bottom;
					graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
					fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
					//Bottom Right
					rectBmp.X = this.Bounds.Right;
					rectBmp.Y = this.Bounds.Bottom;
					graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
					fbColor.BottomRightColor = bmp.GetPixel(0, 0);
				}
				return fbColor;
			}

			void TabelsAndPanels_Paint(Object^ sender, PaintEventArgs e)
			{
				//-> SMOOTH OUTER BORDER
				//e.Graphics.SmoothingMode = SmoothingMode::AntiAlias;
				Rectangle rectForm = this->ClientRectangle;
				int mWidht = rectForm.Width / 2;
				int mHeight = rectForm.Height / 2;
				auto fbColors = GetFormBoundsColors();
				//Top Left
				//DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
				////Top Right
				//Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
				//DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
				////Bottom Left
				//Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
				//DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
				////Bottom Right
				//Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
				//DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
				////-> SET ROUNDED REGION AND BORDER
				//FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
			}

			void panelDesktop_Paint(Object^ sender, PaintEventArgs e)
			{
				// ControlRegionAndBorder(panelDesktop, borderRadius - (borderSize / 2), e.Graphics, borderColor);
			}

			void TabelsAndPanels_ResizeEnd(Object^ sender, EventArgs e)
			{
				this->Invalidate();
			}

			void TabelsAndPanels_SizeChanged(Object^ sender, EventArgs e)
			{
				this->Invalidate();
			}

			void TabelsAndPanels_Activated(Object^ sender, EventArgs e)
			{
				this->Invalidate();
			}

#pragma endregion
				private:
					
			void TabelsAndPanels_Load(Object^ sender, EventArgs e)
			{
				functionsDB.connectToDB();
				MessageBox::Show("Подключение установлено!\nБаза данных загружена");
				ColorSet();

				Logger logger;
				logger.Log("Связь с бд установлена, приложение запускается", "TablesAndPanels.h", "TablesAndPanelsLoad", "223");
			}

			void ColorSet() //устанавливаем цвет-размер из настроек
			{
				//auto settings = Properties.Settings.Default;

				//panelDesktop.BackColor = settings.ColorPanelSet;
			}

			Color SelectThemeColor()
			{
				/*String color = ThemeColor::ColorList[0];
				return ColorTranslator::FromHtml(color);*/
			}

			void ActiveButton(Object^ btnSender)
			{
				if (btnSender != if (activeForm != nullptr)
					)
				{
					if (currentButton != (Button)btnSender)
					{
						DisableButton();
						Color color = SelectThemeColor();
						currentButton = (Button)btnSender;
						currentButton.BackColor = color;
						currentButton.ForeColor = Color.White;
						//currentButton.Font = new System.Drawing.Font("Archive", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
					}
				}
			}

			void DisableButton()
			{
				for each(Control previousBtn in panelMenu->Controls)
				{
					if (previousBtn.GetType() == typeof(Button))
					{
						previousBtn.BackColor = Color.FromArgb(51, 51, 76);
						previousBtn.ForeColor = Color.Gainsboro;
						//previousBtn.Font = new System.Drawing.Font("Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, ((byte)(204)));
					}
				}
			}

			void OpenChildForms(Form childForm, Object^ btnSender)
			{
				if (activeForm != nullptr)
				{
					activeForm.Close();
				}
				ActiveButton(btnSender);
				activeForm = childForm;
				childForm.TopLevel = false;
				childForm.FormBorderStyle = FormBorderStyle::None;
				childForm.Dock = DockStyle::Fill;
				this->panelDesktop.Controls.Add(childForm);
				this->panelDesktop.Tag = childForm;
				childForm.Show();
				lblTitle.Text = childForm.Text;
				this->Text = childForm.Text;
				this->BackColor = childForm.BackColor;

				Logger logger;
				logger.Log("Открытие дочерней формы", "TablesAndPanels.h", "OpenChildForms", "279");
			}

			void OpenMainPage(Form childForm, Object^ btnSender)
			{
				if (activeForm != nullptr)
				{
					activeForm.Close();
				}
				activeForm = childForm;
				childForm.TopLevel = false;
				childForm.FormBorderStyle = FormBorderStyle::None;
				childForm.Dock = DockStyle::Fill;
				this->panelDesktop.Controls.Add(childForm);
				this->panelDesktop.Tag = childForm;
				childForm.Show();
				lblTitle.Text = childForm.Text;
				this->Text = childForm.Text;
				this->BackColor = childForm.BackColor;

				Logger logger;
				logger.Log("Открытие дочерней формы", "TablesAndPanels.h", "OpenChildForms", "301");
			}


			void btnWorkers_Click(Object^ sender, EventArgs e)
			{
				//OpenChildForms(new Forms.Workers(), sender);

				Logger logger;
				logger.Log("дочерняя форма с работниками", "TablesAndPanels.h", "btnWorkers", "323");
			}

			void btnTransporter_Click(Object^ sender, EventArgs e)
			{
				//OpenChildForms(new Forms.Transporter(), sender);

				Logger logger;
				logger.Log("дочерняя форма с доставкой", "TablesAndPanels.h", "btnTransporter", "335");
			}

			void btnPresss_Click(Object^ sender, EventArgs e)
			{

				//OpenChildForms(new Forms.Press(), sender);

				Logger logger;
				logger.Log("дочерняя форма с изданиями", "TablesAndPanels.h", "btnPress", "346");
			}

			void btnTypePress_Click(Object^ sender, EventArgs e)
			{
				
				//OpenChildForms(new Forms.TypePress(), sender);

				Logger logger;
				logger.Log("дочерняя форма с типом изданий", "TablesAndPanels.h", "btnTypePress", "357");
			}

			void btnPeriodPress_Click(Object^ sender, EventArgs e)
			{
				//OpenChildForms(new Forms.PeriodPress(), sender);

				Logger logger;
				logger.Log("дочерняя форма с периодом изданий", "TablesAndPanels.h", "btnPeriodPress", "368");
			}

			void btnExit_Click_1(Object^ sender, EventArgs e)
			{
				
				ActiveButton(sender);
				this->Text = "Выход...";
				this->Close();

				Logger logger;
				logger.Log("Закрытие формы, отключение связи с бд", "TablesAndPanels.h", "btnExit", "379");
			}



			void panelLogo_Paint(Object^ sender, PaintEventArgs e)
			{

			}

			void panelLogo_Click(Object^ sender, EventArgs e)
			{

			}

			void lblLogo1_Click(Object^ sender, EventArgs e)
			{
				
				//OpenMainPage(new Forms.MainPage(), sender);

				Logger logger;
				logger.Log("Клик по лого(главная страница)", "TablesAndPanels.h", "lblLogo", "403");
			}

			void btnGraph_Click(Object^ sender, EventArgs e)
			{
				
				//OpenChildForms(new Forms.GraphicForm(), sender);

				Logger logger;
				logger.Log("Клик по кнопке график", "TablesAndPanels.h", "btnGraphic", "414");
			}

			void btnStatistics_Click(Object^ sender, EventArgs e)
			{
				
				//OpenChildForms(new Forms.Statistics(), sender);

				Logger logger;
				logger.Log("Клик по кнопке статистика", "TablesAndPanels.h", "btnStatistics", "425");
			}

			void btnOptions_Click(Object^ sender, EventArgs e)
			{
				//OpenChildForms(gcnew Forms::Options(), sender);

				Logger logger;
				logger.Log("Клик по кнопке настройки", "TablesAndPanels.h", "btnOptions", "436");
			}

			void btnHide_Click(Object^ sender, EventArgs e)
			{
				FormWindowState::Minimized;

				Logger logger;
				logger.Log("Свернуть окно", "TablesAndPanels.h", "btnHide", "447");
			}

			void btnExpand_Click(Object^ sender, EventArgs e)
			{
				FormWindowState::Maximized;

				Logger logger;
				logger.Log("Разврнуть окно", "TablesAndPanels.h", "btnExpand", "455");
			}






	};
}
