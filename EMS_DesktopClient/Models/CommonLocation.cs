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
    public partial class CommonLocation : BindableBase
    {
        #region Private Fields

        private int id;
        private int buildingID;
        private int? uIStateID;

        private string name;
        private string describtion;

        private bool isDeleted;

        private Building building;
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
        [Column(name: "Describtion", TypeName = "NVARCHAR(MAX)")]
        public string Describtion
        {
            get { return this.describtion; }
            set { SetProperty(ref this.describtion, value, "Describtion"); }
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
        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<Meter> Sections { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public CommonLocation()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
