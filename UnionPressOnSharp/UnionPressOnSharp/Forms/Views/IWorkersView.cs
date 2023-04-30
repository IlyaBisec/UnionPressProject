using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnionPressOnSharp.Forms.Views
{
   public interface IWorkersView
   {
        //Поля
        string WorkersSurname { get; set; }
        string WorkersName { get; set; }
        string WorkersFatherName { get; set; }
        string WorkersSpecial { get; set; }
        string WorkersNumber { get; set; }

        string SearchValue { get; set; }
        bool isEditData { get; set; }
        bool isSuccessful { get; set; }
        string Message { get; set; }

        //События
        event EventHandler SearchDataEvent;
        event EventHandler AddNewDataEvent;
        event EventHandler EditDataEvent;
        event EventHandler DeleteDataEvent;
        event EventHandler SaveDataEvent;
        event EventHandler CancelEvent;

        //Методы
        void SetWorkersListBindingSource(BindingSource workerList);
        void Show();


    }
}
