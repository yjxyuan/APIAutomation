using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace DeckOfCardsTesting.Steps
{
    [Binding]
    public class DrawCardsSteps
    {
        private JObject jobj = null;   //The parsed response Json object
        private Dictionary<string, string> queryParameters = new Dictionary<string, string>();  //Query parameters

        /// <summary>
        /// User pass the number of cards to be drawn, make the API Call.
        /// </summary>
        /// <param name="count">the number of cards to be drawn</param>
        [When(@"user draw (.*) number of cards")]
        public void WhenUserDrawNumberOfCards(int count)
        {
            //Append number of cards to be drawn - query parameters
            queryParameters.Clear();
            if (count>0)
            {
                queryParameters.Add("count", count.ToString());
            }
            //retrieve the parsed response json object.
            jobj = Common.APICallClass.DrawCardsAPI(ShuffleTheCardsStepDefinition.deck_id, queryParameters);
        }

        /// <summary>
        /// Verify the Draw Cards request
        /// </summary>
        /// <param name="success">The request success status</param>
        /// <param name="count">The drawn cards count</param>
        /// <param name="remaining">The remaining Cards in the Deck</param>
        [Then(@"success should be (.*), cards count draw should be (.*), remaining cards count should be (.*)")]
        public void ThenSuccessShouldBeTrueCardsCountDrawShouldBeRemainingCardsCountShouldBe(bool success, int count, int remaining)
        {
            //Verify the request success status, drawn count, remaining cards count should be the same as the expected result.
            Assert.That(jobj["success"].ToString(), Is.EqualTo(success.ToString()), "The draw a card request failed.");
            Assert.That(((Newtonsoft.Json.Linq.JContainer)jobj["cards"]).Count.ToString(), Is.EqualTo(count.ToString()), "The cards drawn count doesn't match the expected count.");
            Assert.That(jobj["remaining"].ToString(), Is.EqualTo(remaining.ToString()), "The remaining cards count doesn't match the expected remaining count.");
        }
    }
}
