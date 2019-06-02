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
    public class Building : BindableBase
    {
        #region Private Fields

        private int id;
        private int cityID;
        private int? uIStateID;

        private string name;
        private string zipCode;
        private string address;
        private string streetAddress;
        private string describtion;

        private bool isDeleted;

        private City city;
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
        [ForeignKey("City")]
        [Column(name: "CityID", TypeName = "INT")]
        public int CityID
        {
            get { return this.cityID; }
            set { SetProperty(ref this.cityID, value, "CityID"); }
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
        [Column(name: "ZipCode", TypeName = "NVARCHAR(MAX)")]
        public string ZipCode
        {
            get { return this.zipCode; }
            set { SetProperty(ref this.zipCode, value, "ZipCode"); }
        }
        [Column(name: "Address", TypeName = "NVARCHAR(MAX)")]
        public string Address
        {
            get { return this.address; }
            set { SetProperty(ref this.address, value, "Address"); }
        }
        [Column(name: "StreetAddress", TypeName = "NVARCHAR(MAX)")]
        public string StreetAddress
        {
            get { return this.streetAddress; }
            set { SetProperty(ref this.streetAddress, value, "StreetAddress"); }
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

        public virtual City City
        {
            get { return this.city; }
            set { SetProperty(ref this.city, value, "City"); }
        }
        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<Floor> Floors { get; set; }
        public virtual ICollection<EmsDevice> EmsDevices { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Building()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
