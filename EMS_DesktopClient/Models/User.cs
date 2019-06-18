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
    public class User : BindableBase
    {
        #region Private Fields

        private int id;
        private int userTypeID;

        private string name;
        private string username;
        private string password;
        private string gender;
        private string address;
        private string phone;
        private string mobile;
        private string email;
        private string otherInformation;

        private UserType userType;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }
        [ForeignKey("UserType")]
        [Column(name: "UserTypeID", TypeName = "INT")]
        public int UserTypeID
        {
            get { return this.userTypeID; }
            set { SetProperty(ref this.userTypeID, value, "UserTypeID"); }
        }

        [Column(name: "Name", TypeName = "NVARCHAR(MAX)")]
        public string Name
        {
            get { return this.name; }
            set { SetProperty(ref this.name, value, "Name"); }
        }
        [Column(name: "Username", TypeName = "NVARCHAR(MAX)")]
        public string Username
        {
            get { return this.username; }
            set { SetProperty(ref this.username, value, "Username"); }
        }
        [Column(name: "Password", TypeName = "NVARCHAR(MAX)")]
        public string Password
        {
            get { return this.password; }
            set { SetProperty(ref this.password, value, "Password"); }
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
        [Column(name: "OtherInformation", TypeName = "NVARCHAR(MAX)")]
        public string OtherInformation
        {
            get { return this.otherInformation; }
            set { SetProperty(ref this.otherInformation, value, "OtherInformation"); }
        }

        public virtual UserType UserType
        {
            get { return this.userType; }
            set { SetProperty(ref this.userType, value, "UserType"); }
        }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public User()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
