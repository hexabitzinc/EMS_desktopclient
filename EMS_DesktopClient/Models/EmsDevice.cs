using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Models
{
    public partial class EmsDevice : BindableBase
    {
        #region Private Fields

        private int id;
        private int buildingID;
        private int emsParameterID;
        private int emsSettingID;
        private int consumerID;
        private int? uIStateID;

        private string name;
        private string serialNumber;
        private string notes;

        private bool isDeleted;

        private Building building;
        private EmsParameter emsParameter;
        private EmsSetting emsSetting;
        private Consumer consumer;
        private UIState uIState;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }
        [ForeignKey("Building")]
        [Column(name: "BuildingID", TypeName = "INT")]
        public int BuildingID
        {
            get { return this.buildingID; }
            set { SetProperty(ref this.buildingID, value, "BuildingID"); }
        }
        [ForeignKey("EmsParameter")]
        [Column(name: "EmsParameterID", TypeName = "INT")]
        public int EmsParameterID
        {
            get { return this.emsParameterID; }
            set { SetProperty(ref this.emsParameterID, value, "EmsParameterID"); }
        }
        [ForeignKey("EmsSetting")]
        [Column(name: "EmsSettingID", TypeName = "INT")]
        public int EmsSettingID
        {
            get { return this.emsSettingID; }
            set { SetProperty(ref this.emsSettingID, value, "EmsSettingID"); }
        }
        [ForeignKey("Consumer")]
        [Column(name: "ConsumerID", TypeName = "INT")]
        public int ConsumerID
        {
            get { return this.consumerID; }
            set { SetProperty(ref this.consumerID, value, "ConsumerID"); }
        }
        [ForeignKey("UIState")]
        [Column(name: "UIStateID", TypeName = "INT")]
        public int? UIStateID
        {
            get { return this.uIStateID; }
            set { SetProperty(ref this.uIStateID, value, "UIStateID"); }
        }

        [Column(name: "Name", TypeName = "NVARCHAR(MAX)")]
        public string Name
        {
            get { return this.name; }
            set { SetProperty(ref this.name, value, "Name"); }
        }
        [Column(name: "SerialNumber", TypeName = "NVARCHAR(MAX)")]
        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { SetProperty(ref this.serialNumber, value, "SerialNumber"); }
        }
        [Column(name: "Notes", TypeName = "NVARCHAR(MAX)")]
        public string Notes
        {
            get { return this.notes; }
            set { SetProperty(ref this.notes, value, "Notes"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual Building Building
        {
            get { return this.building; }
            set { SetProperty(ref this.building, value, "Building"); }
        }
        public virtual EmsParameter EmsParameter
        {
            get { return this.emsParameter; }
            set { SetProperty(ref this.emsParameter, value, "EmsParameter"); }
        }
        public virtual EmsSetting EmsSetting
        {
            get { return this.emsSetting; }
            set { SetProperty(ref this.emsSetting, value, "EmsSetting"); }
        }
        public virtual Consumer Consumer
        {
            get { return this.consumer; }
            set { SetProperty(ref this.consumer, value, "Consumer"); }
        }
        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public EmsDevice()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
