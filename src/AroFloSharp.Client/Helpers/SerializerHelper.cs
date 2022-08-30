using System;
using AroFloSharp.Client.Serializer;

namespace AroFloSharp.Client.Helpers;

public static class SerializerHelper
{
    public static ISerializer GetSerializer(string acceptType)
    {
        switch (acceptType)
        {
            case Constants.ACCEPT_XML:
                return new XmlResponseSerializer();
            case Constants.ACCEPT_JSON:
                return new JsonResponseSerializer();
            default:
                throw new ArgumentException();
        }
    }
}