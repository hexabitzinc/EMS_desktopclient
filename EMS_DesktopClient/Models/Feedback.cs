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
    public partial class Feedback : BindableBase
    {
        #region Private Fields

        private int id;
        private int? uIStateID;

        private string type;
        private string text;
        private byte[] screenshot;
        private string rating;
        private DateTime date;
        private bool isSent;
        private string reply;
        private string emailAddress;

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

        [Column(name: "Type", TypeName = "NVARCHAR(MAX)")]
        public string Type
        {
            get { return this.type; }
            set { SetProperty(ref this.type, value, "Type"); }
        }
        [Column(name: "Text", TypeName = "NVARCHAR(MAX)")]
        public string Text
        {
            get { return this.text; }
            set { SetProperty(ref this.text, value, "Text"); }
        }
        [Column(name: "Screenshot", TypeName = "VARBINARY(MAX)")]
        public byte[] Screenshot
        {
            get { return this.screenshot; }
            set { SetProperty(ref this.screenshot, value, "Type"); }
        }
        [Column(name: "Rating", TypeName = "NVARCHAR(MAX)")]
        public string Rating
        {
            get { return this.rating; }
            set { SetProperty(ref this.rating, value, "Rating"); }
        }
        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date
        {
            get { return this.date; }
            set { SetProperty(ref this.date, value, "Date"); }
        }
        [Column(name: "IsSent", TypeName = "BIT")]
        public bool IsSent
        {
            get { return this.isSent; }
            set { SetProperty(ref this.isSent, value, "IsSent"); }
        }
        [Column(name: "Reply", TypeName = "NVARCHAR(MAX)")]
        public string Reply
        {
            get { return this.reply; }
            set { SetProperty(ref this.reply, value, "Reply"); }
        }
        [Column(name: "EmailAddress", TypeName = "NVARCHAR(MAX)")]
        public string EmailAddress
        {
            get { return this.emailAddress; }
            set { SetProperty(ref this.emailAddress, value, "EmailAddress"); }
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

        public Feedback()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
