using Tyuiu.RochevYA.Sprint5.Task1.V5.Lib;
namespace Tyuiu.RochevYA.Sprint5.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(24576, ds.SaveToFileTextData(2));
        }
    }
}
