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
	public class Order_Fulfillment_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private CustomerObjectType[] customers_ReferenceField;

		private Customer_ContractObjectType[] customer_Contracts_ReferenceField;

		private DateTime transaction_Date_Start_DateField;

		private bool transaction_Date_Start_DateFieldSpecified;

		private DateTime transaction_Date_End_DateField;

		private bool transaction_Date_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customers_Reference", Order = 0)]
		public CustomerObjectType[] Customers_Reference
		{
			get
			{
				return this.customers_ReferenceField;
			}
			set
			{
				this.customers_ReferenceField = value;
				this.RaisePropertyChanged("Customers_Reference");
			}
		}

		[XmlElement("Customer_Contracts_Reference", Order = 1)]
		public Customer_ContractObjectType[] Customer_Contracts_Reference
		{
			get
			{
				return this.customer_Contracts_ReferenceField;
			}
			set
			{
				this.customer_Contracts_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contracts_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Transaction_Date_Start_Date
		{
			get
			{
				return this.transaction_Date_Start_DateField;
			}
			set
			{
				this.transaction_Date_Start_DateField = value;
				this.RaisePropertyChanged("Transaction_Date_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_Start_DateSpecified
		{
			get
			{
				return this.transaction_Date_Start_DateFieldSpecified;
			}
			set
			{
				this.transaction_Date_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Transaction_Date_End_Date
		{
			get
			{
				return this.transaction_Date_End_DateField;
			}
			set
			{
				this.transaction_Date_End_DateField = value;
				this.RaisePropertyChanged("Transaction_Date_End_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_End_DateSpecified
		{
			get
			{
				return this.transaction_Date_End_DateFieldSpecified;
			}
			set
			{
				this.transaction_Date_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_End_DateSpecified");
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
