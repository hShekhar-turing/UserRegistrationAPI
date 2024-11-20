using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationAPI.Models;

namespace ModelATest
{
    public class UserRegistrationTests
    {
        // Test cases for Email
        [Fact]
        public void Email_Empty_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { Email = string.Empty };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Email is required"));
        }

        [Fact]
        public void Email_InvalidFormat_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { Email = "invalid_email" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Invalid email address"));
        }

        [Fact]
        public void Email_ValidFormat_ReturnsNoError()
        {
            // Arrange
            var user = new UserRegistrationModel { Email = "valid_email@example.com" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.False(validationResults.Contains("Email"));
        }

        // Test cases for Password
        [Fact]
        public void Password_Empty_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { Password = string.Empty };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Password is required"));
        }

        [Fact]
        public void Password_TooShort_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { Password = "short" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Password must be between 6 and 100 characters"));
        }

        [Fact]
        public void Password_ValidLength_ReturnsNoError()
        {
            // Arrange
            var user = new UserRegistrationModel { Password = "valid_password" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.False(validationResults.Contains("Password"));
        }

        // Test cases for Confirm Password
        [Fact]
        public void ConfirmPassword_Empty_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { ConfirmPassword = string.Empty };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Confirm Password is required"));
        }

        [Fact]
        public void ConfirmPassword_DoesNotMatchPassword_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { Password = "password", ConfirmPassword = "different_password" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Passwords do not match"));
        }

        [Fact]
        public void ConfirmPassword_MatchesPassword_ReturnsNoError()
        {
            // Arrange
            var user = new UserRegistrationModel { Password = "password", ConfirmPassword = "password" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.False(validationResults.Contains("Confirm Password"));
        }

        // Test cases for First Name
        [Fact]
        public void FirstName_Empty_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { FirstName = string.Empty };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("First Name is required"));
        }

        [Fact]
        public void FirstName_TooShort_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { FirstName = "a" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("First Name must be between 2 and 50 characters"));
        }

        [Fact]
        public void FirstName_ValidLength_ReturnsNoError()
        {
            // Arrange
            var user = new UserRegistrationModel { FirstName = "John" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.False(validationResults.Contains("First Name"));
        }

        // Test cases for Last Name
        [Fact]
        public void LastName_Empty_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { LastName = string.Empty };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Last Name is required"));
        }

        [Fact]
        public void LastName_TooShort_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { LastName = "a" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Last Name must be between 2 and 50 characters"));
        }

        [Fact]
        public void LastName_ValidLength_ReturnsNoError()
        {
            // Arrange
            var user = new UserRegistrationModel { LastName = "Doe" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.False(validationResults.Contains("Last Name"));
        }

        // Test cases for Phone Number
        [Fact]
        public void PhoneNumber_Empty_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { PhoneNumber = string.Empty };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Phone Number is required"));
        }

        [Fact]
        public void PhoneNumber_InvalidFormat_ReturnsError()
        {
            // Arrange
            var user = new UserRegistrationModel { PhoneNumber = "invalid_phone_number" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.True(validationResults.Contains("Invalid phone number"));
        }

        [Fact]
        public void PhoneNumber_ValidFormat_ReturnsNoError()
        {
            // Arrange
            var user = new UserRegistrationModel { PhoneNumber = "123-456-7890" };

            // Act
            var validationResults = ValidateUser(user);

            // Assert
            Xunit.Assert.False(validationResults.Contains("Phone Number"));
        }

        // Helper method to validate user
        private string ValidateUser(UserRegistrationModel user)
        {
            var validationContext = new ValidationContext(user);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(user, validationContext, validationResults);

            return string.Join(", ", validationResults.Select(r => r.ErrorMessage));
        }
    }
}
