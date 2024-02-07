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
	public class Alternate_Customer_Contract_Request_CriteriaType : INotifyPropertyChanged
	{
		private CustomerObjectType[] customer_ReferenceField;

		private string customer_Contract_NameField;

		private string customer_Contract_IDField;

		private CompanyObjectType company_ReferenceField;

		private Customer_Contract_TypeObjectType[] customer_Contract_Type_ReferenceField;

		private Document_StatusObjectType[] contract_Status_ReferenceField;

		private DateTime contract_Effective_Date_On_or_AfterField;

		private bool contract_Effective_Date_On_or_AfterFieldSpecified;

		private DateTime contract_Effective_Date_On_or_BeforeField;

		private bool contract_Effective_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Reference", Order = 0)]
		public CustomerObjectType[] Customer_Reference
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

		[XmlElement(Order = 1)]
		public string Customer_Contract_Name
		{
			get
			{
				return this.customer_Contract_NameField;
			}
			set
			{
				this.customer_Contract_NameField = value;
				this.RaisePropertyChanged("Customer_Contract_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Customer_Contract_ID
		{
			get
			{
				return this.customer_Contract_IDField;
			}
			set
			{
				this.customer_Contract_IDField = value;
				this.RaisePropertyChanged("Customer_Contract_ID");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Company_Reference
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

		[XmlElement("Customer_Contract_Type_Reference", Order = 4)]
		public Customer_Contract_TypeObjectType[] Customer_Contract_Type_Reference
		{
			get
			{
				return this.customer_Contract_Type_ReferenceField;
			}
			set
			{
				this.customer_Contract_Type_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Type_Reference");
			}
		}

		[XmlElement("Contract_Status_Reference", Order = 5)]
		public Document_StatusObjectType[] Contract_Status_Reference
		{
			get
			{
				return this.contract_Status_ReferenceField;
			}
			set
			{
				this.contract_Status_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Contract_Effective_Date_On_or_After
		{
			get
			{
				return this.contract_Effective_Date_On_or_AfterField;
			}
			set
			{
				this.contract_Effective_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Contract_Effective_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Contract_Effective_Date_On_or_AfterSpecified
		{
			get
			{
				return this.contract_Effective_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.contract_Effective_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Effective_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Contract_Effective_Date_On_or_Before
		{
			get
			{
				return this.contract_Effective_Date_On_or_BeforeField;
			}
			set
			{
				this.contract_Effective_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Contract_Effective_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Contract_Effective_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.contract_Effective_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.contract_Effective_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Effective_Date_On_or_BeforeSpecified");
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
