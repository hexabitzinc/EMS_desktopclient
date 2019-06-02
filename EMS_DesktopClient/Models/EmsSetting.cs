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
    public partial class EmsSetting : BindableBase
    {
        #region Private Fields

        private int id;
        private int parameterTypeID;

        private string name;
        private string value;
        private string address;

        private bool isDeleted;

        private ParameterType parameterType;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }
        [ForeignKey("ParameterType")]
        [Column(name: "ParameterTypeID", TypeName = "INT")]
        public int ParameterTypeID
        {
            get { return this.parameterTypeID; }
            set { SetProperty(ref this.parameterTypeID, value, "ParameterTypeID"); }
        }

        [Column(name: "Name", TypeName = "NVARCHAR(MAX)")]
        public string Name
        {
            get { return this.name; }
            set { SetProperty(ref this.name, value, "Name"); }
        }
        [Column(name: "Value", TypeName = "NVARCHAR(MAX)")]
        public string Value
        {
            get { return this.value; }
            set { SetProperty(ref this.value, value, "Value"); }
        }
        [Column(name: "Address", TypeName = "NVARCHAR(MAX)")]
        public string Address
        {
            get { return this.address; }
            set { SetProperty(ref this.address, value, "Address"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual ParameterType ParameterType
        {
            get { return this.parameterType; }
            set { SetProperty(ref this.parameterType, value, "ParameterType"); }
        }

        public virtual ICollection<EmsDevice> EmsDevices { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public EmsSetting()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
