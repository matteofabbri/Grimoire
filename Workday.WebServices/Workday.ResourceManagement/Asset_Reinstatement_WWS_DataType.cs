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
	public class Asset_Reinstatement_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private Asset_Disposal_TypeObjectType disposal_Type_ReferenceField;

		private decimal disposal_Fair_Market_ValueField;

		private bool disposal_Fair_Market_ValueFieldSpecified;

		private decimal sale_PriceField;

		private bool sale_PriceFieldSpecified;

		private string commentField;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlIgnore]
		public bool Transaction_Effective_DateSpecified
		{
			get
			{
				return this.transaction_Effective_DateFieldSpecified;
			}
			set
			{
				this.transaction_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Asset_Disposal_TypeObjectType Disposal_Type_Reference
		{
			get
			{
				return this.disposal_Type_ReferenceField;
			}
			set
			{
				this.disposal_Type_ReferenceField = value;
				this.RaisePropertyChanged("Disposal_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Disposal_Fair_Market_Value
		{
			get
			{
				return this.disposal_Fair_Market_ValueField;
			}
			set
			{
				this.disposal_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Disposal_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Disposal_Fair_Market_ValueSpecified
		{
			get
			{
				return this.disposal_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.disposal_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Sale_Price
		{
			get
			{
				return this.sale_PriceField;
			}
			set
			{
				this.sale_PriceField = value;
				this.RaisePropertyChanged("Sale_Price");
			}
		}

		[XmlIgnore]
		public bool Sale_PriceSpecified
		{
			get
			{
				return this.sale_PriceFieldSpecified;
			}
			set
			{
				this.sale_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Sale_PriceSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement("Worktag_Reference", Order = 5)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
