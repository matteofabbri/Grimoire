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
	public class Asset_Book_Rule_DataType : INotifyPropertyChanged
	{
		private Asset_BookObjectType asset_Book_ReferenceField;

		private Asset_Book_Rule_Replacement_DataType[] asset_Book_Rule_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Asset_BookObjectType Asset_Book_Reference
		{
			get
			{
				return this.asset_Book_ReferenceField;
			}
			set
			{
				this.asset_Book_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Reference");
			}
		}

		[XmlElement("Asset_Book_Rule_Replacement_Data", Order = 1)]
		public Asset_Book_Rule_Replacement_DataType[] Asset_Book_Rule_Replacement_Data
		{
			get
			{
				return this.asset_Book_Rule_Replacement_DataField;
			}
			set
			{
				this.asset_Book_Rule_Replacement_DataField = value;
				this.RaisePropertyChanged("Asset_Book_Rule_Replacement_Data");
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
