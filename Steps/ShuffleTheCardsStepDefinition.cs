using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DeckOfCardsTesting.Steps
{
    /// <summary>
    /// Shuffle the cards step definition
    /// </summary>
    [Binding]
    public sealed class ShuffleTheCardsStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;

        private JObject jobj = null; //The parsed response Json object
        public static string deck_id=null; //The deck_id in the response.
        private Dictionary<string, string> queryParameters = new Dictionary<string, string>(); //Query parameters

        public ShuffleTheCardsStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        /// <summary>
        /// User Request to Shuffle the cards
        /// </summary>
        /// <param name="deck_count">deck_count to shuffle</param>
        /// <param name="jokers_enabled">include jokers or not in the deck</param>
        [Given(@"user shuffle (.*) deck of cards with (.*)")]
        public void GivenUserShuffleDeckOfCardsWithTrue(int deck_count, string jokers_enabled)
        {
            //Clear any existing query parameters and append new query parameters.
            queryParameters.Clear();
            if (deck_count.ToString() != "")
            {
                queryParameters.Add("deck_count", deck_count.ToString());
            }
            if (jokers_enabled.ToString().ToLower() == "true")
            {
                queryParameters.Add("jokers_enabled", jokers_enabled.ToString().ToLower());
            }
            //Make API call with query parameters, retrieve the parsed response json object.
            jobj = Common.APICallClass.ShuffleTheCardsAPI(queryParameters);
            //Save the deck_id for following steps - Shared steps.
            deck_id = jobj["deck_id"].ToString();
        }

        /// <summary>
        /// Verify the Shuffle cards response against the expected result
        /// </summary>
        /// <param name="success">the request success status</param>
        /// <param name="shuffled">the shuffled status</param>
        /// <param name="remaining">the remaining cards count</param>
        [Then(@"success should be (.*), shuffled should be (.*), remaining cards count should be (.*)")]
        public void ThenSuccessShouldBeShuffledShouldBeRemainingCardsCountShouldBe(string success, string shuffled, string remaining)
        {
            //verify the success status, shuffled status and the remaining cards count.
            Assert.That(jobj["success"].ToString(), Is.EqualTo(success), "The request failed.");
            Assert.That(jobj["shuffled"].ToString(), Is.EqualTo(shuffled), "Cards shuffle failed.");
            Assert.That(jobj["remaining"].ToString(), Is.EqualTo(remaining), "The remaining cards count doesn't match the expected count.");
        }
    }
}
