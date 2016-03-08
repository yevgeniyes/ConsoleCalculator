using Facebook;
using System;

namespace ConsoleCalculator
{
    class FBOperation : WebOperationBase
    {
        protected override void Execute(string[] splitedInput)
        {
            string appId = "991787327578152";
            string appSecret = "61defee03eef1dbba596ec37c74dac14";
            string command = splitedInput[1];

            string accessToken = GetAccessToken(appId, appSecret);

            Console.WriteLine("Access token: " + accessToken + "\n");

            var client = new FacebookClient(accessToken);

            switch (command)
            {
                case "list":
                    List(client, appId);
                    break;
                default:
                    CreateUser(client, appId, command);
                    break;
            }
        }

        private string GetAccessToken(string appId, string appSecret)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Get("oauth/access_token", new
            {
                client_id = appId,
                client_secret = appSecret,
                grant_type = "client_credentials"
            });

            string accessToken = result.access_token;
            return accessToken;
        }

        private void List(FacebookClient client, string appId)
        {
            dynamic testUsersList = client.Get(appId + "/accounts/test-users");
            string srt_testUsersList = testUsersList.ToString();
            string[] arr = srt_testUsersList.Split('{', ',');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("id"))
                    Console.WriteLine(arr[i] + "\n");
            }
        }

        private void CreateUser(FacebookClient client, string appId, string command)
        {
            try
            {
                dynamic testUsers = client.Post(appId + "/accounts/test-users", new
                {
                    installed = true,
                    name = command,
                    permissions = "read_stream"
                });
                var testuserId = testUsers.id;
                Console.WriteLine("User was created: id: " + testuserId + "\n");
            }
            catch
            {
                Console.WriteLine("Invalid user name. Try another name\n");
            }
        }
    }
}
