// Koine.Infrastructure/Study/HardcodedUserProvider.cs
using Koine.Application.Study.Ports;

namespace Koine.Infrastructure.Study
{
    public class HardcodedUserProvider : ICurrentUserProvider
    {
        public int GetUserId() => 1;
    }
}
