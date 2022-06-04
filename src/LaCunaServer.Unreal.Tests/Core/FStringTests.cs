using NUnit.Framework;
using LaCunaServer.Unreal.Core;
using LaCunaServer.Unreal.Serialization;

namespace LaCunaServer.Unreal.Tests.Core;

public class FStringTests
{
    [Test]
    [TestCase("")]
    [TestCase("TestString")]
    [TestCase("/Game/ThirdPersonCPP/Maps/ThirdPersonExampleMap")]
    [TestCase("/Script/ThirdPersonMP.ThirdPersonMPGameMode")]
    public void TestWriteRead(string testValue)
    {
        // Write a string.
        using var writer = new FNetBitWriter(4096);
        
        FString.Serialize(writer, testValue);
        
        // Create a reader.
        var reader = new FNetBitReader(null, writer.GetData(), (int)writer.GetNumBits());
        var read = FString.Deserialize(reader);
        
        Assert.AreEqual(testValue, read);
    }
}