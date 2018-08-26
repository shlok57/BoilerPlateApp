using System;
using Shlok.DBProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shlok.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[TestCategory(TestCategory.UnitTest)]
		[Timeout(TestTimeout.Acceptable)]
		public void FunctionTest()
		{
			int value = 5;
			Assert.AreEqual(value * value, DBProvider.Function(value));
		}

		[DataTestMethod]
		[DataRow(5,25)]
		[DataRow(3,9)]
		[TestCategory(TestCategory.UnitTest)]
		[Timeout(TestTimeout.Acceptable)]
		public void FunctionDataTest(int value, int result)
		{
			Assert.AreEqual(result, DBProvider.Function(value));
		}
	}
}
