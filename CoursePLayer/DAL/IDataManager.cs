

using System.Collections.Generic;
namespace HRS.CoursePlayer
{
    /// <summary>
    /// Base interface for all Data Access Managers.
    /// </summary>
    public interface IDataManager<T>
    {        

        /// <summary>
        /// Return Filled object
        /// </summary>
        /// <param name="pEntBase">Object with Search Criteria</param>
        /// <returns>Filled object</returns>
        T Get(T pEntBase);

        /// <summary>
        /// Update Filled object
        /// </summary>
        /// <param name="pEntBase">Object with filled properties</param>
        /// <returns>Updated object</returns>
        T Update(T pEntBase);
    }
}