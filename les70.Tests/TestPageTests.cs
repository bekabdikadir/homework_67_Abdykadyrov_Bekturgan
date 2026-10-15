using les70.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using Xunit;

public class TestPageShortTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(5, 6)]
    [InlineData(-1, 0)]
    public void TestPage_IncrementsPage(int page, int expected)
    {
        var controller = new HomeController();
        var result = controller.TestPage(page) as ViewResult;

        Assert.NotNull(result);
        Assert.NotNull(result.Model);
        Assert.Equal(typeof(TestPageViewModel), result.Model.GetType());
        var model = result.Model as TestPageViewModel;
        Assert.Equal(expected, model.Page);
        Assert.Equal(expected, result.ViewData["PageIncrement"]);
    }
}