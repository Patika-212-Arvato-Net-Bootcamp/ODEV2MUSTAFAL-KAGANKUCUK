using System;
using System.Reflection;

namespace ODEV2MUSTAFAL─░KAGANKUCUK.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}