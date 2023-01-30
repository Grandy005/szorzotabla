using System;
using System.IO;

namespace _2023_01_30_ikt
{
    class Program
    {
        static string generateMultiplicationTable(int num)
        {
            string html = "<tr>\n";
            for (int i = 1; i < 11; i++)
            {
                html += $"<td><p>{num * i}</p></td>\n";
            }

            return html;
        }

        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("index.html"))
            {
                string htmlstart = "<!DOCTYPE html>\n <html lang = 'hu'>\n <head>\n <meta charset='utf-8'>\n <link rel='stylesheet' href='styles.css'>\n <link rel='preconnect' href='https://fonts.googleapis.com'>\n <link rel = 'preconnect' href = 'https://fonts.gstatic.com' crossorigin>\n <link href = 'https://fonts.googleapis.com/css2?family=Poppins:ital,wght@1,300&display=swap' rel = 'stylesheet'>\n <title>Szorzótábla</title>\n </head>\n <body>\n <h1>Szorzótábla</h1>\n <table>\n <tbody>\n";
                sw.WriteLine(htmlstart);

                for (int i = 1; i < 11; i++)
                {
                    sw.WriteLine(generateMultiplicationTable(i));
                    string tr = "</tr>\n";
                    sw.WriteLine(tr);
                }

                string htmlend = "</tbody>\n </table>\n </body>\n </html>";
                sw.WriteLine(htmlend);
            }
        }
    }
}
