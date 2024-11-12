using VerifyPlayground.Core;

namespace VerifyPlayground.Tests
{
    public class PersonTests
    {
        private Person _sut;
        private string _firstName ="Toto";
        private string _lastName = "Tata";
        private Guid _id;
        private int birthYear = 1977;
        private VerifySettings _verifySettings;
        public PersonTests()
        {
            _id = Guid.Parse("0a238b62-67b0-4bba-8e76-db88ca21f097");
            _sut = new(_id,_firstName,_lastName, birthYear);
            _verifySettings = new();
            _verifySettings.UseDirectory("snapshots");
        }
        [Fact]
        public async Task GetAgeShouldReturnCorrectAge()
        {
            var correctAge = _sut.GetAge();
            await Verify(correctAge, _verifySettings);
        }

        [Fact]
        public async Task UpdateFirstNameShouldUpdatePerson()
        {
            _sut.UpdateFirstname("Titi");
            await Verify(_sut, _verifySettings);
        }
    }
}