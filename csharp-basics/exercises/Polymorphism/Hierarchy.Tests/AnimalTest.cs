using System;
using NUnit.Framework;
using System.Collections.Generic;
using Hierarchy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FluentAssertions;

namespace Hierarchy.Tests
{
    public class AnimalTests
    {
        Hierarchy.Animal a1 = new Hierarchy.Animal();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}