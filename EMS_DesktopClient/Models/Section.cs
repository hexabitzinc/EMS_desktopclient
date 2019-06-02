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
    public partial class Section : BindableBase
    {
        #region Private Fields

        private int id;
        private int floorID;
        private int? uIStateID;

        private string name;
        private string describtion;

        private bool isDeleted;

        private Floor floor;
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
        [ForeignKey("Floor")]
        [Column(name: "FloorID", TypeName = "INT")]
        public int FloorID
        {
            get { return this.floorID; }
            set { SetProperty(ref this.floorID, value, "FloorID"); }
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

        public virtual Floor Floor
        {
            get { return this.floor; }
            set { SetProperty(ref this.floor, value, "Floor"); }
        }
        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Section()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
