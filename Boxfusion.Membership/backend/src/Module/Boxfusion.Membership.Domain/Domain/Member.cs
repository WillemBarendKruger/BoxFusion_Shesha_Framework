using Shesha.Domain.Attributes;
using Shesha.Domain;
using System;
using Boxfusion.Membership.Domain.Enums;

namespace Boxfusion.Membership.Domain.Domain
{
    /// <summary>
    /// A person within the application that is a Member
    /// </summary
    [Entity(TypeShortAlias = "Mem.Member")]
    public class Member : Person
    {
        /// <summary>
        /// The membership number for the Member
        /// </summary>
        public virtual string MembershipNumber { get; set; }

        /// <summary>
        /// The date when the Members membership started
        /// </summary>
        public virtual DateTime? MembershipStartDate { get; set; }

        /// <summary>
        /// The date when the Members membership ended
        /// </summary>
        public virtual DateTime? MembershipEndDate { get; set; }

        /// <summary>
        /// Identification document for the Member
        /// </summary>
        public virtual StoredFile IdDocument { get; set; }

        /// <summary>
        /// The status of the membership
        /// </summary>
        [ReferenceList("Mem", "MembershipStatuses")]
        public virtual RefListMembershipStatuses? MembershipStatus { get; set; }
    }
}
