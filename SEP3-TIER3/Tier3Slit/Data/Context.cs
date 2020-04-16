using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tier3Slit.Models.Entities;

namespace Tier3Slit.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot config = builder.Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Context"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChannelUser>()
                .HasKey(cu => new {cu.ChannelId, cu.Username});
            modelBuilder.Entity<ChannelUser>()
                .HasOne(u => u.User)
                .WithMany(ch => ch.Channels)
                .HasForeignKey(u => u.Username);
            modelBuilder.Entity<ChannelUser>()
                .HasOne(ch => ch.Channel)
                .WithMany(u => u.Users)
                .HasForeignKey(ch => ch.ChannelId);

            modelBuilder.Entity<ProjectUser>()
                .HasKey(pu => new {pu.ProjectId, pu.Username});
            modelBuilder.Entity<ProjectUser>()
                .HasOne(u => u.User)
                .WithMany(pr => pr.Projects)
                .HasForeignKey(u => u.Username);
            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Project)
                .WithMany(u => u.Users)
                .HasForeignKey(pr => pr.ProjectId);

            modelBuilder.Entity<PendingInvitation>()
                .HasKey(pi => new {pi.ProjectId, pi.Username});

            modelBuilder.Entity<UserTask>()
                .HasKey(ut => new {ut.Username, ut.TaskId});

            modelBuilder.Entity<TaskComment>()
                .HasKey(pu => new {pu.Id});

            modelBuilder.Entity<ProjectChannel>()
                .HasKey(pu => new {pu.ProjectId, pu.ChannelId});
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<ChannelUser> ChannelUser { get; set; }
        public DbSet<ProjectUser> ProjectUser { get; set; }
        public DbSet<PendingInvitation> PendingInvitation { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<UserTask> UserTask { get; set; }
        public DbSet<TaskComment> TaskComment { get; set; }
        public DbSet<ProjectChannel> ProjectChannels { get; set; }
        public DbSet<CMessage> ChannelMessages { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
    }
}