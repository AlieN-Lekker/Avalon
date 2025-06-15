using System;

namespace Avalon.Domain
{
    public class User
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
