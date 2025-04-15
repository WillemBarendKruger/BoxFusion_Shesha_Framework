using FluentMigrator;
using Shesha.FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Membership.Domain.Migrations
{
    [Migration(20250411010405)]
    public class M20250411010405 : Migration
    {
        /// <summary>
        /// Code to execute when executing the migrations
        /// </summary>
        /// 
        public override void Up()
        {
            Create.Table("Mem.MembershipPayments")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithForeignKeyColumn("MemberId", "Core_Persons").Nullable()
                .WithColumn("PaymentDate").AsDateTime().Nullable();
        }

        /// <summary>
        /// Code to execute when rolling back the migration
        /// </summary>
        /// 
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
