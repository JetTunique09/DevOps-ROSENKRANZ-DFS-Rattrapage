// test de la classe Baptizm 

namespace EvaluationSampleCode.Tests;

public class BaptizmTests
{
    [Fact]
    // Scenario pour CanBeBaptized 
    // Test scenario si un priest (pretre) peut baptizer 
    public void CanBeBaptizedBy_Priest_ReturnsTrue()
    {
        var priest = new ClergyMember { IsPriest = true };
        var baptizm = new Baptizm(new ClergyMember());
        var result = baptizm.CanBeBaptizedBy(priest);

        Assert.True(result);
    }

    [Fact]
    // Test scénario si un pope peut baptizer
    public void CanBeBaptizedBy_Pope_ReturnsTrue()
    {
        var pope = new ClergyMember { IsPope = true };
        var baptizm = new Baptizm(new ClergyMember());
        var result = baptizm.CanBeBaptizedBy(pope);

        Assert.True(result);
    }

    [Fact]
    // Test scénario si un autre membre peut baptizer
    public void CanBeBaptizedBy_NotPriestOrPope_ReturnsFalse()
    {
        // Arrange
        var member = new ClergyMember();
        var baptizm = new Baptizm(new ClergyMember());
        var result = baptizm.CanBeBaptizedBy(member);

        Assert.False(result);
    }

    // Scenario pour CanBeTeachedBy
    [Fact]
    public void CanBeTeachedBy_SameClergyMember_ReturnsTrue()
    {
        var clergyMember = new ClergyMember();
        var baptizm = new Baptizm(clergyMember);
        var result = baptizm.CanBeTeachedBy(clergyMember);

        Assert.True(result);
    }
    [Fact]
public void CanBeTeachedBy_DifferentClergyMember_ReturnsFalse()
{
    var originalClergyMember = new ClergyMember();
    var anotherClergyMember = new ClergyMember();
    var baptizm = new Baptizm(originalClergyMember);
    var result = baptizm.CanBeTeachedBy(anotherClergyMember);

    Assert.False(result);
}




}