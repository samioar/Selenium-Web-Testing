using CalculatorLib;
using NUnit.Framework.Constraints;
using System;
using TechTalk.SpecFlow;

namespace Calculator_BDD
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private Calculator _calculator;
        private int _result;
        private List<int> _numberList;
        private string _exceptionMessage = "";
        public object Num2 { get; private set; }
        public object Num1 { get; private set; }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int num1, int num2)
        {
            _calculator.Num1 = num1;
            _calculator.Num2 = num2;
        }
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }
        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calculator.Multiply();
        }
        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            try
            {
                _result = _calculator.Divide();
            }
            catch (DivideByZeroException exceptionMessage)
            {
                throw new DivideByZeroException(_exceptionMessage);
            }
        }
        [Then(@"a DivideByZero Exception should a DivideByZeroException when I press divide")]
        public void ThenADivideByZeroExceptionShouldADivideByZeroExceptionWhenIPressDivide()
        {
            Assert.Throws<DivideByZeroException>(() => WhenIPressDivide());
        }

        [Given(@"I enter the numbers below to a list")]
        public void GivenIEnterTheNumbersBelowToAList(Table table)
        {
            {
                _numberList = new List<int>();

                foreach (TableRow row in table.Rows)
                {
                    var num = int.Parse(row["nums"]);
                    _numberList.Add(num);
                }
            }
        }

        [When(@"I iterate through the list to add all the even numbers")]
        public void WhenIIterateThroughTheListToAddAllTheEvenNumbers()
        {
            _result = _numberList.Where(num => num % 2 == 0).Sum();
            //_result = 0;
            //foreach (var num in _numberList)
            //{
            //    if (num % 2 == 0)
            //    {
            //        _result += num;
            //    }
            //}
        }

        [Then(@"the exception should have the message ""([^""]*)""")]
        public void ThenTheExceptionShouldHaveTheMessage(string exceptionMessage)
        {
            var exception = Assert.Throws<DivideByZeroException>(() => WhenIPressDivide());
            Assert.That(exception.Message, Contains.Substring(exceptionMessage));
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

    } }
