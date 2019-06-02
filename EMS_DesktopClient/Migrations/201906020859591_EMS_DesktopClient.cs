namespace EMS_DesktopClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EMS_DesktopClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CityID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        ZipCode = c.String(),
                        Address = c.String(),
                        StreetAddress = c.String(),
                        Describtion = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.CityID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        Describtion = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.UIStates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserActions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Details = c.String(),
                        UserID = c.Int(nullable: false),
                        ActionTypeID = c.Int(nullable: false),
                        City_ID = c.Int(),
                        Floor_ID = c.Int(),
                        Section_ID = c.Int(),
                        Apartment_ID = c.Int(),
                        CommonLocation_ID = c.Int(),
                        EmsParameter_ID = c.Int(),
                        EmsSetting_ID = c.Int(),
                        ParameterType_ID = c.Int(),
                        Parameter_ID = c.Int(),
                        ParameterGroup_ID = c.Int(),
                        MeterParameter_ID = c.Int(),
                        Meter_ID = c.Int(),
                        Consumer_ID = c.Int(),
                        EmsDevice_ID = c.Int(),
                        Building_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ActionTypes", t => t.ActionTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_ID)
                .ForeignKey("dbo.Floors", t => t.Floor_ID)
                .ForeignKey("dbo.Sections", t => t.Section_ID)
                .ForeignKey("dbo.Apartments", t => t.Apartment_ID)
                .ForeignKey("dbo.CommonLocations", t => t.CommonLocation_ID)
                .ForeignKey("dbo.EmsParameters", t => t.EmsParameter_ID)
                .ForeignKey("dbo.EmsSettings", t => t.EmsSetting_ID)
                .ForeignKey("dbo.ParameterTypes", t => t.ParameterType_ID)
                .ForeignKey("dbo.Parameters", t => t.Parameter_ID)
                .ForeignKey("dbo.ParameterGroups", t => t.ParameterGroup_ID)
                .ForeignKey("dbo.MeterParameters", t => t.MeterParameter_ID)
                .ForeignKey("dbo.Meters", t => t.Meter_ID)
                .ForeignKey("dbo.Consumers", t => t.Consumer_ID)
                .ForeignKey("dbo.EmsDevices", t => t.EmsDevice_ID)
                .ForeignKey("dbo.Buildings", t => t.Building_ID)
                .Index(t => t.UserID)
                .Index(t => t.ActionTypeID)
                .Index(t => t.City_ID)
                .Index(t => t.Floor_ID)
                .Index(t => t.Section_ID)
                .Index(t => t.Apartment_ID)
                .Index(t => t.CommonLocation_ID)
                .Index(t => t.EmsParameter_ID)
                .Index(t => t.EmsSetting_ID)
                .Index(t => t.ParameterType_ID)
                .Index(t => t.Parameter_ID)
                .Index(t => t.ParameterGroup_ID)
                .Index(t => t.MeterParameter_ID)
                .Index(t => t.Meter_ID)
                .Index(t => t.Consumer_ID)
                .Index(t => t.EmsDevice_ID)
                .Index(t => t.Building_ID);
            
            CreateTable(
                "dbo.ActionTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmsDevices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BuildingID = c.Int(nullable: false),
                        EmsParameterID = c.Int(nullable: false),
                        EmsSettingID = c.Int(nullable: false),
                        ConsumerID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        SerialNumber = c.String(),
                        Notes = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID, cascadeDelete: true)
                .ForeignKey("dbo.Consumers", t => t.ConsumerID, cascadeDelete: true)
                .ForeignKey("dbo.EmsParameters", t => t.EmsParameterID, cascadeDelete: true)
                .ForeignKey("dbo.EmsSettings", t => t.EmsSettingID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.BuildingID)
                .Index(t => t.EmsParameterID)
                .Index(t => t.EmsSettingID)
                .Index(t => t.ConsumerID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UIStateID = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        OtherInformation = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Meters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApartmentID = c.Int(),
                        CommonLocationID = c.Int(),
                        MeterParameterID = c.Int(nullable: false),
                        ConsumerID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        SerialNumber = c.String(),
                        Notes = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Apartments", t => t.ApartmentID)
                .ForeignKey("dbo.CommonLocations", t => t.CommonLocationID)
                .ForeignKey("dbo.Consumers", t => t.ConsumerID, cascadeDelete: true)
                .ForeignKey("dbo.MeterParameters", t => t.MeterParameterID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.ApartmentID)
                .Index(t => t.CommonLocationID)
                .Index(t => t.MeterParameterID)
                .Index(t => t.ConsumerID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Apartments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SectionID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        Type = c.String(),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.SectionID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FloorID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        Describtion = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Floors", t => t.FloorID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.FloorID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Floors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BuildingID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        FloorIndex = c.Int(nullable: false),
                        Describtion = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.BuildingID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.CommonLocations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BuildingID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        Name = c.String(),
                        Describtion = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.BuildingID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.MeterParameters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParameterGroupID = c.Int(nullable: false),
                        ParameterID = c.Int(nullable: false),
                        UIStateID = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Parameters", t => t.ParameterID, cascadeDelete: true)
                .ForeignKey("dbo.ParameterGroups", t => t.ParameterGroupID, cascadeDelete: true)
                .ForeignKey("dbo.UIStates", t => t.UIStateID)
                .Index(t => t.ParameterGroupID)
                .Index(t => t.ParameterID)
                .Index(t => t.UIStateID);
            
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParameterTypeID = c.Int(nullable: false),
                        Name = c.String(),
                        Value = c.String(),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterTypes", t => t.ParameterTypeID, cascadeDelete: true)
                .Index(t => t.ParameterTypeID);
            
            CreateTable(
                "dbo.ParameterTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmsParameters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParameterTypeID = c.Int(nullable: false),
                        Name = c.String(),
                        Value = c.String(),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterTypes", t => t.ParameterTypeID, cascadeDelete: true)
                .Index(t => t.ParameterTypeID);
            
            CreateTable(
                "dbo.EmsSettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParameterTypeID = c.Int(nullable: false),
                        Name = c.String(),
                        Value = c.String(),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterTypes", t => t.ParameterTypeID, cascadeDelete: false)
                .Index(t => t.ParameterTypeID);
            
            CreateTable(
                "dbo.ParameterGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserActions", "Building_ID", "dbo.Buildings");
            DropForeignKey("dbo.Buildings", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.UserActions", "EmsDevice_ID", "dbo.EmsDevices");
            DropForeignKey("dbo.EmsDevices", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.EmsDevices", "EmsSettingID", "dbo.EmsSettings");
            DropForeignKey("dbo.EmsDevices", "EmsParameterID", "dbo.EmsParameters");
            DropForeignKey("dbo.EmsDevices", "ConsumerID", "dbo.Consumers");
            DropForeignKey("dbo.UserActions", "Consumer_ID", "dbo.Consumers");
            DropForeignKey("dbo.Consumers", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.UserActions", "Meter_ID", "dbo.Meters");
            DropForeignKey("dbo.Meters", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.Meters", "MeterParameterID", "dbo.MeterParameters");
            DropForeignKey("dbo.UserActions", "MeterParameter_ID", "dbo.MeterParameters");
            DropForeignKey("dbo.MeterParameters", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.MeterParameters", "ParameterGroupID", "dbo.ParameterGroups");
            DropForeignKey("dbo.UserActions", "ParameterGroup_ID", "dbo.ParameterGroups");
            DropForeignKey("dbo.MeterParameters", "ParameterID", "dbo.Parameters");
            DropForeignKey("dbo.UserActions", "Parameter_ID", "dbo.Parameters");
            DropForeignKey("dbo.Parameters", "ParameterTypeID", "dbo.ParameterTypes");
            DropForeignKey("dbo.UserActions", "ParameterType_ID", "dbo.ParameterTypes");
            DropForeignKey("dbo.UserActions", "EmsSetting_ID", "dbo.EmsSettings");
            DropForeignKey("dbo.EmsSettings", "ParameterTypeID", "dbo.ParameterTypes");
            DropForeignKey("dbo.UserActions", "EmsParameter_ID", "dbo.EmsParameters");
            DropForeignKey("dbo.EmsParameters", "ParameterTypeID", "dbo.ParameterTypes");
            DropForeignKey("dbo.Meters", "ConsumerID", "dbo.Consumers");
            DropForeignKey("dbo.Meters", "CommonLocationID", "dbo.CommonLocations");
            DropForeignKey("dbo.UserActions", "CommonLocation_ID", "dbo.CommonLocations");
            DropForeignKey("dbo.CommonLocations", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.CommonLocations", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Meters", "ApartmentID", "dbo.Apartments");
            DropForeignKey("dbo.UserActions", "Apartment_ID", "dbo.Apartments");
            DropForeignKey("dbo.Apartments", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.Apartments", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.UserActions", "Section_ID", "dbo.Sections");
            DropForeignKey("dbo.Sections", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.Sections", "FloorID", "dbo.Floors");
            DropForeignKey("dbo.UserActions", "Floor_ID", "dbo.Floors");
            DropForeignKey("dbo.Floors", "UIStateID", "dbo.UIStates");
            DropForeignKey("dbo.Floors", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.EmsDevices", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Buildings", "CityID", "dbo.Cities");
            DropForeignKey("dbo.UserActions", "City_ID", "dbo.Cities");
            DropForeignKey("dbo.UserActions", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserActions", "ActionTypeID", "dbo.ActionTypes");
            DropForeignKey("dbo.Cities", "UIStateID", "dbo.UIStates");
            DropIndex("dbo.EmsSettings", new[] { "ParameterTypeID" });
            DropIndex("dbo.EmsParameters", new[] { "ParameterTypeID" });
            DropIndex("dbo.Parameters", new[] { "ParameterTypeID" });
            DropIndex("dbo.MeterParameters", new[] { "UIStateID" });
            DropIndex("dbo.MeterParameters", new[] { "ParameterID" });
            DropIndex("dbo.MeterParameters", new[] { "ParameterGroupID" });
            DropIndex("dbo.CommonLocations", new[] { "UIStateID" });
            DropIndex("dbo.CommonLocations", new[] { "BuildingID" });
            DropIndex("dbo.Floors", new[] { "UIStateID" });
            DropIndex("dbo.Floors", new[] { "BuildingID" });
            DropIndex("dbo.Sections", new[] { "UIStateID" });
            DropIndex("dbo.Sections", new[] { "FloorID" });
            DropIndex("dbo.Apartments", new[] { "UIStateID" });
            DropIndex("dbo.Apartments", new[] { "SectionID" });
            DropIndex("dbo.Meters", new[] { "UIStateID" });
            DropIndex("dbo.Meters", new[] { "ConsumerID" });
            DropIndex("dbo.Meters", new[] { "MeterParameterID" });
            DropIndex("dbo.Meters", new[] { "CommonLocationID" });
            DropIndex("dbo.Meters", new[] { "ApartmentID" });
            DropIndex("dbo.Consumers", new[] { "UIStateID" });
            DropIndex("dbo.EmsDevices", new[] { "UIStateID" });
            DropIndex("dbo.EmsDevices", new[] { "ConsumerID" });
            DropIndex("dbo.EmsDevices", new[] { "EmsSettingID" });
            DropIndex("dbo.EmsDevices", new[] { "EmsParameterID" });
            DropIndex("dbo.EmsDevices", new[] { "BuildingID" });
            DropIndex("dbo.UserActions", new[] { "Building_ID" });
            DropIndex("dbo.UserActions", new[] { "EmsDevice_ID" });
            DropIndex("dbo.UserActions", new[] { "Consumer_ID" });
            DropIndex("dbo.UserActions", new[] { "Meter_ID" });
            DropIndex("dbo.UserActions", new[] { "MeterParameter_ID" });
            DropIndex("dbo.UserActions", new[] { "ParameterGroup_ID" });
            DropIndex("dbo.UserActions", new[] { "Parameter_ID" });
            DropIndex("dbo.UserActions", new[] { "ParameterType_ID" });
            DropIndex("dbo.UserActions", new[] { "EmsSetting_ID" });
            DropIndex("dbo.UserActions", new[] { "EmsParameter_ID" });
            DropIndex("dbo.UserActions", new[] { "CommonLocation_ID" });
            DropIndex("dbo.UserActions", new[] { "Apartment_ID" });
            DropIndex("dbo.UserActions", new[] { "Section_ID" });
            DropIndex("dbo.UserActions", new[] { "Floor_ID" });
            DropIndex("dbo.UserActions", new[] { "City_ID" });
            DropIndex("dbo.UserActions", new[] { "ActionTypeID" });
            DropIndex("dbo.UserActions", new[] { "UserID" });
            DropIndex("dbo.Cities", new[] { "UIStateID" });
            DropIndex("dbo.Buildings", new[] { "UIStateID" });
            DropIndex("dbo.Buildings", new[] { "CityID" });
            DropTable("dbo.ParameterGroups");
            DropTable("dbo.EmsSettings");
            DropTable("dbo.EmsParameters");
            DropTable("dbo.ParameterTypes");
            DropTable("dbo.Parameters");
            DropTable("dbo.MeterParameters");
            DropTable("dbo.CommonLocations");
            DropTable("dbo.Floors");
            DropTable("dbo.Sections");
            DropTable("dbo.Apartments");
            DropTable("dbo.Meters");
            DropTable("dbo.Consumers");
            DropTable("dbo.EmsDevices");
            DropTable("dbo.Users");
            DropTable("dbo.ActionTypes");
            DropTable("dbo.UserActions");
            DropTable("dbo.UIStates");
            DropTable("dbo.Cities");
            DropTable("dbo.Buildings");
        }
    }
}
