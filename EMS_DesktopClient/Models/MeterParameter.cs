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
    public partial class MeterParameter : BindableBase
    {
        #region Private Fields

        private int id;
        private int parameterGroupID;
        private int parameterID;
        private int? uIStateID;

        private bool isDeleted;

        private ParameterGroup parameterGroup;
        private Parameter parameter;
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
        [ForeignKey("ParameterGroup")]
        [Column(name: "ParameterGroupID", TypeName = "INT")]
        public int ParameterGroupID
        {
            get { return this.parameterGroupID; }
            set { SetProperty(ref this.parameterGroupID, value, "GroupID"); }
        }
        [ForeignKey("Parameter")]
        [Column(name: "ParameterID", TypeName = "INT")]
        public int ParameterID
        {
            get { return this.parameterID; }
            set { SetProperty(ref this.parameterID, value, "ParameterID"); }
        }
        [ForeignKey("UIState")]
        [Column(name: "UIStateID", TypeName = "INT")]
        public int? UIStateID
        {
            get { return this.uIStateID; }
            set { SetProperty(ref this.uIStateID, value, "UIStateID"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual ParameterGroup ParameterGroup
        {
            get { return this.parameterGroup; }
            set { SetProperty(ref this.parameterGroup, value, "ParameterGroup"); }
        }
        public virtual Parameter Parameter
        {
            get { return this.parameter; }
            set { SetProperty(ref this.parameter, value, "Parameter"); }
        }
        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public MeterParameter()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
