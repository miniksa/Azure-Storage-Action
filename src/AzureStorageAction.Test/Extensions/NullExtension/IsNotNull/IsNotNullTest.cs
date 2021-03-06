﻿using AzureStorageAction.Extensions;

using NUnit.Framework;

namespace AzureStorageAction.Test.Extensions.NullExtension.IsNotNull
{
    class IsNotNullTest
    {
        [Test]
        public void IsNotNull_With_NullValue_Return_True()
        {
            string value = null;

            Assert.IsFalse(value.IsNotNull());
        }

        [Test]
        public void IsNotNull_With_NullValue_Return_False()
        {
            string value = string.Empty;

            Assert.IsTrue(value.IsNotNull());
        }
    }
}
