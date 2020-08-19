using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using OfficeOpenXml;
using System.Linq;
using OfficeOpenXml.Style;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Fp.Services{

    public interface IExportService
    {
        string exportExcel<T>(
                                 HttpRequest request,
                                 string worksheet_label,
                                 bool toggle,
                                 IEnumerable<T> list1);

 
    }
    public class ExportService: IExportService
    {

        IHostingEnvironment _hostingEnvironment;
        public ExportService(IHostingEnvironment hostingEnvironment){
            _hostingEnvironment = hostingEnvironment;
        }
        public string exportExcel<T>(HttpRequest Request,
                                                string worksheet_label, 
                                                bool toggle, 
                                                IEnumerable<T> list1)
        {
        
            

            //2.name an excel file
            string folder = _hostingEnvironment.WebRootPath;
            string excelName = "export_"+worksheet_label+".xlsx";

            //3.name a download link
            string downloadUrl = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, excelName);

            //4. create a file instance
            FileInfo file = new FileInfo(Path.Combine(folder, excelName));
            if (file.Exists)
            {
                file.Delete();
                file = new FileInfo(Path.Combine(folder, excelName));
            }

            //5. setup current culture as english
            CultureInfo.CurrentCulture = new CultureInfo("en-EN");

            //6. create a memory stream
            var stream = new MemoryStream();

            //7. create excel package object from the file instance
            using (var package = new ExcelPackage(file))
            {
                var worksheet = package.Workbook.Worksheets.Add(worksheet_label);

                //8. get property names
                //string text = "";
                string[] headers = list1.First().GetType().GetProperties().Select(x => x.Name).ToArray();
                //8.1 replace all underscore with space
                for(int i = 0;i< headers.Length;i++){
                   headers[i]=  Regex.Replace(headers[i], @"[_]", " ");
                }
                //9. create a header row
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Style.Font.Size = 14;
                    worksheet.Cells[1, i + 1].Value = headers[i];
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    worksheet.Cells[1, i + 1].Style.Border
                    .BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                }
                //10. set the header row color
                worksheet.Row(1).Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Row(1).Style.Fill.BackgroundColor.SetColor(Color.FromArgb(130, 130, 130));

                //11. fill excel rows
                int row = 2;

                foreach (Object o in list1)
                {
                    Type t = o.GetType();
                    PropertyInfo[] props = t.GetProperties();
                    int col = 1;
                    foreach (var prop in props)
                    {

                        worksheet.Cells[row, col].Style.Font.Size = 12;
                        worksheet.Cells[row, col].Style.Font.Bold = true;
                        worksheet.Cells[row, col].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        worksheet.Cells[row, col].Value = prop.GetValue(o);
                        col++;

                    }
                    row++;


                }//endloop



                


                //12. automatically adjust column size 
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                //13. save excel package file 
                package.Save();

                //14. return filename 

                return  downloadUrl;
               

            }//end using

        }//ef
    }//ec
}//en