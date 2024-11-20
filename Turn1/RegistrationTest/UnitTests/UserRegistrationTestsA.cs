using System.ComponentModel.DataAnnotations;
using UserRegistrationAPI.Models;
using Xunit;

namespace UserRegistration.UnitTests
{
    public class UserRegistrationTestsA
    {
        [Fact]
        public void TestValidUserRegistration()
        {
            // Arrange
            var user = new UserB
            {
                Email = "test@example.com",
                Password = "P@ssw0rd",
                ConfirmPassword = "P@ssw0rd",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-456-7890",
                StreetAddress = "123 Main St",
                City = "Anytown",
                State = "CA",
                ZipCode = "12345",
                Country = "USA"
            };

            // Act
            var validationResults = ValidateUser(user);

            // Xunit.Assert
            Xunit.Assert.Empty(validationResults);
        }

        [Fact]
        public void TestInvalidEmail()
        {
            // Arrange
            var user = new UserB
            {
                Email = "invalid-email",
                Password = "P@ssw0rd",
                ConfirmPassword = "P@ssw0rd",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-456-7890",
                StreetAddress = "123 Main St",
                City = "Anytown",
                State = "CA",
                ZipCode = "12345",
                Country = "USA"
            };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.NotEmpty(validationResults);
            Xunit.Assert.Contains(validationResults, vr => vr.ErrorMessage == "Invalid email address");
        }

        [Fact]
        public void TestWeakPassword()
        {
            // Arrange
            var user = new UserB
            {
                Email = "test@example.com",
                Password = "weak",
                ConfirmPassword = "weak",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-456-7890",
                StreetAddress = "123 Main St",
                City = "Anytown",
                State = "CA",
                ZipCode = "12345",
                Country = "USA"
            };

            // Act
            var validationResults = ValidateUser(user);

            // Xunit.Assert
            Xunit.Assert.NotEmpty(validationResults);
            Xunit.Assert.Contains(validationResults, vr => vr.ErrorMessage == "Password must be between 6 and 100 characters");
        }

        [Fact]
        public void TestPasswordMismatch()
        {
            // Arrange
            var user = new UserB
            {
                Email = "test@example.com",
                Password = "P@ssw0rd",
                ConfirmPassword = "different",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-456-7890",
                StreetAddress = "123 Main St",
                City = "Anytown",
                State = "CA",
                ZipCode = "12345",
                Country = "USA"
            };

            // Act
            var validationResults = ValidateUser(user);

            // Xunit.Assert
            Xunit.Assert.NotEmpty(validationResults);
            Xunit.Assert.Contains(validationResults, vr => vr.ErrorMessage == "Passwords do not match");
        }

        // Additional test cases for other fields...

        private IList<ValidationResult> ValidateUser(UserB user)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(user);
            Validator.TryValidateObject(user, validationContext, validationResults);
            return validationResults;
        }
    }
}
