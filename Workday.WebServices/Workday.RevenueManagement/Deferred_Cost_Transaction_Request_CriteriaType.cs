using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Deferred_Cost_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private CurrencyObjectType[] currency_ReferenceField;

		private Billable_EntityObjectType[] customer_ReferenceField;

		private Customer_ContractObjectType[] contract_ReferenceField;

		private Cost_TypeObjectType[] cost_Type_ReferenceField;

		private Document_StatusObjectType[] status_ReferenceField;

		private DateTime transaction_Date_no_earlier_thanField;

		private bool transaction_Date_no_earlier_thanFieldSpecified;

		private DateTime transaction_Date_no_later_thanField;

		private bool transaction_Date_no_later_thanFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public OrganizationObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Currency_Reference", Order = 1)]
		public CurrencyObjectType[] Currency_Reference
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

		[XmlElement("Customer_Reference", Order = 2)]
		public Billable_EntityObjectType[] Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement("Contract_Reference", Order = 3)]
		public Customer_ContractObjectType[] Contract_Reference
		{
			get
			{
				return this.contract_ReferenceField;
			}
			set
			{
				this.contract_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Reference");
			}
		}

		[XmlElement("Cost_Type_Reference", Order = 4)]
		public Cost_TypeObjectType[] Cost_Type_Reference
		{
			get
			{
				return this.cost_Type_ReferenceField;
			}
			set
			{
				this.cost_Type_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Type_Reference");
			}
		}

		[XmlElement("Status_Reference", Order = 5)]
		public Document_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Transaction_Date_no_earlier_than
		{
			get
			{
				return this.transaction_Date_no_earlier_thanField;
			}
			set
			{
				this.transaction_Date_no_earlier_thanField = value;
				this.RaisePropertyChanged("Transaction_Date_no_earlier_than");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_no_earlier_thanSpecified
		{
			get
			{
				return this.transaction_Date_no_earlier_thanFieldSpecified;
			}
			set
			{
				this.transaction_Date_no_earlier_thanFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_no_earlier_thanSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Transaction_Date_no_later_than
		{
			get
			{
				return this.transaction_Date_no_later_thanField;
			}
			set
			{
				this.transaction_Date_no_later_thanField = value;
				this.RaisePropertyChanged("Transaction_Date_no_later_than");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_no_later_thanSpecified
		{
			get
			{
				return this.transaction_Date_no_later_thanFieldSpecified;
			}
			set
			{
				this.transaction_Date_no_later_thanFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_no_later_thanSpecified");
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
