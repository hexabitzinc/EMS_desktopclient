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
    public class UIState : BindableBase
    {
        #region Private Fields

        private int id;
        private int value;
        private string name;

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
        [Column(name: "Value", TypeName = "INT")]
        public int Value
        {
            get { return this.value; }
            set { SetProperty(ref this.value, value, "Value"); }
        }
        [Column(name: "Name", TypeName = "NVARCHAR(MAX)")]
        public string Name
        {
            get { return this.name; }
            set { SetProperty(ref this.name, value, "Name"); }
        }

        [Column(name: "IsDeleted", TypeName = "BIT")]
        public bool IsDeleted
        {
            get { return this.isDeleted; }
            set { SetProperty(ref this.isDeleted, value, "IsDeleted"); }
        }

        public virtual ICollection<ActionType> ActionTypes { get; set; }
        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual ICollection<AdvertisementImage> AdvertisementImages { get; set; }
        public virtual ICollection<AdvertisementText> AdvertisementTexts { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<CommonLocation> CommonLocations { get; set; }
        public virtual ICollection<Consumer> Consumers { get; set; }
        public virtual ICollection<EmsDevice> EmsDevices { get; set; }
        public virtual ICollection<EmsParameter> EmsParameters { get; set; }
        public virtual ICollection<EmsSetting> EmsSettings { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Memo> Memos { get; set; }
        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<MeterParameter> MeterParameters { get; set; }
        public virtual ICollection<MeterType> MeterTypes { get; set; }
        public virtual ICollection<Parameter> Parameters { get; set; }
        public virtual ICollection<ParameterGroup> ParameterGroups { get; set; }
        public virtual ICollection<ParameterType> ParameterTypes { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public virtual ICollection<Theme> Themes { get; set; }
        public virtual ICollection<ThemeDetail> ThemeDetails { get; set; }
        public virtual ICollection<UIState> UIStates { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }
        public virtual ICollection<ZoningGroup> ZoningGroups { get; set; }

        #endregion

        #region Constructor

        public UIState()
        {
            //this.Analyses = new HashSet<Analysis>();
            //this.Anthroposcopies = new HashSet<Anthroposcopy>();
            //this.ChemicalCompositions = new HashSet<ChemicalComposition>();
            //this.ChemicalTypes = new HashSet<ChemicalType>();
            //this.ChemicalCompositionTypes = new HashSet<ChemicalCompositionType>();
            //this.ChemicalInteractions = new HashSet<ChemicalInteraction>();
            //this.Colors = new HashSet<Color>();
            //this.CompositionPercentageUnits = new HashSet<CompositionPercentageUnit>();
            //this.Costs = new HashSet<Cost>();
            //this.DosageForms = new HashSet<DosageForm>();
            //this.Doses = new HashSet<Dose>();
            //this.Feedbacks = new HashSet<Feedback>();
            //this.Habits = new HashSet<Habit>();
            //this.HabitCompositionInteractions = new HashSet<HabitCompositionInteraction>();
            //this.HabitTypes = new HashSet<HabitType>();
            //this.Illnesses = new HashSet<Illness>();
            //this.IllnessSymptoms = new HashSet<IllnessSymptom>();
            //this.InsuranceCompanies = new HashSet<InsuranceCompany>();
            //this.InsuranceDocuments = new HashSet<InsuranceDocument>();
            //this.MainAnalysisTypes = new HashSet<MainAnalysisType>();
            //this.Media = new HashSet<Media>();
            //this.MedicalReports = new HashSet<MedicalReport>();
            //this.Medicines = new HashSet<Medicine>();
            //this.MedicineCompanies = new HashSet<MedicineCompany>();
            //this.MedicineCompositions = new HashSet<MedicineComposition>();
            //this.Memos = new HashSet<Memo>();
            //this.Nurses = new HashSet<Nurse>();
            //this.Operations = new HashSet<Operation>();
            //this.Patients = new HashSet<Patient>();
            //this.PatientHabits = new HashSet<PatientHabit>();
            //this.Payments = new HashSet<Payment>();
            //this.Places = new HashSet<Place>();
            //this.PregnancyObservations = new HashSet<PregnancyObservation>();
            //this.Prescriptions = new HashSet<Prescription>();
            //this.ReferenceValueProperties = new HashSet<ReferenceValueProperty>();
            //this.Reviews = new HashSet<Review>();
            //this.SubAnalysisReferenceValues = new HashSet<SubAnalysisReferenceValue>();
            //this.SubAnalysisTypes = new HashSet<SubAnalysisType>();
            //this.Symptoms = new HashSet<Symptom>();
            //this.Themes = new HashSet<Theme>();
            //this.ThemeDetails = new HashSet<ThemeDetail>();
            //this.UserActions = new HashSet<UserAction>();
            //this.Visits = new HashSet<Visit>();
            //this.VitalSigns = new HashSet<VitalSign>();
            //this.VitalSignReferenceValues = new HashSet<VitalSignReferenceValue>();
            //this.VitalSignValues = new HashSet<VitalSignValue>();
            //this.WaitingCards = new HashSet<WaitingCard>();
        }

        #endregion
    }
}
