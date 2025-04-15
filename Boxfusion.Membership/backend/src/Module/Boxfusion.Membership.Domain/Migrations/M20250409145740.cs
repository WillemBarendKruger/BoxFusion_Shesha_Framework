using System;
using Shesha.FluentMigrator;
using FluentMigrator;

namespace Boxfusion.Membership.Domain.Migrations
{
    // <summary>
    /// Adding the Members table
    /// </summary>
    /// 

    [Migration(20250409145740)]
    public class M20250409145740 : Migration
    {
        /// <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        public override void Up()
        {
            Alter.Table("Core_Persons")
                .AddColumn("Mem_MembershipNumber").AsString().Nullable()
                .AddForeignKeyColumn("Mem_IdDocumentId", "Frwk_StoredFiles").Nullable()
                .AddColumn("Mem_MembershipStartDate").AsDateTime().Nullable()
                .AddColumn("Mem_MembershipEndDate").AsDateTime().Nullable()
                .AddColumn("Mem_MembershipStatusLkp").AsInt64().Nullable();
        }
        /// <summary>
        /// Code to execute when rolling back the migration
        /// </summary>
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
