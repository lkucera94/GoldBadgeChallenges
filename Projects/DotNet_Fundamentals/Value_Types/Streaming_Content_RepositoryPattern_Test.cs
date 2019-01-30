using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository_Pattern;

namespace Value_Types
{
    [TestClass]
    public class Streaming_Content_RepositoryPattern_Test
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.ContentTitle = "Random Movie";
           
            //--Act
            string actual = content.ContentTitle;
            string expected = "Random Movie";

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StreamingContent_SetIsMatureBoolean_ShouldReturnTrue()
        {
            //Arange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;

            //Act
            bool actual = content.IsMature;
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            //Arrange
            StreamingContent content = new StreamingContent("Random Movie", "Horror", 1.3f, true, 5);

            //Act
            string actual = content.ContentTitle;
            string expected = "Random Movie";

            bool actualTwo = content.IsMature;
            bool expectedTwo = true;

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedTwo, actualTwo);


        }

        [TestMethod]
        public void StreamingContentRepository_AddToList_ShouldReturnCorrectCount()
        {
            StreamingContent content = new StreamingContent();
            StreamingContent contentTwo = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();


            repo.AddContentToList(content);
            repo.AddContentToList(contentTwo);

            int actual = repo.GetStreamingContentList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
