using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contingent_Worker_Cost_Information_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType requester_ReferenceField;

		private CompanyObjectType company_for_Purchase_Order_ReferenceField;

		private SupplierObjectType supplier_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private decimal pay_RateField;

		private bool pay_RateFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal maximum_AmountField;

		private bool maximum_AmountFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Company_for_Purchase_Order_Reference
		{
			get
			{
				return this.company_for_Purchase_Order_ReferenceField;
			}
			set
			{
				this.company_for_Purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Pay_Rate
		{
			get
			{
				return this.pay_RateField;
			}
			set
			{
				this.pay_RateField = value;
				this.RaisePropertyChanged("Pay_Rate");
			}
		}

		[XmlIgnore]
		public bool Pay_RateSpecified
		{
			get
			{
				return this.pay_RateFieldSpecified;
			}
			set
			{
				this.pay_RateFieldSpecified = value;
				this.RaisePropertyChanged("Pay_RateSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Maximum_Amount
		{
			get
			{
				return this.maximum_AmountField;
			}
			set
			{
				this.maximum_AmountField = value;
				this.RaisePropertyChanged("Maximum_Amount");
			}
		}

		[XmlIgnore]
		public bool Maximum_AmountSpecified
		{
			get
			{
				return this.maximum_AmountFieldSpecified;
			}
			set
			{
				this.maximum_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_AmountSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 8)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
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
