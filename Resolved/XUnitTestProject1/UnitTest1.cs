using TDDExample;
using TDDExample.Model;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1 : BaseTest
    {
        /// <summary>
        /// Requirement: field Email is required
        /// Test: Email field is empty
        /// Expected Result: no data saved
        /// </summary>
        [Fact]
        public void Test1()
        {
            // Arrange
            var customer = new Customer
            {
                Id = 2,
                Email = ""
            };

            var saveMock = new SaveMock();

            var validator = new Program.SaveCustomer(saveMock);

            // Act
            var result = validator.SaveAndValidate(customer);

            // Assert
            Assert.False(result);
            Assert.True(saveMock.Get(2) == null);
        }

        /// <summary>
        /// Requirement: field Name is optional
        /// Test: Name field is empty
        /// Expected Result: Data should be saved
        /// </summary>
        [Fact]
        public void Test2()
        {
            // Arrange
            var customer = new Customer
            {
                Id = 3,
                Name = ""
            };
            var saveMock = new SaveMock();
            var validator = new Program.SaveCustomer(saveMock);

            // Act
            var result = validator.SaveAndValidate(customer);

            // Assert
            Assert.True(result);
            Assert.True(saveMock.Get(3) != null);
        }
    }
}
