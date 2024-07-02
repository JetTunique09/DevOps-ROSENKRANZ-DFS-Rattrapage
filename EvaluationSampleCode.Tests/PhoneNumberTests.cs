// test de la classe PhoneNumber 

namespace EvaluationSampleCode.Tests
{
    public class PhoneNumberTests
    {
        // tests scenario numero vide et null
        [Fact]
        public void Parse_EmptyString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(""));
        }
        [Fact]
        public void Parse_NullString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(null));
        }

        // tests scenario numero avec moins de 10 caracteres
        [Fact]
        public void Parse_StringNotTenDigits_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse("123456789"));
        }

        // tests scenario numero correcte 
        [Fact]
        public void Parse_CorrectPhoneNumber_ReturnsPhoneNumberInstance()
        {
            var numberString = "0123456789";
            var phoneNumber = PhoneNumber.Parse(numberString);

            Assert.NotNull(phoneNumber);
            Assert.Equal("012", phoneNumber.Area);
            Assert.Equal("345", phoneNumber.Major);
            Assert.Equal("6789", phoneNumber.Minor);
        }

        // tests ToString bon format du numero en string
        [Fact]
        public void ToString_ReturnsExpectedFormat()
        {
            var phoneNumber = PhoneNumber.Parse("0123456789");
            var result = phoneNumber.ToString();

            Assert.Equal("(012)345-6789", result);
        }
    }
}
