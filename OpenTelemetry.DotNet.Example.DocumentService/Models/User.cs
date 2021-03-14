using System;

namespace OpenTelemetry.DotNet.Example.DocumentService.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
    }
}