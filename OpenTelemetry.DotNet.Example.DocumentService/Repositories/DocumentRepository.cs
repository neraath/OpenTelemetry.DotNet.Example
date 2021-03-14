using OpenTelemetry.DotNet.Example.DocumentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenTelemetry.DotNet.Example.DocumentService.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        public Document GetDocumentById(Guid id)
        {
            return Documents.SingleOrDefault(doc => doc.Id.Equals(id));
        }

        public IEnumerable<Document> GetDocumentsForUserId(Guid userId)
        {
            return Documents
                .Where(doc => doc.CreatedBy.Id.Equals(userId) || doc.LastEditedBy.Id.Equals(userId))
                .ToList();
        }

        private List<Document> Documents
        {
            get
            {
                return new List<Document>()
                {
                    new Document()
                    {
                        Id = new Guid("{23788993-3359-4842-81D3-0D04718D8E6E}"),
                        CreatedDate = new DateTime(2021, 03, 14, 17, 39, 00),
                        ChangedDate = new DateTime(2021, 03, 14, 17, 39, 00),
                        FileName = "TestDocument.xlsx",
                        CreatedBy = Users.First(),
                        LastEditedBy = Users.First()
                    },
                    new Document()
                    {
                        Id = new Guid("{83565F47-7CA6-4A58-85D0-744546A92C5D}"),
                        CreatedBy = Users.Last(),
                        LastEditedBy = Users.First(),
                        FileName = "ChangedDocument.docx",
                        CreatedDate = new DateTime(2021, 01, 01, 08, 39, 00),
                        ChangedDate = new DateTime(2021, 02, 22, 10, 26, 00)
                    }
                };
            }
        }

        private List<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new User()
                    {
                        Id = ChrisWeldonUserGuid,
                        DisplayName = "Chris Weldon",
                        Email = "chris@chrisweldon.net",
                        Login = "neraath"
                    },
                    new User()
                    {
                        Id = new Guid("{DF8D731C-114D-41F3-BF30-F01F48491562}"),
                        DisplayName = "Jane Doe",
                        Email = "janedoe@example.com",
                        Login = "janedoe"
                    }
                };
            }
        }

        public static Guid ChrisWeldonUserGuid = new Guid("{6E919A71-BEAC-4DE3-BA3E-F033758FF871}");
    }
}