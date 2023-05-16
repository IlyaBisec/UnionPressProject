#include <iostream>
#include <fstream>
#include <time.h>

    public class Logger
    {

    public: void Log(std::string contentString, std::string namePlace, std::string nameEvent, std::string numberLine)
        {
            std::string border = "\\\\";
            std::string path = "UnionPressLog.log";

            const time_t tm = time(nullptr);
            char buf_time[64];
            strftime(buf_time, std::size(buf_time), "%d.%m.%Y %H:%M:%S", localtime(&tm));

            std::ofstream writer;

            writer.open(path);
            if (writer.is_open())
            {
                writer << "["<< buf_time <<"]" << border +
                    contentString + border + namePlace + border + nameEvent + border + numberLine << std::endl;
            }
            writer.close();
        }

    };



