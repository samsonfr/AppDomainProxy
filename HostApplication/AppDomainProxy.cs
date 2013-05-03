using System;

using Interfaces;

namespace HostApplication
{
  public class AppDomainProxy : MarshalByRefObject, IDisposable
  {
     public AppDomainProxy() { }

    ~AppDomainProxy()
    {
      Dispose(false);
    }

    protected virtual void Dispose(bool bDisposing)
    {
      if (bDisposing)
      {
        // Free other state (managed objects).

        if (mpAppDomain != null)
        {
          AppDomain.Unload(mpAppDomain);
          mpAppDomain = null;
        }
      }
      // Free your own state (unmanaged objects).
      // Set large fields to null.
    }

    void IDisposable.Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    public AppDomain AppDomain
    {
      get
      {
        if (mpAppDomain == null)
        {
          mpAppDomain = AppDomain.CreateDomain(Guid.NewGuid().ToString("B"));
        }

        return mpAppDomain;
      }
    }

    public ISampleInterface CreateInstance(string sAssemblyName, string sTypeName)
    {
      ISampleInterface pInstance = null;

      try
      {
        return (ISampleInterface) this.AppDomain.CreateInstanceAndUnwrap(sAssemblyName, sTypeName);
      }
      catch (Exception pException)
      {
        Console.WriteLine(pException.Message);
      }

      return pInstance;
    }

    private AppDomain mpAppDomain = null;
  }
}
