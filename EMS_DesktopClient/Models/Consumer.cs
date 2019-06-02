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
    public partial class Consumer : BindableBase
    {
        #region Private Fields

        private int id;
        private int? uIStateID;

        private string firstName;
        private string lastName;
        private string gender;
        private string address;
        private string phone;
        private string otherInformation;
        private string mobile;
        private string email;

        private bool isDeleted;

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
        [ForeignKey("UIState")]
        [Column(name: "UIStateID", TypeName = "INT")]
        public int? UIStateID
        {
            get { return this.uIStateID; }
            set { SetProperty(ref this.uIStateID, value, "UIStateID"); }
        }

        [Column(name: "FirstName", TypeName = "NVARCHAR(MAX)")]
        public string FirstName
        {
            get { return this.firstName; }
            set { SetProperty(ref this.firstName, value, "FirstName"); }
        }
        [Column(name: "LastName", TypeName = "NVARCHAR(MAX)")]
        public string LastName
        {
            get { return this.lastName; }
            set { SetProperty(ref this.lastName, value, "LastName"); }
        }
        [Column(name: "Gender", TypeName = "NVARCHAR(MAX)")]
        public string Gender
        {
            get { return this.gender; }
            set { SetProperty(ref this.gender, value, "Gender"); }
        }
        [Column(name: "Address", TypeName = "NVARCHAR(MAX)")]
        public string Address
        {
            get { return this.address; }
            set { SetProperty(ref this.address, value, "Address"); }
        }
        [Column(name: "Phone", TypeName = "NVARCHAR(MAX)")]
        public string Phone
        {
            get { return this.phone; }
            set { SetProperty(ref this.phone, value, "Phone"); }
        }
        [Column(name: "OtherInformation", TypeName = "NVARCHAR(MAX)")]
        public string OtherInformation
        {
            get { return this.otherInformation; }
            set { SetProperty(ref this.otherInformation, value, "OtherInformation"); }
        }
        [Column(name: "Mobile", TypeName = "NVARCHAR(MAX)")]
        public string Mobile
        {
            get { return this.mobile; }
            set { SetProperty(ref this.mobile, value, "Mobile"); }
        }
        [Column(name: "Email", TypeName = "NVARCHAR(MAX)")]
        public string Email
        {
            get { return this.email; }
            set { SetProperty(ref this.email, value, "Email"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<EmsDevice> EmsDevices { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Consumer()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
