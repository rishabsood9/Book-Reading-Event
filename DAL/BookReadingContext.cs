using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using Shared;
namespace DAL
    {
    public class BookReadingContext : DbContext
        {
        public BookReadingContext() : base("BookReadingContext")
            {
            Database.SetInitializer(new EventInitializer());
            }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Role> Roles{get;set;}
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //For entity user
            modelBuilder.Entity<User>()
                .HasKey(s => s.UserName);

            modelBuilder.Entity<User>()
               .Property(t => t.EmailId)
               .IsRequired()
               .HasMaxLength(400)
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                         new IndexAnnotation(
                                         new IndexAttribute("IX_UserName", 1) { IsUnique = true }));

            
            
           
            modelBuilder.Entity<Event>()
                .Property(p => p.UserId)
                .IsRequired();
                
            modelBuilder.Entity<Event>()
             .HasRequired<User>(s => s.User)
             .WithMany(g => g.Events)
             .HasForeignKey(s =>  s.UserId );



            modelBuilder.Entity<Event>().Property(s => s.Title)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                         new IndexAnnotation(
                                         new IndexAttribute("IX_Title", 1) { IsUnique = true })); 
            

            modelBuilder.Entity<Event>()
              .Property(t => t.Type)
              .IsRequired();

            modelBuilder.Entity<Event>()
               .Property(t => t.StartTime)
               .IsRequired()
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                         new IndexAnnotation(
                                         new IndexAttribute("IX_FirstNameLastName", 1) { IsUnique = true }));

            modelBuilder.Entity<Event>()
              .Property(t => t.Date)
              .IsRequired()
              .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                        new IndexAnnotation(
                                        new IndexAttribute("IX_FirstNameLastName", 2) { IsUnique = true }));
            modelBuilder.Entity<Event>()
              .Property(t => t.Location)
              .IsRequired()
              .HasMaxLength(60)
              .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                        new IndexAnnotation(
                                        new IndexAttribute("IX_FirstNameLastName", 3) { IsUnique = true }));

            modelBuilder.Entity<Invitation>()
                .HasKey(i => i.InvitationId);

            modelBuilder.Entity<Invitation>()
             .HasRequired<Event>(s => s.Event)
             .WithMany(i=>i.Invitations)
             .HasForeignKey(s => s.EventId);

            modelBuilder.Entity<Invitation>()
                .Property(p => p.EventId).IsRequired();

            modelBuilder.Entity<Role>()
            .HasRequired<User>(s => s.User)
            .WithMany(i => i.Roles)
            .HasForeignKey<string>(s => s.UserId );




            }

        }
    }
