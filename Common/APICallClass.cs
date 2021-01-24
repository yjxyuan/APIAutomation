using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCardsTesting.Common
{
    /// <summary>
    /// This is the class handle all the API calls.
    /// </summary>
    public static class APICallClass
    {
        /// <summary>
        /// This is the base API call function
        /// </summary>
        /// <param name="requestURL">API request URL</param>
        /// <param name="requestMethod">The request method</param>
        /// <param name="queryparameters">The query parameters dictionary</param>
        /// <returns>The parsed response Json object</returns>
        private static JObject APICallBaseFunction(string requestURL, Method requestMethod, Dictionary<string, string> queryparameters)
        {
            //define the API client, request
            RestClient client = new RestClient(BaseClass.GetConfigValues()["TestURL"].ToString());
            RestRequest request = new RestRequest(requestURL, requestMethod);
            //define request format and append query parameters.
            request.RequestFormat = DataFormat.Json;
            if(queryparameters.Count>0)
            {
                foreach(var item in queryparameters)
                {
                    request.AddQueryParameter(item.Key, item.Value);
                }
            }
            //Make the api call, get the response
            //TODO: handle exceptions.
            IRestResponse response = client.Execute(request);
            //Parse the reponse to Json Object, and return the json object
            JObject obs = JObject.Parse(response.Content);
            return obs;
        }

        /// <summary>
        /// Shuffle the Cards API.
        /// </summary>
        /// <param name="queryparameters">Query parameters Dictionary</param>
        /// <returns>The parsed response Json object</returns>
        public static JObject ShuffleTheCardsAPI(Dictionary<string, string> queryparameters)
        {
            //pass the parameters & call the base API call function
            return APICallBaseFunction(BaseClass.GetConfigValues()["NewShufflePath"].ToString(), Method.GET, queryparameters);              
        }

        /// <summary>
        /// Draw Cards API
        /// </summary>
        /// <param name="deck_id">the deck_id value to draw from</param>
        /// <param name="queryparameters">Query parameters Dictionary</param>
        /// <returns>The parsed response Json object</returns>
        public static JObject DrawCardsAPI(string deck_id, Dictionary<string, string> queryparameters)
        {
            //replace the deck_id place holder with valid deck_id from previous request
            string drawCardsPath = BaseClass.GetConfigValues()["DrawCardsPath"].ToString();
            drawCardsPath=drawCardsPath.Replace("<<deck_id>>", deck_id);
            //pass the parameters & call the base API call function
            return APICallBaseFunction(drawCardsPath, Method.GET, queryparameters);
        }
    }
}
