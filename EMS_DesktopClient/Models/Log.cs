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
    public partial class Log : BindableBase
    {
        #region Private Fields

        private int id;
        private string eventName;
        private DateTime time;

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

        [Column(name: "EventName", TypeName = "NVARCHAR(MAX)")]
        public string EventName
        {
            get { return this.eventName; }
            set { SetProperty(ref this.eventName, value, "EventName"); }
        }
        [Column(name: "Time", TypeName = "DATETIME")]
        public DateTime Time
        {
            get { return this.time; }
            set { SetProperty(ref this.time, value, "Time"); }
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

        public Log()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
