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
	public class Asset_SharesType : INotifyPropertyChanged
	{
		private Business_AssetObjectType business_Asset_ReferenceField;

		private Asset_Share_Response_DataType[] asset_Share_Response_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_AssetObjectType Business_Asset_Reference
		{
			get
			{
				return this.business_Asset_ReferenceField;
			}
			set
			{
				this.business_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Business_Asset_Reference");
			}
		}

		[XmlElement("Asset_Share_Response_Data", Order = 1)]
		public Asset_Share_Response_DataType[] Asset_Share_Response_Data
		{
			get
			{
				return this.asset_Share_Response_DataField;
			}
			set
			{
				this.asset_Share_Response_DataField = value;
				this.RaisePropertyChanged("Asset_Share_Response_Data");
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
