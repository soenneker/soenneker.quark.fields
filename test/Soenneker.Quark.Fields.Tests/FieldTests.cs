using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Quark.Fields.Tests;

[Collection("Collection")]
public sealed class FieldTests : FixturedUnitTest
{
    public FieldTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
    }
}