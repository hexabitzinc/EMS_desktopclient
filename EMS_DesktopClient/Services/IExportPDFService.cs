using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Services
{
    public interface IExportPDFService
    {
        Task ExportPDF(dynamic information, ExportPDFType exportPDFType, ExportPDFOptions options);
    }
}
