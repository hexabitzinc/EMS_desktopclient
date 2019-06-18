using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Services
{
    public class ExportPDFService : IExportPDFService
    {
        public async Task ExportPDF(dynamic information, ExportPDFType exportPDFType, ExportPDFOptions options)
        {
            switch (exportPDFType)
            {
                case ExportPDFType.Analysis:
                    await exportPDF_Analysis(information, options);
                    break;
                case ExportPDFType.ConsumptionReport:
                    await exportPDF_MedicalReport(information, options);
                    break;
                default:
                    return;
            }
        }

        #region Private Methods

        private async Task exportPDF_Prescription(dynamic information, ExportPDFOptions options)
        {

        }
        private async Task exportPDF_MedicalReport(dynamic information, ExportPDFOptions options)
        {

        }

        #endregion
    }
}
