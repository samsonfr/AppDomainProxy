using System;

using Interfaces;

namespace PluginA
{
  public class ClassA : MarshalByRefObject, ISampleInterface
  {
    public string GetValue(string sParam)
    {
      return String.Format("{0} from ClassA", sParam);
    }
  }
}
