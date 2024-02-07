using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Contract_Detail_DataType : INotifyPropertyChanged
	{
		private decimal contract_Pay_RateField;

		private bool contract_Pay_RateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private string contract_Assignment_DetailsField;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private SupplierObjectType supplier_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Contract_Pay_Rate
		{
			get
			{
				return this.contract_Pay_RateField;
			}
			set
			{
				this.contract_Pay_RateField = value;
				this.RaisePropertyChanged("Contract_Pay_Rate");
			}
		}

		[XmlIgnore]
		public bool Contract_Pay_RateSpecified
		{
			get
			{
				return this.contract_Pay_RateFieldSpecified;
			}
			set
			{
				this.contract_Pay_RateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Pay_RateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Contract_Assignment_Details
		{
			get
			{
				return this.contract_Assignment_DetailsField;
			}
			set
			{
				this.contract_Assignment_DetailsField = value;
				this.RaisePropertyChanged("Contract_Assignment_Details");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public SupplierObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
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
