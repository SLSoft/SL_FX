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

        public DbSet<slsoft_ias_bus_t_accesslist> slsoft_ias_bus_t_accesslist { get; set; }
        public DbSet<slsoft_ias_bus_t_flowanalysis> slsoft_ias_bus_t_flowanalysis { get; set; }
        public DbSet<slsoft_ias_bus_t_session> slsoft_ias_bus_t_session { get; set; }
        public DbSet<slsoft_ias_bus_t_statisticssite> slsoft_ias_bus_t_statisticssite { get; set; }
        public DbSet<slsoft_ias_dic_t_column> slsoft_ias_dic_t_column { get; set; }
        public DbSet<slsoft_ias_dic_t_column_click> slsoft_ias_dic_t_column_click { get; set; }
        public DbSet<slsoft_ias_dic_t_column_temp> slsoft_ias_dic_t_column_temp { get; set; }
        public DbSet<slsoft_ias_dic_t_hour> slsoft_ias_dic_t_hour { get; set; }
        public DbSet<slsoft_ias_dic_t_siteclassification> slsoft_ias_dic_t_siteclassification { get; set; }
        public DbSet<slsoft_ias_sys_t_reportconfigure> slsoft_ias_sys_t_reportconfigure { get; set; }
        public DbSet<slsoft_ias_sys_t_site> slsoft_ias_sys_t_site { get; set; }
        public DbSet<slsoft_ias_sys_t_systemmenu> slsoft_ias_sys_t_systemmenu { get; set; }
        public DbSet<slsoft_ias_sys_t_user> slsoft_ias_sys_t_user { get; set; }
        public DbSet<slsoft_ias_sys_t_userauthorization> slsoft_ias_sys_t_userauthorization { get; set; }
        public DbSet<slsoft_ias_sys_t_users> slsoft_ias_sys_t_users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_accesslistMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_flowanalysisMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_sessionMap());
            modelBuilder.Configurations.Add(new slsoft_ias_bus_t_statisticssiteMap());
            modelBuilder.Configurations.Add(new slsoft_ias_dic_t_columnMap());
            modelBuilder.Configurations.Add(new slsoft_ias_dic_t_column_clickMap());
            modelBuilder.Configurations.Add(new slsoft_ias_dic_t_column_tempMap());
            modelBuilder.Configurations.Add(new slsoft_ias_dic_t_hourMap());
            modelBuilder.Configurations.Add(new slsoft_ias_dic_t_siteclassificationMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_reportconfigureMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_siteMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_systemmenuMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_userMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_userauthorizationMap());
            modelBuilder.Configurations.Add(new slsoft_ias_sys_t_usersMap());
        }
    }
}
