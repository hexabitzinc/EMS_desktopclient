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
    public partial class Apartment : BindableBase
    {
        #region Private Fields

        private int id;
        private int sectionID;
        private int? uIStateID;

        private string name;
        private string type;
        private string address;

        private bool isDeleted;

        private Section section;
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
        [ForeignKey("Section")]
        [Column(name: "SectionID", TypeName = "INT")]
        public int SctionID
        {
            get { return this.sectionID; }
            set { SetProperty(ref this.sectionID, value, "SectionID"); }
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
        [Column(name: "Type", TypeName = "NVARCHAR(MAX)")]
        public string Type
        {
            get { return this.type; }
            set { SetProperty(ref this.type, value, "Type"); }
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

        public virtual Section Section
        {
            get { return this.section; }
            set { SetProperty(ref this.section, value, "Section"); }
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

        public Apartment()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
