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
    public class UserAction : BindableBase
    {
        #region Private Fields

        private int id;
        private int userID;
        private int actionTypeID;

        private DateTime date;
        private string details;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }
        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date
        {
            get { return this.date; }
            set { SetProperty(ref this.date, value, "Date"); }
        }
        [Column(name: "Details", TypeName = "NVARCHAR(MAX)")]
        public string Details
        {
            get { return this.details; }
            set { SetProperty(ref this.details, value, "Details"); }
        }

        [ForeignKey("User")]
        [Column(name: "UserID", TypeName = "INT")]
        public int UserID
        {
            get { return this.userID; }
            set { SetProperty(ref this.userID, value, "UserID"); }
        }
        [ForeignKey("ActionType")]
        [Column(name: "ActionTypeID", TypeName = "INT")]
        public int ActionTypeID
        {
            get { return this.actionTypeID; }
            set { SetProperty(ref this.actionTypeID, value, "ActionTypeID"); }
        }

        public virtual User User { get; set; }
        public virtual ActionType ActionType { get; set; }

        #endregion

        #region Constructor

        public UserAction()
        {

        }

        #endregion
    }
}
