using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMusicStore.Controllers;
using MvcMusicStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers.Tests
{
    [TestClass()]
    public class AlbumsControllerTests
    {
        //[TestMethod()]
        //public void Index()
        //{
        //    // Arrange
        //    //AlbumsController controller = new AlbumsController();

        //    // Act
        //    //ViewResult result = controller.Index() as ViewResult;
        //    //ViewResult result = controller.Index(albums) as ViewResult;
        //    //  var result = controller.Index();

        //    // Assert
        //    //  Assert.IsNotNull(result);
        //    //Assert.IsTrue(true);
        //    //Assert.Fail();
        //}

        [TestMethod()]
        public void AlbumsCreateTest()
        {
            // Arrange
            AlbumsController controller2 = new AlbumsController();

            // Act
            var result2 = controller2.Create();

            // Assert
            Assert.IsNotNull(result2);
        }
    }
}