using AutoMapper;
using HR_Platform_Intens.Controllers;
using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using Xunit;

namespace xUnitTests
{
    public class CandidateControllerTest
    {
        //CandidatesController _controller;
        //ICandidateService _service;


        //public CandidateControllerTest()
        //{
        //    _service = new CandidateServceFake();//za ovo sam u candidateservicefake morao da napravim prazan konstruktor

        //    //nece da prihvati prazan objekat zato sto tamo prima IMapper mapper
        //    _controller = new CandidatesController(_service);
        //}
        //[Fact]
        //public void Get_WhenCalled_ReturnsOkResult()
        //{
        //    string name = null;
        //    int skillId = 0;
        //    // Act
        //    var okResult = _controller.GetAll(name, skillId);
        //    // Assert
        //    Assert.IsType<CandidateResponse>(okResult);
        //}
        ////[Fact]
        ////public void Get_WhenCalled_ReturnsAllItems()
        ////{
        ////    string name = null;
        ////    int skillId = 0;
        ////    // Act
        ////    var okResult = _controller.GetAll(name, skillId) as CandidateResponse;
        ////    // Assert
        ////    var candidates = Assert.IsType<List<CandidateResponse>>(okResult);
        ////    Assert.Equal(3, candidates.Count);
        ////}
        ///
        [Fact]
        public void GetReturnsProjectWithSameId()
        {
            // Arrange
            var mockService = new Mock<ICandidateService>();
            mockService.Setup(x => x.GetById(42)).Returns(new CandidateResponse { Id = 42, FullName = "Name1" });

            var controller = new CandidatesController(mockService.Object);

            //var result = controller.GetById(42);
            // Act
            IActionResult actionResult = controller.GetById(42);
            var contentResult = actionResult as OkNegotiatedContentResult<CandidateResponse>;


            // Assert
            Assert.IsType<CandidateResponse>(contentResult.Content);
            //Assert.NotNull(contentResult);
            //Assert.NotNull(contentResult);
            //Assert.IsType<CandidateResponse>(contentResult);
        }


        [Fact]
        public void GetReturnsNotFound()
        {
            // Arrange
            var mockService = new Mock<ICandidateService>();
            var controller = new CandidatesController(mockService.Object);

            // Act
            IActionResult actionResult = controller.GetById(10);

            // Assert
            Assert.NotNull(actionResult);
        }

        [Fact]
        public void GetReturnsMultipleObjects()
        {

            string name = null;
            int skillId = 0;
            // Arrange
            List<CandidateResponse> candidateResponses = new List<CandidateResponse>();
            candidateResponses.Add(new CandidateResponse { Id = 1, FullName = "Pera" });
            candidateResponses.Add(new CandidateResponse { Id = 2, FullName = "Mika" });

            var mockService = new Mock<ICandidateService>();
            mockService.Setup(x => x.GetAll(name, skillId)).Returns(candidateResponses.AsEnumerable());
            var controller = new CandidatesController(mockService.Object);

            // Act
            IEnumerable<CandidateResponse> result = controller.GetAll(name, skillId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(candidateResponses.Count, result.ToList().Count);
            Assert.Equal(candidateResponses.ElementAt(0), result.ElementAt(0));
            Assert.Equal(candidateResponses.ElementAt(1), result.ElementAt(1));
        }


    }
}
