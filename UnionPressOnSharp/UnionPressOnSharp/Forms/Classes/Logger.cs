using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace UnionPressOnSharp.Forms.Classes
{
    public class Logger
    {
        public async void Log(string contentString, string namePlace, string nameEvent, string numberLine)
        {
            //contentString - строка содержащая осн инф
            //namePlace - местонахождение
            //например [системное время]\\\Запуск программы состоялася\\\MainForm.cs\\\MainFormLoad\\\37

            string border = @"\\\";
            string path = "UnionPressLog.log";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.UTF8))
            {
                await writer.WriteLineAsync("[" + DateTime.Now.ToString() + "]" + border +
                    contentString + border + namePlace + border + nameEvent + border + numberLine);
                writer.Close();
            }


        }
    }
}
