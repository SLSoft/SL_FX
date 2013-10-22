using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SL_FX.Models.Mapping;

namespace SL_FX.Models
{
    public class slsoft_iasdbContext : DbContext
    {
        static slsoft_iasdbContext()
        {
            Database.SetInitializer<slsoft_iasdbContext>(null);
        }

		public slsoft_iasdbContext()
			: base("Name=slsoft_iasdbContext")
		{
		}

        public DbSet<dic_t_areas> dic_t_areas { get; set; }
        public DbSet<dic_t_cities> dic_t_cities { get; set; }
        public DbSet<dic_t_provinces> dic_t_provinces { get; set; }
        public DbSet<slsoft_ias_bus_t_accesslist> slsoft_ias_bus_t_accesslist { get; set; }
        public DbSet<slsoft_ias_bus_t_flowanalysis> slsoft_ias_bus_t_flowanalysis { get; set; }
        public DbSet<slsoft_ias_bus_t_session> slsoft_ias_bus_t_session { get; set; }
        public DbSet<slsoft_ias_bus_t_statisticssite> slsoft_ias_bus_t_statisticssite { get; set; }
        public DbSet<slsoft_ias_dic_t_siteclassification> slsoft_ias_dic_t_siteclassification { get; set; }
        public DbSet<slsoft_ias_sys_t_site> slsoft_ias_sys_t_site { get; set; }
        public DbSet<slsoft_ias_sys_t_user> slsoft_ias_sys_t_user { get; set; }
        public DbSet<slsoft_ias_sys_t_userauthorization> slsoft_ias_sys_t_userauthorization { get; set; }
        public DbSet<slsoft_ias_sys_t_users> slsoft_ias_sys_t_users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new dic_t_areasMap());
            modelBuilder.Configurations.Add(new dic_t_citiesMap());
            modelBuilder.Configurations.Add(new dic_t_provincesMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_accesslistMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_flowanalysisMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_sessionMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_statisticssiteMap());
            modelBuilder.Configurations.Add(new slsoft_ias_dic_t_siteclassificationMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_siteMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_userMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_userauthorizationMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_usersMap());
        }
    }
}
