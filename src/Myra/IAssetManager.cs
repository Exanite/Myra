using System;

namespace Myra
{
    public interface IAssetManager : IDisposable
    {
        public T GetAsset<T>(string assetKey);
    }
}
