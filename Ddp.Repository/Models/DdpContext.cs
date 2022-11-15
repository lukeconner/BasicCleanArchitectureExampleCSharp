using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class DdpContext : DbContext
    {
        public DdpContext()
        {
        }

        public DdpContext(DbContextOptions<DdpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupMembership> GroupMemberships { get; set; }
        public virtual DbSet<GroupMembershipRequest> GroupMembershipRequests { get; set; }
        public virtual DbSet<GroupType> GroupTypes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrganizationType> OrganizationTypes { get; set; }
        public virtual DbSet<ParentGroup> ParentGroups { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostActivityLog> PostActivityLogs { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<Upload> Uploads { get; set; }
        public virtual DbSet<UploadType> UploadTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=Ddp;user=root;password=root;port=8889");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.HasIndex(e => e.Active, "active");

                entity.HasIndex(e => e.CreatedByUserId, "created_by_user_id");

                entity.HasIndex(e => e.GroupTypeId, "group_type_id");

                entity.HasIndex(e => e.RequiresCommentApproval, "requires_comment_approval");

                entity.HasIndex(e => e.RequiresMembership, "requires_membership");

                entity.HasIndex(e => e.RequiresPostApproval, "requires_post_approval");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnType("int(11)")
                    .HasColumnName("active");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by_user_id");

                entity.Property(e => e.GroupTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.RequiresCommentApproval).HasColumnName("requires_comment_approval");

                entity.Property(e => e.RequiresMembership).HasColumnName("requires_membership");

                entity.Property(e => e.RequiresPostApproval).HasColumnName("requires_post_approval");
            });

            modelBuilder.Entity<GroupMembership>(entity =>
            {
                entity.ToTable("group_memberships");

                entity.HasIndex(e => e.Active, "active");

                entity.HasIndex(e => e.GroupId, "group_id");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnType("int(11)")
                    .HasColumnName("active");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<GroupMembershipRequest>(entity =>
            {
                entity.ToTable("group_membership_request");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("json")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<GroupType>(entity =>
            {
                entity.ToTable("group_types");

                entity.HasIndex(e => e.Active, "active");

                entity.HasIndex(e => e.CreatedByUserId, "created_by_user_id");

                entity.HasIndex(e => e.OwnerOrganizationId, "owner_organization_id");

                entity.HasIndex(e => e.PubliclyAvailable, "publicly_available");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by_user_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.OwnerOrganizationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("owner_organization_id");

                entity.Property(e => e.PubliclyAvailable).HasColumnName("publicly_available");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("languages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.PubliclyAvailable)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("publicly_available")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("organizations");

                entity.HasIndex(e => e.Active, "active");

                entity.HasIndex(e => e.CreatedByUserId, "created_by_user_id");

                entity.HasIndex(e => e.OwnerUserId, "owner_user_id");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("active");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by_user_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.OwnerUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("owner_user_id");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");
            });

            modelBuilder.Entity<OrganizationType>(entity =>
            {
                entity.ToTable("organization_types");

                entity.HasIndex(e => e.PubliclyAvailable, "publicly_available");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.PubliclyAvailable).HasColumnName("publicly_available");
            });

            modelBuilder.Entity<ParentGroup>(entity =>
            {
                entity.ToTable("parent_groups");

                entity.HasIndex(e => e.IsPrimaryParentGroup, "is_primary_parent_group");

                entity.HasIndex(e => e.ParentGroupId, "parent_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IsPrimaryParentGroup).HasColumnName("is_primary_parent_group");

                entity.Property(e => e.ParentGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_group_id");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.ToTable("password_resets");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Expires).HasColumnName("expires");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ip_address");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plans");

                entity.HasIndex(e => e.Active, "active");

                entity.HasIndex(e => e.PubliclyAvailable, "publicly_available");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("int(11)")
                    .HasColumnName("price");

                entity.Property(e => e.PubliclyAvailable).HasColumnName("publicly_available");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.HasIndex(e => e.Edited, "Edited");

                entity.HasIndex(e => e.Approved, "approved");

                entity.HasIndex(e => e.Deleted, "deleted");

                entity.HasIndex(e => e.GroupId, "group_id");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.PostBody)
                    .IsRequired()
                    .HasColumnName("post_body");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<PostActivityLog>(entity =>
            {
                entity.ToTable("post_activity_logs");

                entity.HasIndex(e => e.PostActivityLogTypeId, "post_activity_log_type_id");

                entity.HasIndex(e => e.PostId, "post_id");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.PostActivityLogTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("post_activity_log_type_id");

                entity.Property(e => e.PostId)
                    .HasColumnType("int(11)")
                    .HasColumnName("post_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.ToTable("time_zones");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("display_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.NixName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("nix_name");

                entity.Property(e => e.ObservesDst).HasColumnName("observes_dst");
            });

            modelBuilder.Entity<Upload>(entity =>
            {
                entity.ToTable("uploads");

                entity.HasIndex(e => e.Deleted, "deleted");

                entity.HasIndex(e => e.PostId, "post_id");

                entity.HasIndex(e => e.Removed, "removed");

                entity.HasIndex(e => e.UploadTypeId, "upload_type_id");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.PostId)
                    .HasColumnType("int(11)")
                    .HasColumnName("post_id");

                entity.Property(e => e.Removed).HasColumnName("removed");

                entity.Property(e => e.UploadTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("upload_type_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<UploadType>(entity =>
            {
                entity.ToTable("upload_types");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.FileExtensions)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("file_extensions");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.PubliclyAvailable).HasColumnName("publicly_available");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Active, "active");

                entity.HasIndex(e => e.Admin, "admin");

                entity.HasIndex(e => e.PrimaryLanguageId, "primary_language_id");

                entity.HasIndex(e => e.ProfilePhotoId, "profile_photo_id");

                entity.HasIndex(e => e.Support, "support");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("binary(64)")
                    .HasColumnName("password");

                entity.Property(e => e.PrimaryLanguageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("primary_language_id");

                entity.Property(e => e.ProfilePhotoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("profile_photo_id");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnType("binary(64)")
                    .HasColumnName("salt");

                entity.Property(e => e.Support).HasColumnName("support");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
