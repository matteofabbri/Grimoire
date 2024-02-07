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
	public class Resume_Asset_Depreciation_for_WWS_DataType : INotifyPropertyChanged
	{
		private Business_AssetObjectType asset_ReferenceField;

		private DateTime transaction_Effective_DateField;

		private Asset_BookObjectType[] restricted_to_Books_ReferenceField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlElement("Restricted_to_Books_Reference", Order = 2)]
		public Asset_BookObjectType[] Restricted_to_Books_Reference
		{
			get
			{
				return this.restricted_to_Books_ReferenceField;
			}
			set
			{
				this.restricted_to_Books_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_to_Books_Reference");
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
