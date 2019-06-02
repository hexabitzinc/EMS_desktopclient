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
    public partial class Setting : BindableBase
    {
        #region Private Fields

        private int id;

        private string details;
        private string value;
        private string type;

        private bool isDeleted;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }

        [Column(name: "Details", TypeName = "NVARCHAR(MAX)")]
        public string Details
        {
            get { return this.details; }
            set { SetProperty(ref this.details, value, "Details"); }
        }
        [Column(name: "Value", TypeName = "NVARCHAR(MAX)")]
        public string Value
        {
            get { return this.value; }
            set { SetProperty(ref this.value, value, "Value"); }
        }
        [Column(name: "Type", TypeName = "NVARCHAR(MAX)")]
        public string Type
        {
            get { return this.type; }
            set { SetProperty(ref this.type, value, "Type"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Setting()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
