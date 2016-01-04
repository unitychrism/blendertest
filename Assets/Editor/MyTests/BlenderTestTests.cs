using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
	[TestFixture]
	[Category("Sample Tests")]
	internal class BlenderTestTests
	{
		[Test]
		[Category("Failing Tests")]
		public void ExceptionTest()
		{
			throw new Exception("Exception throwing test");
		}

		[Test]
		[Category("Successful Tests")]
		public void SuccessTest()
		{
			Assert.IsTrue(true);
		}

	}

}