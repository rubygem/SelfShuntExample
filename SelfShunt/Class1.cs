﻿using NUnit.Framework;

namespace SelfShunt
{
    [TestFixture]
    public class TestDeskTopUri
    {
        [Test]
        public void BaseUriIsTestEnvironment()
        {
            Assert.That(BaseUri(), Is.EqualTo("http//test.laterooms.com"));
        }

        private string BaseUri()
        {
            return "http//test.laterooms.com";
        }
    }
}