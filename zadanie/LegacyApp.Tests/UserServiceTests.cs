using System.Text;

namespace LegacyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        // Arrange
        var userService = new UserService();
        //Act
        var result = userService.AddUser(
            null,
            "Smith",
            "smith@CodePagesEncodingProvider.com",
            DateTime.Parse("2000-01-01"),
            1
        );

        //Assert
        Assert.False(result);
    }
    [Fact]
    public void AddUser_ThrowsExceptionIfClientDoesNotExist()
    {
        // Arrange
        var userService = new UserService();
        //Act
        Action action = () => userService.AddUser(
            "Joe",
            "Smith",
            "smith@CodePagesEncodingProvider.com",
            DateTime.Parse("2000-01-01"),
            100
        );

        //Assert
        Assert.Throws<ArgumentException>(action);
    }
}