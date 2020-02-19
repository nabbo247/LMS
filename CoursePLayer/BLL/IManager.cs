

using System.Collections.Generic;
using System;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// Base interface for all Business Managers.
    /// </summary>
    public interface IManager<T, M, L>
    {        

        /// <summary>
        /// Returns Object as per requested method
        /// </summary>
        /// <param name="pEntBase">Entity Onject as BaseEntity</param>
        /// <param name="pMethod">Method type</param>
        /// <returns>Return Entity Object as BaseEntity</returns>
        T Execute(T pEntBase, M pMethod);

        /// <summary>
        /// Returns Object List as per requested method
        /// </summary>
        /// <param name="pEntBase">Entity Onject as BaseEntity</param>
        /// <param name="pMethod">List Method type</param>
        /// <returns>Return List of Entity Object</returns>
        List<T> Execute(T pEntBase, L pMethod);

        /// <summary>
        /// Returns DataSet as per requested method
        /// </summary>
        /// <param name="pEntBase">Entity Object as BaseEntiy</param>
        /// <param name="pMethod">Method type</param>
        /// <returns>Return DataSet filled with data</returns>
        System.Data.DataSet ExecuteDataSet(T pEntBase, L pMethod);

      

    }
}