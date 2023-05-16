#pragma once
#include "Press.h"
#include <string>

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для GraphicForm
	/// </summary>
	public ref class GraphicForm : public System::Windows::Forms::Form
	{
	public:
		GraphicForm(void)
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
		~GraphicForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ btnGraph;
	protected:
	private: System::Windows::Forms::DataVisualization::Charting::Chart^ chartDiagram;

	protected:

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			System::Windows::Forms::DataVisualization::Charting::ChartArea^ chartArea1 = (gcnew System::Windows::Forms::DataVisualization::Charting::ChartArea());
			System::Windows::Forms::DataVisualization::Charting::Legend^ legend1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Legend());
			System::Windows::Forms::DataVisualization::Charting::Series^ series1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Series());
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint1 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(10,
				L"10,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint2 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(9,
				L"11,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint3 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(8,
				L"11,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint4 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(7,
				L"9,8,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint5 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(6,
				L"7,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint6 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(5,
				L"6,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint7 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(4,
				L"5,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint8 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(3,
				L"4,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint9 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(2,
				L"3,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint10 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(1,
				L"2,0,0,0,0"));
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ dataPoint11 = (gcnew System::Windows::Forms::DataVisualization::Charting::DataPoint(0,
				L"1,0,0,0,0"));
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(GraphicForm::typeid));
			this->btnGraph = (gcnew System::Windows::Forms::Button());
			this->chartDiagram = (gcnew System::Windows::Forms::DataVisualization::Charting::Chart());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->chartDiagram))->BeginInit();
			this->SuspendLayout();
			// 
			// btnGraph
			// 
			this->btnGraph->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->btnGraph->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(51)), static_cast<System::Int32>(static_cast<System::Byte>(51)),
				static_cast<System::Int32>(static_cast<System::Byte>(70)));
			this->btnGraph->FlatAppearance->BorderSize = 0;
			this->btnGraph->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnGraph->Font = (gcnew System::Drawing::Font(L"Archive", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnGraph->ForeColor = System::Drawing::Color::Gainsboro;
			this->btnGraph->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnGraph->Location = System::Drawing::Point(490, 47);
			this->btnGraph->Name = L"btnGraph";
			this->btnGraph->Padding = System::Windows::Forms::Padding(12, 0, 0, 0);
			this->btnGraph->Size = System::Drawing::Size(180, 55);
			this->btnGraph->TabIndex = 11;
			this->btnGraph->Text = L"Показать";
			this->btnGraph->TextImageRelation = System::Windows::Forms::TextImageRelation::ImageBeforeText;
			this->btnGraph->UseVisualStyleBackColor = false;
			this->btnGraph->Visible = false;
			this->btnGraph->Click += gcnew System::EventHandler(this, &GraphicForm::btnGraph_Click);
			// 
			// chartDiagram
			// 
			this->chartDiagram->BackColor = System::Drawing::Color::Transparent;
			chartArea1->Name = L"ChartArea1";
			this->chartDiagram->ChartAreas->Add(chartArea1);
			legend1->Name = L"Legend1";
			this->chartDiagram->Legends->Add(legend1);
			this->chartDiagram->Location = System::Drawing::Point(-2, 2);
			this->chartDiagram->Name = L"chartDiagram";
			series1->BackGradientStyle = System::Windows::Forms::DataVisualization::Charting::GradientStyle::DiagonalRight;
			series1->BackSecondaryColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(128)), static_cast<System::Int32>(static_cast<System::Byte>(255)),
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			series1->BorderColor = System::Drawing::Color::CornflowerBlue;
			series1->ChartArea = L"ChartArea1";
			series1->ChartType = System::Windows::Forms::DataVisualization::Charting::SeriesChartType::StackedBar;
			series1->Color = System::Drawing::Color::Blue;
			series1->Font = (gcnew System::Drawing::Font(L"Archive", 5.25F));
			series1->Legend = L"Legend1";
			series1->MarkerColor = System::Drawing::Color::MediumPurple;
			series1->MarkerStyle = System::Windows::Forms::DataVisualization::Charting::MarkerStyle::Circle;
			series1->Name = L"SeriesD";
			series1->Points->Add(dataPoint1);
			series1->Points->Add(dataPoint2);
			series1->Points->Add(dataPoint3);
			series1->Points->Add(dataPoint4);
			series1->Points->Add(dataPoint5);
			series1->Points->Add(dataPoint6);
			series1->Points->Add(dataPoint7);
			series1->Points->Add(dataPoint8);
			series1->Points->Add(dataPoint9);
			series1->Points->Add(dataPoint10);
			series1->Points->Add(dataPoint11);
			series1->ShadowColor = System::Drawing::Color::Black;
			series1->ShadowOffset = 5;
			series1->XValueType = System::Windows::Forms::DataVisualization::Charting::ChartValueType::Double;
			series1->YValuesPerPoint = 5;
			this->chartDiagram->Series->Add(series1);
			this->chartDiagram->Size = System::Drawing::Size(422, 513);
			this->chartDiagram->TabIndex = 12;
			this->chartDiagram->Text = L"chart1";
			// 
			// GraphicForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(766, 513);
			this->Controls->Add(this->chartDiagram);
			this->Controls->Add(this->btnGraph);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"GraphicForm";
			this->Text = L"Диаграмма";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->chartDiagram))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void btnGraph_Click(System::Object^ sender, System::EventArgs^ e);
	
};
}
