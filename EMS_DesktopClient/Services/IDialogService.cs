using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Services
{
    public interface IDialogService
    {
        string ShowOpenFileDialog(string filter);
        string ShowSaveFileDialog(string filter);
    }
}
