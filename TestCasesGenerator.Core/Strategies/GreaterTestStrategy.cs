﻿using System;
using System.Collections.Generic;
using TestCasesGenerator.Core.Structures;

namespace TestCasesGenerator.Core.Strategies
{
    public class GreaterTestStrategy : OperatorStrategy
    {
        public override TestCase[] GenerateTests(Variable variable, object constant)
        {
            List<TestCase> testCases = new List<TestCase>();
           
            double rValue = Convert.ToDouble((string)constant);

            TestCase t1 = new TestCase();
            t1.Inputs.Add(variable.Name, rValue - 1);
            testCases.Add(t1);

            TestCase t2 = new TestCase();
            t2.Inputs.Add(variable.Name, rValue + 1);
            testCases.Add(t2);

            TestCase t3 = new TestCase();
            t3.Inputs.Add(variable.Name, rValue);
            testCases.Add(t3);

            return testCases.ToArray();
        }

        public override TestCase[] GenerateTests(object constant, Variable variable)
        {
            return this.GenerateTests(variable, constant);
        }

        public override TestCase[] GenerateTests(Variable left, Variable right)
        {
            int rightValue = new Random().Next(0, 1000);
            List<TestCase> testCases = new List<TestCase>();

            TestCase t1 = new TestCase();
            t1.Inputs.Add(left.Name, rightValue - 1);
            t1.Inputs.Add(right.Name, rightValue);
            testCases.Add(t1);

            TestCase t2 = new TestCase();
            t2.Inputs.Add(left.Name, rightValue + 1);
            t2.Inputs.Add(right.Name, rightValue);
            testCases.Add(t2);

            TestCase t3 = new TestCase();
            t3.Inputs.Add(left.Name, rightValue);
            t3.Inputs.Add(right.Name, rightValue);
            testCases.Add(t3);

            return testCases.ToArray();
        }
    }
}
