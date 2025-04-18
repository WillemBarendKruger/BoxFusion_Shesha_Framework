﻿using Castle.Components.DictionaryAdapter;
using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Membership.Domain.Enums
{
    /// <summary>
    /// Statuses for a Members Membership
    /// </summary>
    [ReferenceList("Mem", "MembershipStatuses")]
    public enum RefListMembershipStatuses : long
    {
        /// <summary>
        /// Membership status is still being processed
        /// </summary>
        [Description("In Progress")]
        InProgress = 1,

        /// <summary>
        /// Membership status is active
        /// </summary>
        [Description("Active")]
        Active = 2,

        /// <summary>
        /// Membership status is cancelled
        /// </summary>
        [Description("Cancelled")]
        Cancelled = 3
    }

    //class RefListMembershipStatuses
    //{
       
    //}
}
