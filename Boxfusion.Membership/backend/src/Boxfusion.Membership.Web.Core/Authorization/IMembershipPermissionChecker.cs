using Shesha.Domain;
using System.Threading.Tasks;

namespace Boxfusion.Membership.Common.Authorization
{
    /// <summary>
    /// Membership Permission checker
    /// </summary>
    public interface IMembershipPermissionChecker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Task<bool> IsDataAdministrator(Person person);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Task<bool> IsGlobalAdmin(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsFacilityAdmin(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsCapturer(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsViewer(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsApproverLevel1(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsApproverLevel2(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsManager(Person person);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Task<bool> IsAdmin(Person person);

       
        //Task<bool> IsScheduleManager(Person person);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns></returns>
        //Task<bool> IsScheduleFulfiller(Person person);
    }
}
