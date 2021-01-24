using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DeckOfCardsTesting.Common
{
    public static class BaseClass
    {
        /// <summary>
        /// Get the configuration values from appsettings.json
        /// </summary>
        /// <returns>the configuration values under test</returns>
        public static Dictionary<string, string> GetConfigValues()
        {
            //define the configValues dictionary
            Dictionary<string, string> configValues = new Dictionary<string, string>();

            //Get the config File Path
            string configFilePath = Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString();

            //locate the config file
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(configFilePath)
                .AddJsonFile("appsettings.json");

            //read the config file, return the test parameters
            IConfiguration config = configurationBuilder.Build();
            configValues.Add("TestURL", config["ApplicationSettings:TestURL"]);  //API URL
            configValues.Add("NewShufflePath", config["ApplicationSettings:NewShufflePath"]);  //The New Shuffle the Cards Path
            configValues.Add("DrawCardsPath", config["ApplicationSettings:DrawCardsPath"]);    //The Draw Cards path
            
            //Return the config values dictionary.
            return configValues;
        }         
    }
}
