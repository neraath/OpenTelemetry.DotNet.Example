using OpenTelemetry.DotNet.Example.DocumentService.Models;
using OpenTelemetry.DotNet.Example.DocumentService.Repositories;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace OpenTelemetry.DotNet.Example.DocumentService.Controllers
{
    public class DocumentsController : ApiController
    {
        private IDocumentRepository documentRepository;

        public DocumentsController()
        {
            documentRepository = new DocumentRepository();
        }

        // GET: Documents
        public IHttpActionResult Get()
        {
            // Assume current user is chris.weldon
            Guid currentUserId = DocumentRepository.ChrisWeldonUserGuid;
            var documents = documentRepository.GetDocumentsForUserId(currentUserId);
            return Ok<IEnumerable<Document>>(documents);
        }
    }
}