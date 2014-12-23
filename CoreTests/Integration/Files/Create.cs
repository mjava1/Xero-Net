using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Files
{
    [TestFixture]
    public class Create : ApiWrapperTest
    {
        [Test]
        public void create_folder()
        {
            var name = "Folder " + Random.GetRandomString(10);
            var result = Api.Create(new Folder
            {              
                Name = name
            });

            Assert.AreEqual(name, result.Name);
        }
    }
}
