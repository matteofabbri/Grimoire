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
	public class Supplier_Order_Contract_Data_for_Put_and_GetType : INotifyPropertyChanged
	{
		private string contract_IDField;

		private string contract_NameField;

		private Resource_ProviderObjectType resource_Provider_ReferenceField;

		private string supplier_Contract_Reference_NumberField;

		private object itemField;

		private WorkerObjectType buyer_ReferenceField;

		private DateTime contract_Start_DateField;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private decimal total_Contract_AmountField;

		private bool total_Contract_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string contract_OverviewField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private Financials_Attachment_DataType[] attachment_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Contract_ID
		{
			get
			{
				return this.contract_IDField;
			}
			set
			{
				this.contract_IDField = value;
				this.RaisePropertyChanged("Contract_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Contract_Name
		{
			get
			{
				return this.contract_NameField;
			}
			set
			{
				this.contract_NameField = value;
				this.RaisePropertyChanged("Contract_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Resource_ProviderObjectType Resource_Provider_Reference
		{
			get
			{
				return this.resource_Provider_ReferenceField;
			}
			set
			{
				this.resource_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Provider_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Supplier_Contract_Reference_Number
		{
			get
			{
				return this.supplier_Contract_Reference_NumberField;
			}
			set
			{
				this.supplier_Contract_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference_Number");
			}
		}

		[XmlElement("Company_Hierarchy_Reference", typeof(OrganizationObjectType), Order = 4), XmlElement("Company_Reference", typeof(CompanyObjectType), Order = 4)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 5)]
		public WorkerObjectType Buyer_Reference
		{
			get
			{
				return this.buyer_ReferenceField;
			}
			set
			{
				this.buyer_ReferenceField = value;
				this.RaisePropertyChanged("Buyer_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Contract_Start_Date
		{
			get
			{
				return this.contract_Start_DateField;
			}
			set
			{
				this.contract_Start_DateField = value;
				this.RaisePropertyChanged("Contract_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Total_Contract_Amount
		{
			get
			{
				return this.total_Contract_AmountField;
			}
			set
			{
				this.total_Contract_AmountField = value;
				this.RaisePropertyChanged("Total_Contract_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Contract_AmountSpecified
		{
			get
			{
				return this.total_Contract_AmountFieldSpecified;
			}
			set
			{
				this.total_Contract_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Contract_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public string Contract_Overview
		{
			get
			{
				return this.contract_OverviewField;
			}
			set
			{
				this.contract_OverviewField = value;
				this.RaisePropertyChanged("Contract_Overview");
			}
		}

		[XmlElement(Order = 11)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement("Attachment_Replacement_Data", Order = 12)]
		public Financials_Attachment_DataType[] Attachment_Replacement_Data
		{
			get
			{
				return this.attachment_Replacement_DataField;
			}
			set
			{
				this.attachment_Replacement_DataField = value;
				this.RaisePropertyChanged("Attachment_Replacement_Data");
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
