﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Calculator_BDD
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calculator")]
    public partial class CalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Calculator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Calculator", "As a Spartan, I want a calculator that takes two numbers, so I can do maths on \'e" +
                    "m", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 5
testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Addition")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public void Addition()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Addition", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 11
testRunner.Given("I enter 5 and 2 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
testRunner.Then("the result should be 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subtract")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.TestCaseAttribute("1", "1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "1", "-1", null)]
        [NUnit.Framework.TestCaseAttribute("1000", "1", "999", null)]
        public void Subtract(string input1, string input2, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "HappyPath"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("input1", input1);
            argumentsOfScenario.Add("input2", input2);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtract", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 19
    testRunner.Given(string.Format("I enter {0} and {1} into the calculator", input1, input2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
    testRunner.When("I press subtract", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
    testRunner.Then(string.Format("the result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiply")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.TestCaseAttribute("1", "1", "1", null)]
        [NUnit.Framework.TestCaseAttribute("2", "3", "6", null)]
        [NUnit.Framework.TestCaseAttribute("9", "9", "81", null)]
        [NUnit.Framework.TestCaseAttribute("5", "-17", "-85", null)]
        public void Multiply(string input1, string input2, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "HappyPath"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("input1", input1);
            argumentsOfScenario.Add("input2", input2);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiply", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 31
    testRunner.Given(string.Format("I enter {0} and {1} into the calculator", input1, input2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
    testRunner.When("I press multiply", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
    testRunner.Then(string.Format("the result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Divide")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public void Divide()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Divide", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 43
    testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
     testRunner.And("I enter 6 and 2 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
    testRunner.When("I press divide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
    testRunner.Then("the result should be 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Divide By Zero")]
        [NUnit.Framework.CategoryAttribute("SadPath")]
        [NUnit.Framework.TestCaseAttribute("1", null)]
        [NUnit.Framework.TestCaseAttribute("6", null)]
        public void DivideByZero(string input1, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SadPath"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("input1", input1);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Divide By Zero", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 52
   testRunner.And(string.Format("I enter {0} and 0 into the calculator", input1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
   testRunner.When("I press divide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
   testRunner.Then("a DivideByZero Exception should a DivideByZeroException when I press divide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
   testRunner.And("the exception should have the message \"Cannot Divide By Zero\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SumOfNumbersDivisibleBy2")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public void SumOfNumbersDivisibleBy2()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SumOfNumbersDivisibleBy2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "nums"});
                table1.AddRow(new string[] {
                            "1"});
                table1.AddRow(new string[] {
                            "2"});
                table1.AddRow(new string[] {
                            "3"});
                table1.AddRow(new string[] {
                            "4"});
                table1.AddRow(new string[] {
                            "5"});
#line 64
 testRunner.And("I enter the numbers below to a list", ((string)(null)), table1, "And ");
#line hidden
#line 71
 testRunner.When("I iterate through the list to add all the even numbers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.Then("the result should be 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
