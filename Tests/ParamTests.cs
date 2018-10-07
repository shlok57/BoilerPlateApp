using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shlok.Business;
using Shlok.Models;

namespace Shlok.Tests
{
	[TestClass]
	public class ParamTests
	{
		[TestMethod]
		[TestCategory(TestCategory.UnitTest)]
		[Timeout(TestTimeout.Acceptable)]
		public void FunctionTest()
		{
			int value = 5;
			ParamBL paramBL = new ParamBL();
			Assert.AreEqual(value * value, paramBL.Function(value));
		}

		[DataTestMethod]
		[DataRow(5, 25)]
		[DataRow(3, 9)]
		[TestCategory(TestCategory.IntegretionTest)]
		[Timeout(TestTimeout.Integretion)]
		public void FunctionDataTest(int value, int result)
		{
			ParamBL paramBL = new ParamBL();
			Assert.AreEqual(result, paramBL.Function(value));
		}

		[TestMethod]
		[TestCategory(TestCategory.IntegretionTest)]
		[Timeout(TestTimeout.Integretion)]
		public void GetParamValuebyIdTest()
		{
			List<ParamValue> values = new List<ParamValue>();
			ParamBL paramBL = new ParamBL();
			values = paramBL.GetParamValuesHistoryById(1);
			Assert.AreEqual(2, values.Count);
			ParamValue value = values.Find(x => x.IsActive == true);
			Assert.AreEqual(10, value.Value);
		}


		[TestMethod]
		[TestCategory(TestCategory.IntegretionTest)]
		[Timeout(TestTimeout.Integretion)]
		public void GetAllParamNames()
		{
			ParamBL paramBL = new ParamBL();
			string paramName = "testParamName";
			int paramId = paramBL.StoreParamName(paramName);
			List<ParamValue> values = new List<ParamValue>();
			values = paramBL.GetAllParamNames();
			ParamValue value = values.Find(x => x.Id == paramId);
			Assert.AreEqual(paramName, value.Name);
		}
	}
}
