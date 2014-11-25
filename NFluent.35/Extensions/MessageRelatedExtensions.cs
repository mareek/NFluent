﻿#region File header

//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="MessageRelatedExtensions.cs" company="">
//    Copyright 2014 Thomas PIERRAIN, Cyrille DUPUYDAUBY
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------
#endregion

namespace NFluent
{
    using NFluent.Extensibility;

    /// <summary>
    /// </summary>
    public static class MessageRelatedExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// </summary>
        /// <typeparam name="T">
        /// </typeparam>
        /// <param name="check">
        /// </param>
        /// <param name="sutLabel">
        /// </param>
        /// <returns>
        /// The <see cref="ICheck{T}"/>.
        /// </returns>
        public static ICheck<T> As<T>(this ICheck<T> check, string sutLabel)
        {
            var checker = ExtensibilityHelper.ExtractChecker(check);
            checker.SetSutLabel(sutLabel);
            return check;
        }

        #endregion
    }
}