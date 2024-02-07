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
	public class Contract_Rate_Sheet_DataType : INotifyPropertyChanged
	{
		private string contract_Rate_Sheet_IDField;

		private string contract_Rate_Sheet_NameField;

		private DateTime effective_DateField;

		private Project_Billing_Rate_SheetObjectType project_Billing_Rate_Sheet_ReferenceField;

		private Project_Rate_Category_MemberObjectType[] project_Rate_Category_Member_ReferenceField;

		private Customer_Contract_LineObjectType[] customer_Contract_Line_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Contract_Rate_DataType[] contract_RatesField;

		private Billing_Rate_Rule_Type_Group_DataType[] billing_Rate_Rule_Type_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Contract_Rate_Sheet_ID
		{
			get
			{
				return this.contract_Rate_Sheet_IDField;
			}
			set
			{
				this.contract_Rate_Sheet_IDField = value;
				this.RaisePropertyChanged("Contract_Rate_Sheet_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Contract_Rate_Sheet_Name
		{
			get
			{
				return this.contract_Rate_Sheet_NameField;
			}
			set
			{
				this.contract_Rate_Sheet_NameField = value;
				this.RaisePropertyChanged("Contract_Rate_Sheet_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 3)]
		public Project_Billing_Rate_SheetObjectType Project_Billing_Rate_Sheet_Reference
		{
			get
			{
				return this.project_Billing_Rate_Sheet_ReferenceField;
			}
			set
			{
				this.project_Billing_Rate_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Project_Billing_Rate_Sheet_Reference");
			}
		}

		[XmlElement("Project_Rate_Category_Member_Reference", Order = 4)]
		public Project_Rate_Category_MemberObjectType[] Project_Rate_Category_Member_Reference
		{
			get
			{
				return this.project_Rate_Category_Member_ReferenceField;
			}
			set
			{
				this.project_Rate_Category_Member_ReferenceField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Member_Reference");
			}
		}

		[XmlElement("Customer_Contract_Line_Reference", Order = 5)]
		public Customer_Contract_LineObjectType[] Customer_Contract_Line_Reference
		{
			get
			{
				return this.customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Contract_Rates", Order = 7)]
		public Contract_Rate_DataType[] Contract_Rates
		{
			get
			{
				return this.contract_RatesField;
			}
			set
			{
				this.contract_RatesField = value;
				this.RaisePropertyChanged("Contract_Rates");
			}
		}

		[XmlElement("Billing_Rate_Rule_Type_Group_Data", Order = 8)]
		public Billing_Rate_Rule_Type_Group_DataType[] Billing_Rate_Rule_Type_Group_Data
		{
			get
			{
				return this.billing_Rate_Rule_Type_Group_DataField;
			}
			set
			{
				this.billing_Rate_Rule_Type_Group_DataField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Type_Group_Data");
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
