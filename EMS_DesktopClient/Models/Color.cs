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
    public partial class Color : BindableBase
    {
        #region Private Fields

        private int id;
        private int? uIStateID;

        private string name;
        private long normalBackgroundARGB;
        private string normalBackgroundHexValue;
        private long normalForegroundARGB;
        private string normalForegroundHexValue;
        private long isSelectedBackgroundARGB;
        private string isSelectedBackgroundHexValue;
        private long isSelectedForegroundARGB;
        private string isSelectedForegroundHexValue;
        private long isMouseOverBackgroundARGB;
        private string isMouseOverBackgroundHexValue;
        private long isMouseOverForegroundARGB;
        private string isMouseOverForegroundHexValue;

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

        [Column(name: "Name", TypeName = "NVARCHAR(MAX)")]
        public string Name
        {
            get { return this.name; }
            set { SetProperty(ref this.name, value, "Name"); }
        }
        [Column(name: "NormalBackgroundARGB", TypeName = "BIGINT")]
        public long NormalBackgroundARGB
        {
            get { return this.normalBackgroundARGB; }
            set { SetProperty(ref this.normalBackgroundARGB, value, "NormalBackgroundARGB"); }
        }
        [Column(name: "NormalBackgroundHexValue", TypeName = "NVARCHAR(MAX)")]
        public string NormalBackgroundHexValue
        {
            get { return this.normalBackgroundHexValue; }
            set { SetProperty(ref this.normalBackgroundHexValue, value, "NormalBackgroundHexValue"); }
        }
        [Column(name: "NormalForegroundARGB", TypeName = "BIGINT")]
        public long NormalForegroundARGB
        {
            get { return this.normalForegroundARGB; }
            set { SetProperty(ref this.normalForegroundARGB, value, "NormalForegroundARGB"); }
        }
        [Column(name: "NormalForegroundHexValue", TypeName = "NVARCHAR(MAX)")]
        public string NormalForegroundHexValue
        {
            get { return this.normalForegroundHexValue; }
            set { SetProperty(ref this.normalForegroundHexValue, value, "NormalForegroundHexValue"); }
        }
        [Column(name: "IsSelectedBackgroundARGB", TypeName = "BIGINT")]
        public long IsSelectedBackgroundARGB
        {
            get { return this.isSelectedBackgroundARGB; }
            set { SetProperty(ref this.isSelectedBackgroundARGB, value, "IsSelectedBackgroundARGB"); }
        }
        [Column(name: "IsSelectedBackgroundHexValue", TypeName = "NVARCHAR(MAX)")]
        public string IsSelectedBackgroundHexValue
        {
            get { return this.isSelectedBackgroundHexValue; }
            set { SetProperty(ref this.isSelectedBackgroundHexValue, value, "IsSelectedBackgroundHexValue"); }
        }
        [Column(name: "IsSelectedForegroundARGB", TypeName = "BIGINT")]
        public long IsSelectedForegroundARGB
        {
            get { return this.isSelectedForegroundARGB; }
            set { SetProperty(ref this.isSelectedForegroundARGB, value, "IsSelectedForegroundARGB"); }
        }
        [Column(name: "IsSelectedForegroundHexValue", TypeName = "NVARCHAR(MAX)")]
        public string IsSelectedForegroundHexValue
        {
            get { return this.isSelectedForegroundHexValue; }
            set { SetProperty(ref this.isSelectedForegroundHexValue, value, "IsSelectedForegroundHexValue"); }
        }
        [Column(name: "IsMouseOverBackgroundARGB", TypeName = "BIGINT")]
        public long IsMouseOverBackgroundARGB
        {
            get { return this.isMouseOverBackgroundARGB; }
            set { SetProperty(ref this.isMouseOverBackgroundARGB, value, "IsMouseOverBackgroundARGB"); }
        }
        [Column(name: "IsMouseOverBackgroundHexValue", TypeName = "NVARCHAR(MAX)")]
        public string IsMouseOverBackgroundHexValue
        {
            get { return this.isMouseOverBackgroundHexValue; }
            set { SetProperty(ref this.isMouseOverBackgroundHexValue, value, "IsMouseOverBackgroundHexValue"); }
        }
        [Column(name: "IsMouseOverForegroundARGB", TypeName = "BIGINT")]
        public long IsMouseOverForegroundARGB
        {
            get { return this.isMouseOverForegroundARGB; }
            set { SetProperty(ref this.isMouseOverForegroundARGB, value, "IsMouseOverForegroundARGB"); }
        }
        [Column(name: "IsMouseOverForegroundHexValue", TypeName = "NVARCHAR(MAX)")]
        public string IsMouseOverForegroundHexValue
        {
            get { return this.isMouseOverForegroundHexValue; }
            set { SetProperty(ref this.isMouseOverForegroundHexValue, value, "IsMouseOverForegroundHexValue"); }
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

        public Color()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
