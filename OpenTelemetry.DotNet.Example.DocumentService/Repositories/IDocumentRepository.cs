using OpenTelemetry.DotNet.Example.DocumentService.Models;
using System;
using System.Collections.Generic;

namespace OpenTelemetry.DotNet.Example.DocumentService.Repositories
{
    public interface IDocumentRepository
    {
        Document GetDocumentById(Guid id);
        IEnumerable<Document> GetDocumentsForUserId(Guid userId);
    }
}