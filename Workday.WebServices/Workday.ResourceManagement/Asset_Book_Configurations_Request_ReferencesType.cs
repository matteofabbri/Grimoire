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
	public class Asset_Book_Configurations_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] asset_Book_Configuration_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Asset_Book_Configuration_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Asset_Book_Configuration_Reference
		{
			get
			{
				return this.asset_Book_Configuration_ReferenceField;
			}
			set
			{
				this.asset_Book_Configuration_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Configuration_Reference");
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
