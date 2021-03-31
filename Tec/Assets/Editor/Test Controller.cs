using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TestController
{
  [Test]
    public void TestOne()
    {
        //arrange
        Circle circle = new Circle();
        circle.Radious = 10f;
        var areaExpected = 314.16f;
        //act
        circle.GetArea();
        //assert
        Assert.That(circle.Area, Is.EqualTo(areaExpected));

    }

}
