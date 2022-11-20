using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace EcommerceDDD.Core.Reflection;

public class PrivateResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        var prop = base.CreateProperty(member, memberSerialization);
        if (!prop.Writable)
        {
            var property = member as PropertyInfo;
            var hasPrivateSetter = property?.GetSetMethod(true) is not null;
            prop.Writable = hasPrivateSetter;
        }
        return prop;
    }
}