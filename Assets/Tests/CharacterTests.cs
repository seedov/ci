using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CharacterTests
{

    [Test]
    public void TestCharacterMove()
    {
        var character = new GameObject("character").AddComponent<Character>();
        Assert.AreEqual(Vector3.zero, character.transform.position);
        character.Move(new Vector3(1, 0, 0));
        Assert.AreNotEqual(Vector3.zero, character.transform.position);
    }
}
