using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAct
{
    public class CreateAct
    {
        public static void Create(int clientNUMS,string NN, string LD, string NameZak, string Uradr, string INN, string BIK, string OGRN, string RS, string KS, string KPP, string NumDog, string DatOfCre, string Kol, string SUM, string NumToWrd,string LocPath)
        {
            int nune = 1;
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = default(Microsoft.Office.Interop.Excel.Workbook);
            wb = xlapp.Workbooks.Open(LocPath);
            while (nune <= clientNUMS)
            {
                wb.Worksheets[nune].Cells.Replace("@@NN", NN);
                wb.Worksheets[nune].Cells.Replace("@@LD", LD);
                wb.Worksheets[nune].Cells.Replace("@@NameZak", NameZak);

               //wb.Worksheets[nune].Cells.Replace("@@Uradr", Uradr);
               //wb.Worksheets[nune].Cells.Replace("@@INN", INN);
               //wb.Worksheets[nune].Cells.Replace("@@BIK", BIK);
               //wb.Worksheets[nune].Cells.Replace("@@OGRN", OGRN);
               //wb.Worksheets[nune].Cells.Replace("@@RS", RS);
               //wb.Worksheets[nune].Cells.Replace("@@KS", KS);
               //wb.Worksheets[nune].Cells.Replace("@@KPP", KPP);

                wb.Worksheets[nune].Cells.Replace("@@NumDog", NumDog);
                wb.Worksheets[nune].Cells.Replace("@@DatOfCre", DatOfCre);
                wb.Worksheets[nune].Cells.Replace("@@Kol", Kol);
                wb.Worksheets[nune].Cells.Replace("@@SUM", SUM);
                wb.Worksheets[nune].Cells.Replace("@@NumToWord", NumToWrd);

                if (OGRN == "")                                                              //if OGRN fild is empty than replace tag in template "@@OGRN" else do same but add "ОГРН: "
                { wb.Worksheets[nune].Cells.Replace("@@OGRN", OGRN); }
                else { wb.Worksheets[nune].Cells.Replace("@@OGRN", "ОГРН: " + OGRN); }

                if (INN == "")                                                               //if INN fild is empty than replace tag in template "@@INN" else do same but add "ИНН: "
                { wb.Worksheets[nune].Cells.Replace("@@INN", INN); }
                else { wb.Worksheets[nune].Cells.Replace("@@INN", "ИНН: " + INN); }

                if (BIK == "")                                                               //if BIK fild is empty than replace tag in template "@@BIK" else do same but add "БИК: "
                { wb.Worksheets[nune].Cells.Replace("@@BIK", BIK); }
                else { wb.Worksheets[nune].Cells.Replace("@@BIK", "БИК: " + BIK); }

                if (Uradr == "")                                                             //if URadr fild is empty than replace tag "@@URadr" else do same but add "Юридический адрес: "
                { wb.Worksheets[nune].Cells.Replace("@@URadr", Uradr); }
                else { wb.Worksheets[nune].Cells.Replace("@@URadr", "Юридический адрес:" + Uradr); }

                if (RS == "")                                                                //if Rs fild is empty than replace tag "@@RS" else do same but add "Р/С: "
                { wb.Worksheets[nune].Cells.Replace("@@RS", RS); }
                else { wb.Worksheets[nune].Cells.Replace("@@RS", "Р/С:" + RS); }

                if (KS == "")                                                                //if Ks fild is empty than replace tag "@@KS" else do same but add "К/С: "
                { wb.Worksheets[nune].Cells.Replace("@@KS", KS); }
                else { wb.Worksheets[nune].Cells.Replace("@@KS", "К/С:" + KS); }

                if (KPP == "")                                                               //if KPP fild is empty than replace tag "@@KPP" else do same but add "КПП: "
                { wb.Worksheets[nune].Cells.Replace("@@KPP", KPP); }
                else { wb.Worksheets[nune].Cells.Replace("@@KPP", "КПП:" + KPP); }

                nune++;
            }
            wb.SaveAs(@"C:\Act\ACT"+ NameZak + ".xls");
            wb.Close();
        }
    }
}
