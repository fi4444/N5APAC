namespace PAC.Tests.WebApi;
using System.Collections.ObjectModel;

using System.Data;
using Moq;
using PAC.IBusinessLogic;
using PAC.Domain;
using PAC.WebAPI;
using Microsoft.AspNetCore.Mvc;

[TestClass]
public class StudentControllerTest
{
    private readonly Mock<IStudentLogic> _studentServiceMock = new Mock<IStudentLogic>(MockBehavior.Strict);

    private StudentController controller;

    [TestInitialize]
    public void InitTest()
    {
        controller = new StudentController(_studentServiceMock.Object);
    }

    [TestMethod]
    public void CreateStudentFail()
    {
        Assert.Fail();
    }

    [TestMethod]
    public void CreateStudent()
    {
        _studentServiceMock.Setup(x => x.InsertStudents(It.IsAny<Student>()));
        controller.CreateStudent(new Student()
        {
            Name = "Test"
        });
        _studentServiceMock.VerifyAll();
    }
}
