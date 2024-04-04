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

    [Fact]
    public void CheckIfDataIsCorrect_ReturnsFalseWhenFirstLastEmailIsIncorrect()
    {
        //Arrange
        var userService = new UserService();
        //Act
        var result = userService.CheckIfDataIsCorrect(
            "null",
            "Smith",
            "myemailcom"
            );
        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsAtLeast21_ReturnsFalseWhenIsnt()
    {
        //Arrange
        var userService = new UserService();
        //Act
        var result = userService.IsAtLeast21(
            DateTime.Now
        );
        //Assert
        Assert.False(result);
    }
    [Fact]
    public void ClientExists_ThrowsExceptionWhenDoesnt()
    {
        //Arrange
        var userService = new UserService();
        //Act
        Action action = () => userService.ClientExists(
            1000
            );
        //Assert
        Assert.Throws<ArgumentException>(action);
    }

    [Fact]
    public void AddUser_ReturnsFalseWhenCreditLimitUnder500()
    {
        //Arrange
        var userService = new UserService();
        //Act
        var result = userService.AddUser(
            "James",
            "Kowalski",
            "licenceToKill@007.pl",
            DateTime.Parse("2000-01-01"),
            5
            );
        //Assert
        Assert.False(result);
    }
}