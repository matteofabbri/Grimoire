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
	public class Expense_Report_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private Expense_PayeeObjectType[] expense_Payee_ReferenceField;

		private Unique_IdentifierObjectType[] expense_Payee_Type_ReferenceField;

		private DateTime expense_Report_From_DateField;

		private bool expense_Report_From_DateFieldSpecified;

		private DateTime expense_Report_To_DateField;

		private bool expense_Report_To_DateFieldSpecified;

		private string document_NumberField;

		private Document_Payment_StatusObjectType expense_Report_Payment_Status_ReferenceField;

		private DateTime created_From_DateField;

		private bool created_From_DateFieldSpecified;

		private DateTime created_To_DateField;

		private bool created_To_DateFieldSpecified;

		private DateTime approved_From_DateField;

		private bool approved_From_DateFieldSpecified;

		private DateTime approved_To_DateField;

		private bool approved_To_DateFieldSpecified;

		private DateTime payment_Updated_From_DateField;

		private bool payment_Updated_From_DateFieldSpecified;

		private DateTime payment_Updated_To_DateField;

		private bool payment_Updated_To_DateFieldSpecified;

		private Unique_IdentifierObjectType payment_Update_Type_ReferenceField;

		private string market_CodeField;

		private Corporate_Credit_Card_AccountObjectType corporate_Account_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Expense_Payee_Reference", Order = 1)]
		public Expense_PayeeObjectType[] Expense_Payee_Reference
		{
			get
			{
				return this.expense_Payee_ReferenceField;
			}
			set
			{
				this.expense_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Payee_Reference");
			}
		}

		[XmlElement("Expense_Payee_Type_Reference", Order = 2)]
		public Unique_IdentifierObjectType[] Expense_Payee_Type_Reference
		{
			get
			{
				return this.expense_Payee_Type_ReferenceField;
			}
			set
			{
				this.expense_Payee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Payee_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Expense_Report_From_Date
		{
			get
			{
				return this.expense_Report_From_DateField;
			}
			set
			{
				this.expense_Report_From_DateField = value;
				this.RaisePropertyChanged("Expense_Report_From_Date");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_From_DateSpecified
		{
			get
			{
				return this.expense_Report_From_DateFieldSpecified;
			}
			set
			{
				this.expense_Report_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Expense_Report_To_Date
		{
			get
			{
				return this.expense_Report_To_DateField;
			}
			set
			{
				this.expense_Report_To_DateField = value;
				this.RaisePropertyChanged("Expense_Report_To_Date");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_To_DateSpecified
		{
			get
			{
				return this.expense_Report_To_DateFieldSpecified;
			}
			set
			{
				this.expense_Report_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_To_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Document_Number
		{
			get
			{
				return this.document_NumberField;
			}
			set
			{
				this.document_NumberField = value;
				this.RaisePropertyChanged("Document_Number");
			}
		}

		[XmlElement(Order = 6)]
		public Document_Payment_StatusObjectType Expense_Report_Payment_Status_Reference
		{
			get
			{
				return this.expense_Report_Payment_Status_ReferenceField;
			}
			set
			{
				this.expense_Report_Payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Report_Payment_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Created_From_Date
		{
			get
			{
				return this.created_From_DateField;
			}
			set
			{
				this.created_From_DateField = value;
				this.RaisePropertyChanged("Created_From_Date");
			}
		}

		[XmlIgnore]
		public bool Created_From_DateSpecified
		{
			get
			{
				return this.created_From_DateFieldSpecified;
			}
			set
			{
				this.created_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Created_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Created_To_Date
		{
			get
			{
				return this.created_To_DateField;
			}
			set
			{
				this.created_To_DateField = value;
				this.RaisePropertyChanged("Created_To_Date");
			}
		}

		[XmlIgnore]
		public bool Created_To_DateSpecified
		{
			get
			{
				return this.created_To_DateFieldSpecified;
			}
			set
			{
				this.created_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Created_To_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Approved_From_Date
		{
			get
			{
				return this.approved_From_DateField;
			}
			set
			{
				this.approved_From_DateField = value;
				this.RaisePropertyChanged("Approved_From_Date");
			}
		}

		[XmlIgnore]
		public bool Approved_From_DateSpecified
		{
			get
			{
				return this.approved_From_DateFieldSpecified;
			}
			set
			{
				this.approved_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Approved_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Approved_To_Date
		{
			get
			{
				return this.approved_To_DateField;
			}
			set
			{
				this.approved_To_DateField = value;
				this.RaisePropertyChanged("Approved_To_Date");
			}
		}

		[XmlIgnore]
		public bool Approved_To_DateSpecified
		{
			get
			{
				return this.approved_To_DateFieldSpecified;
			}
			set
			{
				this.approved_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Approved_To_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public DateTime Payment_Updated_From_Date
		{
			get
			{
				return this.payment_Updated_From_DateField;
			}
			set
			{
				this.payment_Updated_From_DateField = value;
				this.RaisePropertyChanged("Payment_Updated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Updated_From_DateSpecified
		{
			get
			{
				return this.payment_Updated_From_DateFieldSpecified;
			}
			set
			{
				this.payment_Updated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Updated_From_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public DateTime Payment_Updated_To_Date
		{
			get
			{
				return this.payment_Updated_To_DateField;
			}
			set
			{
				this.payment_Updated_To_DateField = value;
				this.RaisePropertyChanged("Payment_Updated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Updated_To_DateSpecified
		{
			get
			{
				return this.payment_Updated_To_DateFieldSpecified;
			}
			set
			{
				this.payment_Updated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Updated_To_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Unique_IdentifierObjectType Payment_Update_Type_Reference
		{
			get
			{
				return this.payment_Update_Type_ReferenceField;
			}
			set
			{
				this.payment_Update_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Update_Type_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public string Market_Code
		{
			get
			{
				return this.market_CodeField;
			}
			set
			{
				this.market_CodeField = value;
				this.RaisePropertyChanged("Market_Code");
			}
		}

		[XmlElement(Order = 15)]
		public Corporate_Credit_Card_AccountObjectType Corporate_Account_Reference
		{
			get
			{
				return this.corporate_Account_ReferenceField;
			}
			set
			{
				this.corporate_Account_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Account_Reference");
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
