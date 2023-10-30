using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Myra.Graphics2D.UI.Properties
{
	public class PropertyGridSettings
	{
		[Browsable(false)]
		[XmlIgnore]
		public IAssetManager AssetManager;

		public string BasePath;

		public Func<string, string> ImagePropertyValueGetter;
		public Action<string, string> ImagePropertyValueSetter;
	}
}
