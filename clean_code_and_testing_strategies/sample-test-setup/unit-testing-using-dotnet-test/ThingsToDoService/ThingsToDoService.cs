using System;

namespace ThingsToDo.Services
{
    public class ThingsToDoService
    {
        public bool IsEmpty(String candidate) {
            var length = candidate.Length;
            if (length > 0)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test");
        }
    }
}
