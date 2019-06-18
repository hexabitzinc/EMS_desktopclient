using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace EMS_DesktopClient.Services
{
    class DialogService : IDialogService
    {
        public string ShowOpenFileDialog(string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            if (ofd.ShowDialog().Value)
                return ofd.FileName;
            return string.Empty;
        }

        public string ShowSaveFileDialog(string filter)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = filter;
            if (sfd.ShowDialog().Value)
                return sfd.FileName;
            return string.Empty;
        }
    }
}
