using CatalogServicesTDD.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CatalogServicesTDD.Tests
{
    [TestClass]
    public class JlaCatalogTests
    {
        [TestInitialize]
        public void Setup()
        {
            var mock = new Moq.Mock<CatalogContext>();
        }

        [TestMethod]
        public void CatalogShouldReturnListOfItems()
        {
        }

        //CatalogShouldreturnListOfItems()
        //CatalogShouldReturnItemById()
        //CatalogShouldReturnItemPrice()
        //CatalogShouldReturnItemTitle()
        //CatalogShouldHavePagination() ?
    }

    //public Mock<CatalogContext> MoqCatalogContext()
    //{
    //    var mock = new Mock<CatalogContext>();
    //    return mock;
    //}
}
