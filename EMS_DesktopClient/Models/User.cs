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

        private string name;
        private string username;
        private string password;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
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
