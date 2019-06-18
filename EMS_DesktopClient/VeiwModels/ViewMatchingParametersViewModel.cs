using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.VeiwModels
{
    public class ViewMatchingParametersViewModel : BindableBase
    {
        #region Private Fields

        private ICollection<dynamic> excelParametersCollection;
        private dynamic selectedExcelParameter;
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

        public DelegateCommand SelectExcelParametersCommand { get; set; }
        public DelegateCommand DeleteSelectedExcelParameterCommand { get; set; }
        public DelegateCommand PrintSelectedExcelParameterCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand SaveAndCloseCommand { get; set; }

        #endregion

        #region Commands Functions

        private bool CanExecuteSelectExcelParametersCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteSelectExcelParametersCommand()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region Constructor

        public ViewMatchingParametersViewModel()
        {
            this.SelectExcelParametersCommand = new DelegateCommand(ExecuteSelectExcelParametersCommand, CanExecuteSelectExcelParametersCommand);
        }

        #endregion
    }
}
