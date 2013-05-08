﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IFluentAssertionRunner.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    using System;

    /// <summary>
    /// Provides a mean to execute a fluent assertion, taking care of whether it should be negated or not, etc.
    /// This interface is designed for developers that need to add new assertion (extension) methods.
    /// Thus, it should not be exposed via Intellisense to developers that are using NFluent to write 
    /// assertions statements.
    /// </summary>
    /// <typeparam name="T">Type of the value to assert on.</typeparam>
    public interface IFluentAssertionRunner<out T>
    {
        /// <summary>
        /// Executes the assertion provided as an happy-path lambda (vs lambda for negated version).
        /// </summary>
        /// <param name="action">The happy-path action (vs. the one for negated version which has not to be specified).</param>
        /// <param name="negatedExceptionMessage">The message for the negated exception.</param>
        /// <returns>
        /// A new chainable fluent assertion.
        /// </returns>
        /// <exception cref="FluentAssertionException">The assertion fails.</exception>
        IChainableFluentAssertion<IFluentAssertion<T>> ExecuteAssertion(Action action, string negatedExceptionMessage);
    }
}