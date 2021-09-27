namespace TestAPIDemo.APITests
{
   public class Tests
   {
      [NUnit.Framework.Category("Test")]
      [NUnit.Framework.Test]
      public async System.Threading.Tasks.Task TestAPICall()
      {
         TestAPIDemo.API.Request.API api = new TestAPIDemo.API.Request.API();

         var response = await api.testRequest();
      }
   }
}
