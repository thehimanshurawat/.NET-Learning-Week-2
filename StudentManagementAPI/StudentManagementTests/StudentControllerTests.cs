using Moq;
using StudentManagementAPI.Controllers;
using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace StudentManagementTests
{
    public class StudentControllerTests
    {
        private readonly Mock<IStudentRepository> _mockRepo;
        private readonly StudentController _controller;

        public StudentControllerTests()
        {
            _mockRepo = new Mock<IStudentRepository>();
            _controller = new StudentController(_mockRepo.Object);
        }

        [Fact]
        public async Task GetStudents_ReturnsOkResult()
        {
            _mockRepo.Setup(repo => repo.GetAllStudents())
                     .ReturnsAsync(new List<Student>());

            var result = await _controller.GetStudents();

            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public async Task GetStudent_ReturnsNotFound()
        {
            _mockRepo.Setup(repo => repo.GetStudentById(1)).ReturnsAsync((Student)null);

            var result = await _controller.GetStudent(1);

            Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
