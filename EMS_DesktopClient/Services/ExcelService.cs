using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.IO;

namespace EMS_DesktopClient.Services
{
    class ExcelService : IExcelService
    {
        public async Task ExportExcelFile(ICollection<dynamic> collection, ExcelType type, byte[] template, string path)
        {
            switch (type)
            {
                case ExcelType.Appointments:
                    await this.exportAppointmentsExcelFile(collection, template, path);
                    break;
                case ExcelType.FinanceDetails:
                    await this.exportFinanceDetailsExcelFile(collection, template, path);
                    break;
                case ExcelType.Patients:
                    await this.exportPatientsExcelFile(collection, template, path);
                    break;
                case ExcelType.Anthroposcopies:
                    await this.exportVisitsExcelFile(collection, template, path);
                    break;
                case ExcelType.DentalReviews:
                    await this.exportDentalReviewsExcelFile(collection, template, path);
                    break;
                default:
                    return;
            }
        }

        #region Private Methods

        private async Task exportAppointmentsExcelFile(ICollection<dynamic> collection, byte[] template, string path)
        {
            await Task.Run(() =>
            {
                File.WriteAllBytes(path, template);
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(path);
                Excel.Worksheet worksheet = book.Worksheets[1];

                int index = 11;
                int i = 1;
                foreach (var appointment in collection)
                {
                    worksheet.Range[$"A{index}"].Value2 = i++.ToString();
                    worksheet.Range[$"B{index}"].Value2 = appointment.ID;
                    worksheet.Range[$"C{index}"].Value2 = appointment.Patient.FirstName;
                    worksheet.Range[$"D{index}"].Value2 = appointment.Patient.LastName;
                    worksheet.Range[$"E{index}"].Value2 = appointment.AppointmentDate?.ToShortDateString();
                    worksheet.Range[$"F{index++}"].Value2 = appointment.Notes;
                }

                book.Save();
                book.Close();
                app.Quit();
            });
        }
        private async Task exportFinanceDetailsExcelFile(ICollection<dynamic> collection, byte[] template, string path)
        {
            await Task.Run(() =>
            {
                File.WriteAllBytes(path, template);
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(path);
                Excel.Worksheet worksheet = book.Worksheets[1];

                int index = 11;
                int i = 1;
                foreach (var financeDetail in collection)
                {
                    worksheet.Range[$"A{index}"].Value2 = i.ToString();
                    worksheet.Range[$"B{index}"].Value2 = financeDetail.PatientID;
                    worksheet.Range[$"C{index}"].Value2 = financeDetail.FirstName;
                    worksheet.Range[$"D{index}"].Value2 = financeDetail.LastName;
                    worksheet.Range[$"E{index}"].Value2 = financeDetail.VisitDate?.ToShortDateString();
                    worksheet.Range[$"F{index}"].Value2 = financeDetail.VisitType;
                    worksheet.Range[$"G{index}"].Value2 = financeDetail.Value.ToString();
                    worksheet.Range[$"H{index}"].Value2 = financeDetail.InsuranceCompany;
                    worksheet.Range[$"I{index++}"].Value2 = financeDetail.InsuranceDocumentSerialNumber;
                }

                book.Save();
                book.Close();
                app.Quit();
            });
        }
        private async Task exportPatientsExcelFile(ICollection<dynamic> collection, byte[] template, string path)
        {
            await Task.Run(() =>
            {
                File.WriteAllBytes(path, template);
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(path);
                Excel.Worksheet worksheet = book.Worksheets[1];

                int index = 11;
                int i = 1;
                foreach (var patient in collection)
                {
                    worksheet.Range[$"A{index}"].Value2 = i.ToString();
                    worksheet.Range[$"B{index}"].Value2 = patient.ID.ToString();
                    worksheet.Range[$"C{index}"].Value2 = patient.SerialNumber;
                    worksheet.Range[$"D{index}"].Value2 = patient.FirstName;
                    worksheet.Range[$"E{index}"].Value2 = patient.LastName;
                    worksheet.Range[$"F{index}"].Value2 = patient.FatherName;
                    worksheet.Range[$"G{index}"].Value2 = patient.MotherName;
                    worksheet.Range[$"H{index}"].Value2 = patient.Gender;
                    worksheet.Range[$"I{index}"].Value2 = patient.DateOfBirth?.Year.ToString();
                    worksheet.Range[$"J{index}"].Value2 = patient.MaritalStatus;
                    worksheet.Range[$"K{index}"].Value2 = patient.Phone;
                    worksheet.Range[$"L{index}"].Value2 = patient.Mobile;
                    worksheet.Range[$"M{index}"].Value2 = patient.Address;
                    worksheet.Range[$"N{index}"].Value2 = patient.RegisteringDate?.ToShortDateString();
                    worksheet.Range[$"O{index++}"].Value2 = patient.Notes;
                }

                book.Save();
                book.Close();
                app.Quit();
            });
        }
        private async Task exportVisitsExcelFile(ICollection<dynamic> collection, byte[] template, string path)
        {
            await Task.Run(() =>
            {
                File.WriteAllBytes(path, template);
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(path);
                Excel.Worksheet worksheet = book.Worksheets[1];

                int index = 16;
                int i = 1;

                dynamic patient = collection.ElementAt(0).Visits.ElementAt(0).Patient;
                worksheet.Range["D10"].Value2 = patient.ID.ToString();
                worksheet.Range["F10"].Value2 = patient.SerialNumber;
                worksheet.Range["D11"].Value2 = patient.FirstName;
                worksheet.Range["F11"].Value2 = patient.LastName;
                worksheet.Range["H11"].Value2 = patient.FatherName;
                worksheet.Range["J11"].Value2 = patient.MotherName;
                worksheet.Range["H10"].Value2 = patient.Gender;
                worksheet.Range["D12"].Value2 = patient.DateOfBirth?.Year.ToString();
                worksheet.Range["J10"].Value2 = patient.MaritalStatus;
                worksheet.Range["H12"].Value2 = patient.Phone;
                worksheet.Range["F12"].Value2 = patient.Mobile;
                worksheet.Range["D13"].Value2 = patient.Address;
                worksheet.Range["J12"].Value2 = patient.RegisteringDate?.ToShortDateString();
                worksheet.Range["H13"].Value2 = patient.Notes;
                foreach (var anthroposcopy in collection)
                {
                    worksheet.Range[$"A{index}"].Value2 = i.ToString();
                    worksheet.Range[$"B{index}"].Value2 = anthroposcopy.ID;
                    worksheet.Range[$"C{index}"].Value2 = anthroposcopy.Date?.ToShortDateString();
                    worksheet.Range[$"D{index}"].Value2 = anthroposcopy.MainComplaint;
                    worksheet.Range[$"F{index}"].Value2 = anthroposcopy.Symptoms;
                    worksheet.Range[$"H{index}"].Value2 = anthroposcopy.Diagnosis;
                    worksheet.Range[$"J{index++}"].Value2 = anthroposcopy.Notes;
                }

                book.Save();
                book.Close();
                app.Quit();
            });
        }
        private async Task exportDentalReviewsExcelFile(ICollection<dynamic> collection, byte[] template, string path)
        {
            await Task.Run(() =>
            {
                File.WriteAllBytes(path, template);
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(path);
                Excel.Worksheet worksheet = book.Worksheets[1];

                int index = 16;
                int i = 1;

                dynamic patient = collection.ElementAt(0).Visits.ElementAt(0).Patient;
                worksheet.Range["D10"].Value2 = patient.ID.ToString();
                worksheet.Range["F10"].Value2 = patient.SerialNumber;
                worksheet.Range["D11"].Value2 = patient.FirstName;
                worksheet.Range["F11"].Value2 = patient.LastName;
                worksheet.Range["H11"].Value2 = patient.FatherName;
                worksheet.Range["J11"].Value2 = patient.MotherName;
                worksheet.Range["H10"].Value2 = patient.Gender;
                worksheet.Range["D12"].Value2 = patient.DateOfBirth?.Year.ToString();
                worksheet.Range["J10"].Value2 = patient.MaritalStatus;
                worksheet.Range["H12"].Value2 = patient.Phone;
                worksheet.Range["F12"].Value2 = patient.Mobile;
                worksheet.Range["D13"].Value2 = patient.Address;
                worksheet.Range["J12"].Value2 = patient.RegisteringDate?.ToShortDateString();
                worksheet.Range["H13"].Value2 = patient.Notes;
                foreach (var dentalReview in collection)
                {
                    worksheet.Range[$"A{index}", $"B{index}"].Value2 = i.ToString();
                    worksheet.Range[$"C{index}", $"E{index}"].Merge(true);
                    worksheet.Range[$"C{index}", $"E{index}"].Value2 = dentalReview.Cost;
                    worksheet.Range[$"F{index}", $"G{index}"].Value2 = dentalReview.Date?.ToShortDateString();
                    worksheet.Range[$"H{index}", $"K{index}"].Merge(true);
                    worksheet.Range[$"H{index}", $"K{index}"].Value2 = dentalReview.Notes;
                }

                book.Save();
                book.Close();
                app.Quit();
            });
        }

        #endregion
    }
}
