using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using FlyCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance.Implementations;

namespace FlyCoreProje.Controllers
{
    public class ExcelController : Controller
    {
     
        public readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }
      
        public IActionResult Index()
        {
        
            return View();
        }
        public List<DestinationModel>DestinationList()
        {
      List<DestinationModel> destinationModels = new List<DestinationModel>();
        using(var c=new Context())
        {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    Gun = x.Gun,
                    Price = x.Price,
                   Capacity = x.Capacity
                }).ToList();
        }
        return destinationModels;
     }
    public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","YeniExcel.xlsx");
           
        }
          public IActionResult DestinationExcelReport() 
        {
            using(var workBook=new XLWorkbook())
            {
                //Static oluşturma işlemi
                var workSheet = workBook.Worksheets.Add("Seyehat Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Tarih";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Koltuk Sayısı";

                int rowCount = 2;
                foreach(var item in DestinationList())
                {
                //Dinamik oluşturma işlemi
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.Gun;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                    
                }
                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }

}
