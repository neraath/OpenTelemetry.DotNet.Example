using System;
using System.Reflection;

namespace OpenTelemetry.DotNet.Example.DocumentService.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}