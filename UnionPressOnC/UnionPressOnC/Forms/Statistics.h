#pragma once

namespace UnionPressOnC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Statistics
	/// </summary>
	public ref class Statistics : public System::Windows::Forms::Form
	{
	public:
		Statistics(void)
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
		~Statistics()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^ gridStatistics;
	protected:
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Column1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Column2;

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
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle1 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle4 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle5 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle2 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle3 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			this->gridStatistics = (gcnew System::Windows::Forms::DataGridView());
			this->Column1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column2 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridStatistics))->BeginInit();
			this->SuspendLayout();
			// 
			// gridStatistics
			// 
			this->gridStatistics->AllowUserToAddRows = false;
			this->gridStatistics->AllowUserToDeleteRows = false;
			this->gridStatistics->AllowUserToResizeColumns = false;
			this->gridStatistics->AllowUserToResizeRows = false;
			this->gridStatistics->BackgroundColor = System::Drawing::SystemColors::Control;
			this->gridStatistics->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->gridStatistics->CellBorderStyle = System::Windows::Forms::DataGridViewCellBorderStyle::None;
			this->gridStatistics->ClipboardCopyMode = System::Windows::Forms::DataGridViewClipboardCopyMode::Disable;
			dataGridViewCellStyle1->Alignment = System::Windows::Forms::DataGridViewContentAlignment::MiddleLeft;
			dataGridViewCellStyle1->BackColor = System::Drawing::Color::Transparent;
			dataGridViewCellStyle1->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			dataGridViewCellStyle1->ForeColor = System::Drawing::SystemColors::WindowText;
			dataGridViewCellStyle1->SelectionBackColor = System::Drawing::SystemColors::Highlight;
			dataGridViewCellStyle1->SelectionForeColor = System::Drawing::SystemColors::HighlightText;
			dataGridViewCellStyle1->WrapMode = System::Windows::Forms::DataGridViewTriState::True;
			this->gridStatistics->ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this->gridStatistics->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->gridStatistics->ColumnHeadersVisible = false;
			this->gridStatistics->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(2) {
				this->Column1,
					this->Column2
			});
			dataGridViewCellStyle4->Alignment = System::Windows::Forms::DataGridViewContentAlignment::MiddleLeft;
			dataGridViewCellStyle4->BackColor = System::Drawing::SystemColors::Control;
			dataGridViewCellStyle4->Font = (gcnew System::Drawing::Font(L"Archive", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			dataGridViewCellStyle4->ForeColor = System::Drawing::SystemColors::ControlText;
			dataGridViewCellStyle4->SelectionBackColor = System::Drawing::SystemColors::Highlight;
			dataGridViewCellStyle4->SelectionForeColor = System::Drawing::SystemColors::Control;
			dataGridViewCellStyle4->WrapMode = System::Windows::Forms::DataGridViewTriState::False;
			this->gridStatistics->DefaultCellStyle = dataGridViewCellStyle4;
			this->gridStatistics->Dock = System::Windows::Forms::DockStyle::Fill;
			this->gridStatistics->GridColor = System::Drawing::SystemColors::Control;
			this->gridStatistics->Location = System::Drawing::Point(0, 0);
			this->gridStatistics->MultiSelect = false;
			this->gridStatistics->Name = L"gridStatistics";
			this->gridStatistics->ReadOnly = true;
			this->gridStatistics->RowHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->gridStatistics->RowHeadersWidth = 80;
			dataGridViewCellStyle5->BackColor = System::Drawing::Color::White;
			this->gridStatistics->RowsDefaultCellStyle = dataGridViewCellStyle5;
			this->gridStatistics->Size = System::Drawing::Size(766, 519);
			this->gridStatistics->TabIndex = 71;
			// 
			// Column1
			// 
			dataGridViewCellStyle2->BackColor = System::Drawing::Color::Transparent;
			dataGridViewCellStyle2->SelectionBackColor = System::Drawing::Color::Transparent;
			this->Column1->DefaultCellStyle = dataGridViewCellStyle2;
			this->Column1->HeaderText = L"";
			this->Column1->Name = L"Column1";
			this->Column1->ReadOnly = true;
			this->Column1->Width = 400;
			// 
			// Column2
			// 
			dataGridViewCellStyle3->BackColor = System::Drawing::Color::Transparent;
			dataGridViewCellStyle3->SelectionBackColor = System::Drawing::Color::Transparent;
			this->Column2->DefaultCellStyle = dataGridViewCellStyle3;
			this->Column2->HeaderText = L"";
			this->Column2->Name = L"Column2";
			this->Column2->ReadOnly = true;
			this->Column2->Width = 200;
			// 
			// Statistics
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(766, 519);
			this->Controls->Add(this->gridStatistics);
			this->Name = L"Statistics";
			this->Text = L"Статистика";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->gridStatistics))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}
