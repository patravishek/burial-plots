﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BurialPlots.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BurialPlotsEntities : DbContext
    {
        public BurialPlotsEntities()
            : base("name=BurialPlotsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdministrativeEmail> AdministrativeEmails { get; set; }
        public virtual DbSet<AdminLogin> AdminLogins { get; set; }
        public virtual DbSet<BillingShipping> BillingShippings { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogCategory> BlogCategories { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cemetery> Cemeteries { get; set; }
        public virtual DbSet<CemeteryImage> CemeteryImages { get; set; }
        public virtual DbSet<CemeteryLayer> CemeteryLayers { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<FuneralProduct> FuneralProducts { get; set; }
        public virtual DbSet<FuneralService> FuneralServices { get; set; }
        public virtual DbSet<Grave> Graves { get; set; }
        public virtual DbSet<ItalianPage> ItalianPages { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<MainSection> MainSections { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Member1> Members1 { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<NewsManagement> NewsManagements { get; set; }
        public virtual DbSet<OrderCemetery> OrderCemeteries { get; set; }
        public virtual DbSet<OrderPlan> OrderPlans { get; set; }
        public virtual DbSet<OrderPlanItem> OrderPlanItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PageBox> PageBoxes { get; set; }
        public virtual DbSet<PartnerPlan> PartnerPlans { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PaymentCard> PaymentCards { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PostCode> PostCodes { get; set; }
        public virtual DbSet<Relgion> Relgions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<ServiceBox> ServiceBoxes { get; set; }
        public virtual DbSet<ServiceListingPlan> ServiceListingPlans { get; set; }
        public virtual DbSet<ServicesListingApproval> ServicesListingApprovals { get; set; }
        public virtual DbSet<SeviceListing> SeviceListings { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SubCate> SubCates { get; set; }
        public virtual DbSet<SubChlidMenu> SubChlidMenus { get; set; }
        public virtual DbSet<submenu> submenus { get; set; }
        public virtual DbSet<SubRelgion> SubRelgions { get; set; }
        public virtual DbSet<Tier> Tiers { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<UrduPage> UrduPages { get; set; }
        public virtual DbSet<PurchaseBoxImage> PurchaseBoxImages { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<Enquiry> Enquiries { get; set; }
        public virtual DbSet<PopularLocationContent> PopularLocationContents { get; set; }
        public virtual DbSet<LocationUrl> LocationUrls { get; set; }
    
        public virtual int Sp_DeleteAllGraves(Nullable<decimal> sectionId, Nullable<decimal> plotId, Nullable<decimal> subSectionId)
        {
            var sectionIdParameter = sectionId.HasValue ?
                new ObjectParameter("sectionId", sectionId) :
                new ObjectParameter("sectionId", typeof(decimal));
    
            var plotIdParameter = plotId.HasValue ?
                new ObjectParameter("plotId", plotId) :
                new ObjectParameter("plotId", typeof(decimal));
    
            var subSectionIdParameter = subSectionId.HasValue ?
                new ObjectParameter("subSectionId", subSectionId) :
                new ObjectParameter("subSectionId", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_DeleteAllGraves", sectionIdParameter, plotIdParameter, subSectionIdParameter);
        }
    }
}
