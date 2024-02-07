using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Report_DataType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private Company_ReferenceType company_ReferenceField;

		private Currency_Reference_DataType currency_ReferenceField;

		private Employee_ReferenceType employee_ReferenceField;

		private DateTime expense_Report_DateField;

		private string expense_Report_NumberField;

		private decimal total_AmountField;

		private bool total_AmountFieldSpecified;

		private string expense_Report_DescriptionField;

		private bool expense_Report_Approved_ExternallyField;

		private bool expense_Report_Approved_ExternallyFieldSpecified;

		private Payment_Type_ReferenceType payment_Type_ReferenceField;

		private Expense_Report_Line_DataType[] expense_Report_Line_DataField;

		private Financials_Attachment_DataType[] business_Document_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Company_ReferenceType Company_Reference
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

		[XmlElement(Order = 2)]
		public Currency_Reference_DataType Currency_Reference
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

		[XmlElement(Order = 3)]
		public Employee_ReferenceType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Expense_Report_Date
		{
			get
			{
				return this.expense_Report_DateField;
			}
			set
			{
				this.expense_Report_DateField = value;
				this.RaisePropertyChanged("Expense_Report_Date");
			}
		}

		[XmlElement(Order = 5)]
		public string Expense_Report_Number
		{
			get
			{
				return this.expense_Report_NumberField;
			}
			set
			{
				this.expense_Report_NumberField = value;
				this.RaisePropertyChanged("Expense_Report_Number");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Total_Amount
		{
			get
			{
				return this.total_AmountField;
			}
			set
			{
				this.total_AmountField = value;
				this.RaisePropertyChanged("Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_AmountSpecified
		{
			get
			{
				return this.total_AmountFieldSpecified;
			}
			set
			{
				this.total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Expense_Report_Description
		{
			get
			{
				return this.expense_Report_DescriptionField;
			}
			set
			{
				this.expense_Report_DescriptionField = value;
				this.RaisePropertyChanged("Expense_Report_Description");
			}
		}

		[XmlElement(Order = 8)]
		public bool Expense_Report_Approved_Externally
		{
			get
			{
				return this.expense_Report_Approved_ExternallyField;
			}
			set
			{
				this.expense_Report_Approved_ExternallyField = value;
				this.RaisePropertyChanged("Expense_Report_Approved_Externally");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_Approved_ExternallySpecified
		{
			get
			{
				return this.expense_Report_Approved_ExternallyFieldSpecified;
			}
			set
			{
				this.expense_Report_Approved_ExternallyFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_Approved_ExternallySpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Payment_Type_ReferenceType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement("Expense_Report_Line_Data", Order = 10)]
		public Expense_Report_Line_DataType[] Expense_Report_Line_Data
		{
			get
			{
				return this.expense_Report_Line_DataField;
			}
			set
			{
				this.expense_Report_Line_DataField = value;
				this.RaisePropertyChanged("Expense_Report_Line_Data");
			}
		}

		[XmlElement("Business_Document_Attachment_Data", Order = 11)]
		public Financials_Attachment_DataType[] Business_Document_Attachment_Data
		{
			get
			{
				return this.business_Document_Attachment_DataField;
			}
			set
			{
				this.business_Document_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Document_Attachment_Data");
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
