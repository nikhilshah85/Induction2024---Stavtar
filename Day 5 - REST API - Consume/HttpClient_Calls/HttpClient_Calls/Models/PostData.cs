namespace HttpClient_Calls.Models
{
    public class PostData
    {
        //1. create properties for incoming data
        public int userid { get; set; }
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        //2. create a variable to store the data 
        List<PostData> postList = new List<PostData>();

        //3. create a method to make the call
        public List<PostData> GetPostData()
        {
            //4. set the url in a variable
            string url = "https://jsonplaceholder.typicode.com/posts";

            //5. create a new object of HttpClient
            HttpClient client = new HttpClient();

            //6. clear the data default data format from clients calling environment
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //7. Make a call
            var result = client.GetAsync(url).Result;

            //8. check if call is successfull, if success read the data, else show error
            if(result.IsSuccessStatusCode) 
            {
                    var data = result.Content.ReadAsAsync<List<PostData>>();
                    data.Wait();
                    postList = data.Result.ToList();
                    return postList;
            }
            throw new Exception("Something went wrong, please contact Admin");       
        
        
        }



    }
}
