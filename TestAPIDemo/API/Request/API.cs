namespace TestAPIDemo.API.Request
{
   class API
   {

      private System.Net.Http.HttpClient  restClient = new System.Net.Http.HttpClient();

      private string URI = "https://api.publicapis.org";

      public async System.Threading.Tasks.Task<string> testRequest()
      {
         var Builder = new System.UriBuilder($"{URI}/entries?category=animals&https=true");

         var response = await restClient.GetAsync(Builder.Uri);

         var context = await response.Content.ReadAsStringAsync();

         return context;
      }
   }
}
