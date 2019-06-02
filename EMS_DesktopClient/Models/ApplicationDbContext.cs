using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DesktopClient.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Data Source =.; Initial Catalog = EMS_DesktopClient; User ID = sa; Password=11;")
        {

        }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AdvertisementImage> AdvertisementImages { get; set; }
        public virtual DbSet<AdvertisementText> AdvertisementTexts { get; set; }
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<CommonLocation> CommonLocations { get; set; }
        public virtual DbSet<Consumer> Consumers { get; set; }
        public virtual DbSet<EmsDevice> EmsDevices { get; set; }
        public virtual DbSet<EmsParameter> EmsParameters { get; set; }
        public virtual DbSet<EmsSetting> EmsSettings { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Memo> Memos { get; set; }
        public virtual DbSet<Meter> Meters { get; set; }
        public virtual DbSet<MeterParameter> MeterParameters { get; set; }
        public virtual DbSet<MeterType> MeterTypes { get; set; }
        public virtual DbSet<Parameter> Parameters { get; set; }
        public virtual DbSet<ParameterGroup> ParameterGroups { get; set; }
        public virtual DbSet<ParameterType> ParameterTypes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<ThemeDetail> ThemeDetails { get; set; }
        public virtual DbSet<UIState> UIStates { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAction> UserActions { get; set; }
        public virtual DbSet<ZoningGroup> ZoningGroups { get; set; }

    }
}
