using PraceSeStudenty_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraceSeStudenty_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region prace s cistou DB
            PraceSeStudenty ds = new PraceSeStudenty();
            int idStudenta= ds.ZalozStudenta("Jan", "Sobolciak", 8708080808); // INSERT
            
            ds.UpravStudentaDleID(idStudenta,"Salam");          // UPDATE dle ID
            ds.UpravStudentaDleRC(8708080808, "Salam");         // UPDATE dle RC
            ds.VymazStudentaDleID(155);                         // DELETE dle ID
            #endregion
            Console.ReadKey();
        }
    }
}
