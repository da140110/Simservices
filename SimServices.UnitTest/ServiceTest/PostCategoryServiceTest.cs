using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimServices.Data.Infrastructure;
using SimServices.Data.Repositories;
using SimServices.Model.Models;

namespace SimServices.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private Mock<PostCategory> _mockPostCategory;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository=new Mock<IPostCategoryRepository>();
        _mockUnitOfWork=new Mock<IUnitOfWork>();
         _mockPostCategory=new Mock<PostCategory>();
    }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {

        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {

        }
    }
}
