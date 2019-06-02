﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Models
{
    public partial class Meter : BindableBase
    {
        #region Private Fields

        private int id;
        private int? apartmentID;
        private int? commonLocationID;
        private int meterParameterID;
        private int consumerID;
        private int? uIStateID;

        private string name;
        private string serialNumber;
        private string notes;

        private bool isDeleted;

        private Apartment apartment;
        private CommonLocation commonLocation;
        private MeterParameter meterParameter;
        private Consumer consumer;
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
        [ForeignKey("Apartment")]
        [Column(name: "ApartmentID", TypeName = "INT")]
        public int? ApartmentID
        {
            get { return this.apartmentID; }
            set { SetProperty(ref this.apartmentID, value, "ApartmentID"); }
        }
        [ForeignKey("CommonLocation")]
        [Column(name: "CommonLocationID", TypeName = "INT")]
        public int? CommonLocationID
        {
            get { return this.commonLocationID; }
            set { SetProperty(ref this.commonLocationID, value, "CommonLocationID"); }
        }
        [ForeignKey("MeterParameter")]
        [Column(name: "MeterParameterID", TypeName = "INT")]
        public int MeterParameterID
        {
            get { return this.meterParameterID; }
            set { SetProperty(ref this.meterParameterID, value, "MeterParameterID"); }
        }
        [ForeignKey("Consumer")]
        [Column(name: "ConsumerID", TypeName = "INT")]
        public int ConsumerID
        {
            get { return this.consumerID; }
            set { SetProperty(ref this.consumerID, value, "ConsumerID"); }
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
        [Column(name: "SerialNumber", TypeName = "NVARCHAR(MAX)")]
        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { SetProperty(ref this.serialNumber, value, "SerialNumber"); }
        }
        [Column(name: "Notes", TypeName = "NVARCHAR(MAX)")]
        public string Notes
        {
            get { return this.notes; }
            set { SetProperty(ref this.notes, value, "Notes"); }
        }
        
        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual Apartment Apartment
        {
            get { return this.apartment; }
            set { SetProperty(ref this.apartment, value, "Apartment"); }
        }
        public virtual CommonLocation CommonLocation
        {
            get { return this.commonLocation; }
            set { SetProperty(ref this.commonLocation, value, "CommonLocation"); }
        }
        public virtual MeterParameter MeterParameter
        {
            get { return this.meterParameter; }
            set { SetProperty(ref this.meterParameter, value, "MeterParameter"); }
        }
        public virtual Consumer Consumer
        {
            get { return this.consumer; }
            set { SetProperty(ref this.consumer, value, "Consumer"); }
        }
        public virtual UIState UIState
        {
            get { return this.uIState; }
            set { SetProperty(ref this.uIState, value, "UIState"); }
        }

        public virtual ICollection<UserAction> UserActions { get; set; }

        #endregion

        #region Constructor

        public Meter()
        {
            this.UserActions = new HashSet<UserAction>();
        }

        #endregion
    }
}
