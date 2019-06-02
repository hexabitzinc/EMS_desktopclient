using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.VeiwModels
{
    public class ViewMainWindowViewModel : BindableBase
    {
        #region Private Fields

        private int id;

        #endregion

        #region Public Properties

        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }

        #endregion

        #region Commands

        #region Commands Declarations



        #endregion

        #region Commands Functions



        #endregion

        #endregion

        #region Constructor

        public ViewMainWindowViewModel()
        {

        }

        #endregion
    }
}
