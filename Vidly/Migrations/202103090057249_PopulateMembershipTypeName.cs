namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Pay as You Go' where DurationInMonths = 0");
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Monthly' where DurationInMonths = 1");
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Quarterly' where DurationInMonths = 3");
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Yearly' where DurationInMonths = 12");
        }

        public override void Down()
        {
            Sql("UPDATE dbo.MembershipTypes SET Name = NULL where DurationInMonths = 0");
            Sql("UPDATE dbo.MembershipTypes SET Name = NULL where DurationInMonths = 1");
            Sql("UPDATE dbo.MembershipTypes SET Name = NULL where DurationInMonths = 3");
            Sql("UPDATE dbo.MembershipTypes SET Name = NULL where DurationInMonths = 12");
        }
    }
}
