using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RavenEmbeddedTestDriverOnGithub
{
	[TestClass]
	public class UnitTest1 : Raven.TestDriver.RavenTestDriver
	{

		public class TestClass
		{
			public string Id { get; set; }
			public string Name { get; set; }
		}

		[TestMethod]
		public void TestMethod1() {
			using (var store = GetDocumentStore()) {
				using (var session = store.OpenSession()) {
					session.Store(new TestClass { Name = "Test" });
					session.SaveChanges();
				}
			}
		}
	}
}
