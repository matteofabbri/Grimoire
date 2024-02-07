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
	public class Dispose_Asset_DataType : INotifyPropertyChanged
	{
		private Business_AssetObjectType asset_ReferenceField;

		private DateTime transaction_Effective_DateField;

		private Asset_Disposal_TypeObjectType disposal_Type_ReferenceField;

		private decimal percent_to_DisposeField;

		private bool percent_to_DisposeFieldSpecified;

		private decimal cost_to_DisposeField;

		private bool cost_to_DisposeFieldSpecified;

		private decimal disposal_Fair_Market_ValueField;

		private bool disposal_Fair_Market_ValueFieldSpecified;

		private decimal sale_PriceField;

		private bool sale_PriceFieldSpecified;

		private string commentsField;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

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

		[XmlElement(Order = 3)]
		public decimal Percent_to_Dispose
		{
			get
			{
				return this.percent_to_DisposeField;
			}
			set
			{
				this.percent_to_DisposeField = value;
				this.RaisePropertyChanged("Percent_to_Dispose");
			}
		}

		[XmlIgnore]
		public bool Percent_to_DisposeSpecified
		{
			get
			{
				return this.percent_to_DisposeFieldSpecified;
			}
			set
			{
				this.percent_to_DisposeFieldSpecified = value;
				this.RaisePropertyChanged("Percent_to_DisposeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Cost_to_Dispose
		{
			get
			{
				return this.cost_to_DisposeField;
			}
			set
			{
				this.cost_to_DisposeField = value;
				this.RaisePropertyChanged("Cost_to_Dispose");
			}
		}

		[XmlIgnore]
		public bool Cost_to_DisposeSpecified
		{
			get
			{
				return this.cost_to_DisposeFieldSpecified;
			}
			set
			{
				this.cost_to_DisposeFieldSpecified = value;
				this.RaisePropertyChanged("Cost_to_DisposeSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement("Worktag_Reference", Order = 8)]
		public Accounting_WorktagObjectType[] Worktag_Reference
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
