﻿using System;
using System.IO;
using Bing.Utils.Helpers;
using Bing.Utils.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bing.Utils.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var path = @"H:\LXWL\SVN\KA项目";
            var result = Directory.GetFileSystemEntries(path,"*",SearchOption.AllDirectories);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Test_Float_Type()
        {
            var type = typeof(float);
            Console.WriteLine(type.ToString());
        }

        [TestMethod]
        public void Test_Json()
        {
            TestA a=new TestA(Guid.NewGuid());

            var result = a.ToJson();
            Console.WriteLine(result);

            var temp = result.ToObject<TestA>();
            var result1 = temp.ToJson();
            Console.WriteLine(result1);
        }

        public class TestA
        {
            public Guid Id { get; }

            public TestA() : this(Guid.Empty) { }

            public TestA(Guid id)
            {
                Id = id;
            }
        }

        [TestMethod]
        public void Test_Conv_Decimal()
        {
            var result = Conv.ToDecimal((decimal)189 /99, 2);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void Test_Conv_DateTime()
        {
            string time = "2018-02-01";

            var result = Convert.ToDateTime(time);
            Console.WriteLine(time);
        }
        
        
    }

}
