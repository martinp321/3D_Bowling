﻿using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class ScoreMasterTest
{


    [Test]
    public void Test_editor()
    {
        //Arrange
        var gameObject = new GameObject();

        //Act
        //Try to rename the GameObject
        var newGameObjectName = "My game object";
        gameObject.name = newGameObjectName;

        //Assert
        //The object has a new name
        Assert.AreEqual(newGameObjectName, "test");
    }

}
