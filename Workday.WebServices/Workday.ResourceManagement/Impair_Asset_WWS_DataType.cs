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
	public class Impair_Asset_WWS_DataType : INotifyPropertyChanged
	{
		private Business_AssetObjectType asset_ReferenceField;

		private DateTime transaction_Effective_DateField;

		private decimal new_Market_ValueField;

		private bool new_Market_ValueFieldSpecified;

		private Asset_Impairment_ReasonObjectType impairment_Reason_ReferenceField;

		private Asset_BookObjectType[] restricted_to_Books_ReferenceField;

		private string commentField;

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
		public decimal New_Market_Value
		{
			get
			{
				return this.new_Market_ValueField;
			}
			set
			{
				this.new_Market_ValueField = value;
				this.RaisePropertyChanged("New_Market_Value");
			}
		}

		[XmlIgnore]
		public bool New_Market_ValueSpecified
		{
			get
			{
				return this.new_Market_ValueFieldSpecified;
			}
			set
			{
				this.new_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("New_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Asset_Impairment_ReasonObjectType Impairment_Reason_Reference
		{
			get
			{
				return this.impairment_Reason_ReferenceField;
			}
			set
			{
				this.impairment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Impairment_Reason_Reference");
			}
		}

		[XmlElement("Restricted_to_Books_Reference", Order = 4)]
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

		[XmlElement(Order = 5)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
