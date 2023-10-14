namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    private readonly PrimeService _primeService;
    public PrimeService_IsPrimeShould()
    {
        _primeService = new PrimeService();
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(53)]
    public void IsPrime_InputIsLessThen11_ReturnFalse(byte value)
    {

        bool result = _primeService.IsPrime(value);

        Assert.True(result, $"{value} should not be prime");
    }
}