using HR_Platform_Intens.Controllers;
using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace xUnitTests
{
    public class CandidateControllerTest
    {
        

        [Fact]
        public void GetReturnsProjectWithSameId()
        {
            CandidateResponse candidate = new CandidateResponse { Id = 42, FullName = "Name1", ContractNumber = 5, Email="name1@mail.com" };
            // Arrange
            var mockService = new Mock<ICandidateService>();
            mockService.Setup(x => x.GetById(42)).Returns(candidate);

            var controller = new CandidatesController(mockService.Object);

            //var result = controller.GetById(42);
            // Act
            IActionResult actionResult = controller.GetById(42);
            var contentResult = actionResult;


            // Assert
           
            Assert.NotNull(contentResult);
          
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
