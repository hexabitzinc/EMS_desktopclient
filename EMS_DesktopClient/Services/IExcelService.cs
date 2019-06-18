using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Services
{
    public interface IExcelService
    {
        Task ExportExcelFile(ICollection<dynamic> collection, ExcelType type, byte[] template, string path);
    }
}
