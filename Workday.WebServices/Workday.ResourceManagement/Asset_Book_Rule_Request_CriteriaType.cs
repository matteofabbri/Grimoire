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
	public class Asset_Book_Rule_Request_CriteriaType : INotifyPropertyChanged
	{
		private Asset_BookObjectType[] asset_Books_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Asset_Books_Reference", Order = 0)]
		public Asset_BookObjectType[] Asset_Books_Reference
		{
			get
			{
				return this.asset_Books_ReferenceField;
			}
			set
			{
				this.asset_Books_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Books_Reference");
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
