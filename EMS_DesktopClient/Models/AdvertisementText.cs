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
    public class AdvertisementText : BindableBase
    {
        #region Private Fields

        private int id;
        private int advertisementID;

        private int remainingSeconds;
        private string text;

        private bool isDeleted;

        private Advertisement advertisement;

        #endregion

        #region Public Properties

        [Key]
        [Column(name: "ID", TypeName = "INT")]
        public int ID
        {
            get { return this.id; }
            set { SetProperty(ref this.id, value, "ID"); }
        }
        [ForeignKey("Advertisement")]
        [Column(name: "AdvertisementID", TypeName = "INT")]
        public int AdvertisementID
        {
            get { return this.advertisementID; }
            set { SetProperty(ref this.advertisementID, value, "AdvertisementID"); }
        }

        [Column(name: "RemainingSeconds", TypeName = "INT")]
        public int RemainingSeconds
        {
            get { return this.remainingSeconds; }
            set { SetProperty(ref this.remainingSeconds, value, "RemainingSeconds"); }
        }
        [Column(name: "Text", TypeName = "NVARCHAR(MAX)")]
        public string Text
        {
            get { return this.text; }
            set { SetProperty(ref this.text, value, "Text"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }
        public virtual Advertisement Advertisement
        {
            get { return this.advertisement; }
            set { SetProperty(ref this.advertisement, value, "Advertisement"); }
        }

        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public AdvertisementText()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
