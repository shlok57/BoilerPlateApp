using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shlok.DBProviders;
using Shlok.Models;

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
		[DataRow(5, 25)]
		[DataRow(3, 9)]
		[TestCategory(TestCategory.UnitTest)]
		[Timeout(TestTimeout.Acceptable)]
		public void FunctionDataTest(int value, int result)
		{
			Assert.AreEqual(result, DBProvider.Function(value));
		}

		[TestMethod]
		[TestCategory(TestCategory.UnitTest)]
		[Timeout(TestTimeout.Appropriate)]
		public void GetParamValuebyIdTest()
		{
			List<ParamValue> values = new List<ParamValue>();
			values = DBProvider.GetParamValuesById(1, true);
			Assert.AreEqual(2, values.Count);
			ParamValue value = values.Find(x => x.IsActive == true);
			Assert.AreEqual(10, value.Value);
		}


		[TestMethod]
		[TestCategory(TestCategory.UnitTest)]
		//[Timeout(TestTimeout.Appropriate)]
		public void GetAllParamNames()
		{
			string paramName = "testParamName";
			int paramId = DBProvider.StoreParamName(paramName);

			List<ParamValue> values = new List<ParamValue>();
			values = DBProvider.GetAllParamNames();
			ParamValue value = values.Find(x => x.Id == paramId);
			Assert.AreEqual(paramName, value.Name);
		}
	}
}
