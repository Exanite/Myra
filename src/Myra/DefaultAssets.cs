using System;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI.Styles;
using Myra.Utility;
using System.Diagnostics;
using System.IO;

#if MONOGAME || FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#elif STRIDE
using Stride.Core.Mathematics;
using Texture2D = Stride.Graphics.Texture;
#else
using System.Drawing;
using Texture2D = System.Object;
#endif

namespace Myra
{
	public static class DefaultAssets
	{
		private static IAssetManager _assetManager;
		private static TextureRegionAtlas _uiTextureRegionAtlas;
		private static Stylesheet _uiStylesheet;
		private static TextureRegion _whiteRegion;
		private static Texture2D _whiteTexture;

		public static IAssetManager AssetManager
        {
            get
			{
                Debug.Assert(_assetManager != null, "DefaultAssets.AssetManager must be set.");

                return _assetManager;
			}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));

                }
                _assetManager = value;
            }
        }

        public static Texture2D WhiteTexture
		{
			get
			{
				if (_whiteTexture == null)
				{
#if MONOGAME || FNA || STRIDE
					var texture = CrossEngineStuff.CreateTexture(MyraEnvironment.GraphicsDevice, 1, 1);
					CrossEngineStuff.SetTextureData(texture, new Rectangle(0, 0, 1, 1), new byte[] { 255, 255, 255, 255 });
#else
					var textureManager = MyraEnvironment.Platform.Renderer.TextureManager;
					var texture = textureManager.CreateTexture(1, 1);
					textureManager.SetTextureData(texture, new Rectangle(0, 0, 1, 1), new byte[] { 255, 255, 255, 255 });
#endif

					_whiteTexture = texture;
				}

				return _whiteTexture;
			}
		}

		public static TextureRegion WhiteRegion
		{
			get
			{
				if (_whiteRegion == null)
				{
					_whiteRegion = UITextureRegionAtlas["white"];
				}

				return _whiteRegion;
			}
		}

		public static TextureRegionAtlas UITextureRegionAtlas
		{
			get
			{
				if (_uiTextureRegionAtlas != null)
				{
					return _uiTextureRegionAtlas;
				}

				_uiTextureRegionAtlas = AssetManager.GetAsset<TextureRegionAtlas>("Myra:default_ui_skin.xmat");
				return _uiTextureRegionAtlas;
			}
		}

		public static Stylesheet UIStylesheet
		{
			get
			{
				if (_uiStylesheet != null)
				{
					return _uiStylesheet;
				}

				_uiStylesheet = AssetManager.GetAsset<Stylesheet>("Myra:default_ui_skin.xmms");
				return _uiStylesheet;
			}
		}

		internal static void Dispose()
		{
			_uiTextureRegionAtlas = null;
			_uiStylesheet = null;

			if (_assetManager != null)
			{
				_assetManager.Dispose();
				_assetManager = null;
			}

			_whiteRegion = null;
			_whiteTexture = null;
		}
	}
}
