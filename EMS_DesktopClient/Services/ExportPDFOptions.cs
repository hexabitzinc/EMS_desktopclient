using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Services
{
    public enum ExportPDFOptions
    {
        None = 0x0,
        ShowUserDetails = 0x1,
        ShowConsumerDetails = 0x2,
        ShowAllDetails = ShowUserDetails | ShowConsumerDetails
    }
}
