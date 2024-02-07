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
	public class Remove_Asset_DataType : INotifyPropertyChanged
	{
		private Business_AssetObjectType asset_ReferenceField;

		private DateTime transaction_Effective_DateField;

		private Asset_Removal_ReasonObjectType asset_Removal_Reason_ReferenceField;

		private string asset_Removal_CommentsField;

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

		[XmlElement(Order = 2)]
		public Asset_Removal_ReasonObjectType Asset_Removal_Reason_Reference
		{
			get
			{
				return this.asset_Removal_Reason_ReferenceField;
			}
			set
			{
				this.asset_Removal_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Removal_Reason_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Asset_Removal_Comments
		{
			get
			{
				return this.asset_Removal_CommentsField;
			}
			set
			{
				this.asset_Removal_CommentsField = value;
				this.RaisePropertyChanged("Asset_Removal_Comments");
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
