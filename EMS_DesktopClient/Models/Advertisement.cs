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
    public class Advertisement : BindableBase
    {
        #region Private Fields

        private int id;

        private string source;
        private DateTime registrationDate;
        private int remainingSeconds;

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

        [Column(name: "Source", TypeName = "NVARCHAR(MAX)")]
        public string Source
        {
            get { return this.source; }
            set { SetProperty(ref this.source, value, "Source"); }
        }

        [Column(name: "RegistrationDate", TypeName = "DATETIME")]
        public DateTime RegistrationDate
        {
            get { return this.registrationDate; }
            set { SetProperty(ref this.registrationDate, value, "RegistrationDate"); }
        }
        [Column(name: "RemainingSeconds", TypeName = "INT")]
        public int RemainingSeconds
        {
            get { return this.remainingSeconds; }
            set { SetProperty(ref this.remainingSeconds, value, "RemainingSeconds"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual ICollection<AdvertisementText> AdvertisementTexts { get; set; }
        public virtual ICollection<AdvertisementImage> AdvertisementImages { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Advertisement()
        {
            this.AdvertisementTexts = new HashSet<AdvertisementText>();
            this.AdvertisementImages = new HashSet<AdvertisementImage>();
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
