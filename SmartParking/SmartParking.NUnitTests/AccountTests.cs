using NUnit.Framework;
using SmartParking.DAL.Repositories;
using System;

namespace SmartParking.NUnitTests
{
    // Unit tests for the AccountRepository class.
    public class AccountTests
    {
        // Test for the VerifyAccount method with valid credentials.
        [Test]
        public void VerifyAccount_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = true;
            bool actualResult;
            // Act
            actualResult = repository.VerifyAccount("ObshtinaBurgas", "1234");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        // Test for the VerifyAccount method with invalid credentials.
        [Test]
        public void VerifyAccount_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = false;
            bool actualResult;

            // Act
            actualResult = repository.VerifyAccount("Obshtina", "12345678");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        // Test for the IsAccountAlreadyRegistered method with a non-existing email.
        [Test]
        public void IsAccountAlreadyRegistered_NonExistingEmail_ReturnsFalse()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = false;
            bool actualResult;

            // Act
            actualResult = repository.IsAccountAlreadyRegistered("obshtina@plovdiv.bg");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        public void IsAccountAlreadyRegistered_ExistingEmail_ReturnsTrue()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = true;
            bool actualResult;

            // Act
            actualResult = repository.IsAccountAlreadyRegistered("obshtina@burgas.bg");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void IsAccountAlreadyRegistered_ExistingEmailAndUsername_ReturnsTrue()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool result;

            // Act
            result = repository.IsAccountAlreadyRegistered("obshtina@burgas.bg", "ObshtinaBurgas");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsAccountAlreadyRegistered_NonExistingEmailAndUsername_ReturnsFalse()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = false;
            bool actualResult;

            // Act
            actualResult = repository.IsAccountAlreadyRegistered("obshtina@plovdiv.bg", "ObshtinaPlovdiv");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void IsAdmin_AdminUser_ReturnsTrue()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = true;
            bool actualResult;

            // Act
            actualResult = repository.IsAdmin("ObshtinaBurgas");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void IsAdmin_NonAdminUser_ReturnsFalse()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            bool expectedResult = false;
            bool actualResult;

            // Act
            actualResult = repository.IsAdmin("Test");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void AddAccount_ValidAccount_AddsAccountSuccessfully()
        {
            // Arrange
            AccountRepository repository = AccountRepository.GetInstance();

            // Act
            repository.AddAccount("NewUser", "newuser@email.com", "NewPassword");

            // Assert
            Assert.IsTrue(repository.IsAccountAlreadyRegistered("newuser@email.com"));
        }
    }
}