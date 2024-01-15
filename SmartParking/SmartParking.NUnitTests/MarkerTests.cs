using NUnit.Framework;
using SmartParking.DAL.Repositories;
using SmartParking.DAL.Data;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace SmartParking.NUnitTests
{
    public class MarkerTests
    {
        [Test]
        public void GetLatitudeById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 10;
            MarkerRepository repository = MarkerRepository.GetInstance();

            double expectedResult = 42.510495;
            double actualResult;
            // Act
            actualResult = repository.GetLatitudeById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetLongitudeById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 15;
            MarkerRepository repository = MarkerRepository.GetInstance();

            double expectedResult = 27.454900;
            double actualResult;
            // Act
            actualResult = repository.GetLongitudeById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetNameById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 18;
            MarkerRepository repository = MarkerRepository.GetInstance();

            string expectedResult = "Fines Charging Moto Pfohe Burgas";
            string actualResult;

            // Act
            actualResult = repository.GetNameById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void GetParkingSpacesById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 2;
            MarkerRepository repository = MarkerRepository.GetInstance();

            int expectedResult = 450;
            int actualResult;

            // Act
            actualResult = repository.GetParkingSpacesById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetMonthlySubscriptionPriceById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 2;
            MarkerRepository repository = MarkerRepository.GetInstance();

            string expectedResult = "BGN 170";
            string actualResult;

            // Act
            actualResult = repository.GetMonthlySubscriptionPriceById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetStayForADayPriceById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 1;
            MarkerRepository repository = MarkerRepository.GetInstance();

            string expectedResult = "BGN 10";
            string actualResult;

            // Act
            actualResult = repository.GetStayForADayPriceById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetStayPerHourPriceById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 1;
            MarkerRepository repository = MarkerRepository.GetInstance();

            string expectedResult = "BGN 1";
            string actualResult;

            // Act
            actualResult = repository.GetStayPerHourPriceById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetCapacityById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 25;
            MarkerRepository repository = MarkerRepository.GetInstance();

            string expectedResult = "Three Type 2 22 kW plug AC standard charging station";
            string actualResult;

            // Act
            actualResult = repository.GetCapacityById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetChargerWorkingHoursById_ValidId_ReturnsCorrectValue()
        {
            // Arrange
            int validId = 34;
            MarkerRepository repository = MarkerRepository.GetInstance();

            string expectedResult = "6 AM - 12 PM";
            string actualResult;

            // Act
            actualResult = repository.GetChargerWorkingHoursById(validId);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
