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
    public partial class Memo : BindableBase
    {
        #region Private Fields

        private int id;
        private int? uIStateID;

        private string text;
        private DateTime date;

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

        [Column(name: "Text", TypeName = "NVARCHAR(MAX)")]
        public string Text
        {
            get { return this.text; }
            set { SetProperty(ref this.text, value, "Text"); }
        }
        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date
        {
            get { return this.date; }
            set { SetProperty(ref this.date, value, "Date"); }
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
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Memo()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
