using System;
using System.Reflection;

namespace ContactMngmntsiplfiedMultitierMVCWebApiCors.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}