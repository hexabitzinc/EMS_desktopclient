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
    public partial class Template : BindableBase
    {
        #region Private Fields

        private int id;
        private string name;
        private byte[] data;

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

        [Column(name: "Name", TypeName = "NVARCHAR(MAX)")]
        public string Name
        {
            get { return this.name; }
            set { SetProperty(ref this.name, value, "Name"); }
        }
        [Column(name: "Data", TypeName = "VARBINARY(MAX)")]
        public byte[] Data
        {
            get { return this.data; }
            set { SetProperty(ref this.data, value, "Data"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        //public virtual ICollection<Prescription> Prescriptions { get; set; }
        //public virtual ICollection<MedicalReport> MedicalReports { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Template()
        {
            //this.Prescriptions = new HashSet<Prescription>();
            //this.MedicalReports = new HashSet<MedicalReport>();
            this.UserActions = new HashSet<UserAction>();

        }

        #endregion
    }
}
