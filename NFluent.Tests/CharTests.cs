﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="CharTests.cs" company="">
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
namespace NFluent.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CharTests
    {
        #region IsInstanceOf ...

        [Test]
        public void IsInstanceOfWorks()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsInstanceOf<char>();
        }

        [Test]
        public void NotIsInstanceOfWorks()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).Not.IsInstanceOf<string>();
        }

        [Test]
        public void IsNotInstanceOfWorks()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsNotInstanceOf<string>();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is an instance of char whereas it must not.\nThe checked value:\n\t[a] of type: [char]\nThe expected type: different from\n\t[char]")]
        public void NotIsInstanceOfThrows()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).Not.IsInstanceOf<char>();
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is an instance of char whereas it must not.\nThe checked value:\n\t[a] of type: [char]\nThe expected type: different from\n\t[char]")]
        public void IsNotInstanceOfThrows()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsNotInstanceOf<char>();
        }

        #endregion
        
        #region IsEqualTo ...

        [Test]
        public void IsEqualToWorks()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsEqualTo('a');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is different from the expected one.\nThe checked value:\n\t[a]\nThe expected value:\n\t[b]")]
        public void IsEqualToThrowsWithAnotherChar()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsEqualTo('b');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is different from the expected one.\nThe checked value:\n\t[a]\nThe expected value:\n\t[A]")]
        public void IsEqualToThrowsWithSameCharWithDifferentCase()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsEqualTo('A');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked value is different from the expected one.\nThe checked value:\n\t[a] of type: [char]\nThe expected value:\n\t[\"a\"] of type: [string]")]
        public void ACharIsNotEqualToTheSameCharAsString()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsEqualTo("a");
        }

        [Test]
        public void ACharIsIndeedNotEqualToTheSameCharAsString()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).Not.IsEqualTo("a");
        }

        [Test]
        public void ACharIsIndeedNotEqualToTheSameCharAsString2()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsNotEqualTo("a");
        }

        #endregion

        #region IsTheSameButWithDifferentCaseAs

        [Test]
        public void IsSameCharWithDifferentCaseWorks()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsTheSameButWithDifferentCaseAs('A');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked char is the same as the given one but with different case, whereas it must not.\nThe checked char:\n\t[A]\nThe given char:\n\t[a]")]
        public void NotIsSameCharWithDifferentCaseThrows()
        {
            const char FirstLetterLowerCase = 'A';
            Check.That(FirstLetterLowerCase).Not.IsTheSameButWithDifferentCaseAs('a');
        }

        [Test]
        public void NotIsSameCharWithDifferentCaseWorks()
        {
            const char DotCharacter = '.';
            Check.That(DotCharacter).Not.IsTheSameButWithDifferentCaseAs('.');

            const char LowerCasedChar = 'a';
            Check.That(LowerCasedChar).Not.IsTheSameButWithDifferentCaseAs('a');
        }

        [Test]
        public void NotIsSameCharWithDifferentCaseWorksWithADifferentLetterCasedDifferently()
        {
            const char UpperCasedChar = 'Z';
            Check.That(UpperCasedChar).Not.IsTheSameButWithDifferentCaseAs('y');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked char is not the same but with different case as the given one.\nThe checked char:\n\t[a]\nThe given char:\n\t[a]")]
        public void IsSameCharWithDifferentCaseThrowsWithSameCharWithSameCase()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsTheSameButWithDifferentCaseAs('a');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked char is not the same but with different case as the given one.\nThe checked char:\n\t[a]\nThe given char:\n\t[b]")]
        public void IsSameCharWithDifferentCaseThrowsWithAnotherChar()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsTheSameButWithDifferentCaseAs('b');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked char is not the same but with different case as the given one.\nThe checked char:\n\t[a]\nThe given char:\n\t[B]")]
        public void IsSameCharWithDifferentCaseThrowsWithAnotherCharCasedDifferently()
        {
            const char FirstLetterLowerCase = 'a';
            Check.That(FirstLetterLowerCase).IsTheSameButWithDifferentCaseAs('B');
        }

        [Test]
        [ExpectedException(typeof(FluentCheckException), ExpectedMessage = "\nThe checked char is not the same but with different case as the given one.\nThe checked char:\n\t[.]\nThe given char:\n\t[.]")]
        public void IsSameCharWithDifferentCaseThrowsWithPunctuation()
        {
            const char FirstLetterLowerCase = '.';
            Check.That(FirstLetterLowerCase).IsTheSameButWithDifferentCaseAs('.');
        }

        #endregion

    }
}
