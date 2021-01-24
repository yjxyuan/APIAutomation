﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DeckOfCardsTesting.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Req002 - DrawCards", Description="\tshuffle a deck of cards, draw one or more cards from a deck", SourceFile="Features\\DrawCards.feature", SourceLine=0)]
    public partial class Req002_DrawCardsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "DrawCards.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Req002 - DrawCards", "\tshuffle a deck of cards, draw one or more cards from a deck", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void TC_ST_L1_DrawCards_P0001_ShuffleADeckOfCardsDrawOneOrMoreCardsFromADeck(string deck_Count, string jokers_Enabled, string count, string success, string remaining, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Sanity",
                    "regression",
                    "priority2"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("deck_count", deck_Count);
            argumentsOfScenario.Add("jokers_enabled", jokers_Enabled);
            argumentsOfScenario.Add("count", count);
            argumentsOfScenario.Add("success", success);
            argumentsOfScenario.Add("remaining", remaining);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC_ST_L1_DrawCards_P0001 - shuffle a deck of cards, draw one or more cards from a" +
                    " deck", null, tagsOfScenario, argumentsOfScenario);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
testRunner.Given(string.Format("user shuffle {0} deck of cards with {1}", deck_Count, jokers_Enabled), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
testRunner.When(string.Format("user draw {0} number of cards", count), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
testRunner.Then(string.Format("success should be {0}, cards count draw should be {1}, remaining cards count shou" +
                            "ld be {2}", success, count, remaining), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TC_ST_L1_DrawCards_P0001 - shuffle a deck of cards, draw one or more cards from a" +
            " deck, Variant 0", new string[] {
                "Sanity",
                "regression",
                "priority2"}, SourceLine=10)]
        public virtual void TC_ST_L1_DrawCards_P0001_ShuffleADeckOfCardsDrawOneOrMoreCardsFromADeck_Variant0()
        {
#line 5
this.TC_ST_L1_DrawCards_P0001_ShuffleADeckOfCardsDrawOneOrMoreCardsFromADeck("1", "True", "2", "True", "52", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TC_ST_L1_DrawCards_P0001 - shuffle a deck of cards, draw one or more cards from a" +
            " deck, Variant 1", new string[] {
                "Sanity",
                "regression",
                "priority2"}, SourceLine=10)]
        public virtual void TC_ST_L1_DrawCards_P0001_ShuffleADeckOfCardsDrawOneOrMoreCardsFromADeck_Variant1()
        {
#line 5
this.TC_ST_L1_DrawCards_P0001_ShuffleADeckOfCardsDrawOneOrMoreCardsFromADeck("1", "False", "4", "True", "48", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
