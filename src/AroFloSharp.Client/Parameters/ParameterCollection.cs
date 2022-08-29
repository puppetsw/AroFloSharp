using System.Collections.Generic;
using System.Linq;

namespace AroFloSharp.Client.Parameters;

public class ParameterCollection : List<ParameterBase>
{
    public override string ToString() => string.Join("&", this.Select(parameter => parameter.ToString()).ToArray());
}
