using System;

using Interfaces;

namespace PluginB
{
  public class ClassB : MarshalByRefObject, ISampleInterface
  {
    public string GetValue(string sParam)
    {
      return String.Format("{0} from ClassB recompiled", sParam);
    }
  }
}
