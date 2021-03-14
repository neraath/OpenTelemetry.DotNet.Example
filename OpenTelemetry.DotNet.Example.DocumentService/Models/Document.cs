using System;

namespace OpenTelemetry.DotNet.Example.DocumentService.Models
{
    public class Document
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public User LastEditedBy { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}