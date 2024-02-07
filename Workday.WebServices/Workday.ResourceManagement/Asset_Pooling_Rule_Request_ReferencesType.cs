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
	public class Asset_Pooling_Rule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Asset_Pooling_RuleObjectType[] asset_Pooling_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Asset_Pooling_Rule_Reference", Order = 0)]
		public Asset_Pooling_RuleObjectType[] Asset_Pooling_Rule_Reference
		{
			get
			{
				return this.asset_Pooling_Rule_ReferenceField;
			}
			set
			{
				this.asset_Pooling_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Pooling_Rule_Reference");
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
