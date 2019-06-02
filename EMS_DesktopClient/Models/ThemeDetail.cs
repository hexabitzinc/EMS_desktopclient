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
    public partial class ThemeDetail : BindableBase
    {
        #region Private Fields

        private int id;
        private int themeID;
        private int? uIStateID;

        private string elementName;
        private string elementProperty;
        private string elementPropertyType;
        private byte[] elementPropertyValue;

        private bool isDeleted;

        private UIState uIState;
        private Theme theme;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }
        [ForeignKey("Theme")]
        [Column(name: "ThemeID", TypeName = "INT")]
        public int ThemeID
        {
            get { return this.themeID; }
            set { SetProperty(ref this.themeID, value, "ThemeID"); }
        }
        [ForeignKey("UIState")]
        [Column(name: "UIStateID", TypeName = "INT")]
        public int? UIStateID
        {
            get { return this.uIStateID; }
            set { SetProperty(ref this.uIStateID, value, "UIStateID"); }
        }

        [Column(name: "ElementName", TypeName = "NVARCHAR(MAX)")]
        public string ElementName
        {
            get { return this.elementName; }
            set { SetProperty(ref this.elementName, value, "ElementName"); }
        }
        [Column(name: "ElementProperty", TypeName = "NVARCHAR(MAX)")]
        public string ElementProperty
        {
            get { return this.elementProperty; }
            set { SetProperty(ref this.elementProperty, value, "ElementProperty"); }
        }
        [Column(name: "ElementPropertyType", TypeName = "NVARCHAR(MAX)")]
        public string ElementPropertyType
        {
            get { return this.elementPropertyType; }
            set { SetProperty(ref this.elementPropertyType, value, "ElementPropertyType"); }
        }
        [Column(name: "ElementPropertyValue", TypeName = "VARBINARY(MAX)")]
        public byte[] ElementPropertyValue
        {
            get { return this.elementPropertyValue; }
            set { SetProperty(ref this.elementPropertyValue, value, "ElementPropertyValue"); }
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
        public virtual Theme Theme
        {
            get { return this.theme; }
            set { SetProperty(ref this.theme, value, "Theme"); }
        }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public ThemeDetail()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
