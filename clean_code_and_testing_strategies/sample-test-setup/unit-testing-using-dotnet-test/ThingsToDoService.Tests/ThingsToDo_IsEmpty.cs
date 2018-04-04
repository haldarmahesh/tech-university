using ThingsToDo.Services;
using Xunit;

namespace ThingsToDo.UnitTests.Tests
{
    public class ThingsToDo_IsEmpty
    {
        private readonly ThingsToDoService _thingsTodoService;
        public ThingsToDo_IsEmpty()
        {
            _thingsTodoService = new ThingsToDoService();
        }
        [Fact]
        public void checkingForEmpty()
        {
            var result = _thingsTodoService.IsEmpty("Mahesh");
            Assert.False(result, "MAHESH is not empty");
        }
    }
}
