using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class AssetType : INotifyPropertyChanged
	{
		private Business_AssetObjectType asset_ReferenceField;

		private Asset_DataType asset_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_AssetObjectType Asset_Reference
		{
			get
			{
				return this.asset_ReferenceField;
			}
			set
			{
				this.asset_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Asset_DataType Asset_Data
		{
			get
			{
				return this.asset_DataField;
			}
			set
			{
				this.asset_DataField = value;
				this.RaisePropertyChanged("Asset_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
