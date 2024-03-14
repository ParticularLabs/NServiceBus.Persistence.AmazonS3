namespace NServiceBus.PersistenceTesting;
using System.Threading.Tasks;
using NUnit.Framework;

[SetUpFixture]
public class SetupFixture
{
    [OneTimeSetUp]
    public async Task OneTimeSetUp()
    {
    }

    [OneTimeTearDown]
    public async Task OneTimeTearDown()
    {
    }
}