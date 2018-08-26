using System;
using Shlok.DBProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shlok.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[TestCategory("Unit")]
		public void FunctionTest()
		{
			int value = 5;
			Assert.AreEqual(value * value, DBProvider.Function(value));
		}
	}
}
