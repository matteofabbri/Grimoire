using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class PayeeType : INotifyPropertyChanged
	{
		private EmployeeObjectType payee_ReferenceField;

		private Universal_IdentifierObjectType universal_Identifier_ReferenceField;

		private Personal_Information_DataType payee_Personal_DataField;

		private Payee_Job_DataType[] payee_Job_DataField;

		private Worker_Status_Detail_DataType payee_Status_DataField;

		private Payee_Pay_Group_Earnings_and_Deductions_DataType[] payee_Pay_Group_Earnings_and_Deductions_DataField;

		private Payee_Earnings_and_Deductions_Summary_DataType[] payee_Earnings_and_Deductions_Summary_DataField;

		private Transaction_Log_EntryType[] payee_Transaction_Log_Entry_DataField;

		private Corrected_Or_Rescinded_Transaction_DataType[] payee_Transaction_Log_Corrected_And_Rescinded_DataField;

		private Payment_Election_Enrollment_Election_DataType[] payee_Payment_Election_DataField;

		private Payee_Tax_Withholding_DataType[] payee_Tax_Withholding_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		private Employee_Contract_DataType[] payee_Contracts_DataField;

		private Employee_Contract_DataType[] extended_Employee_Contracts_DataField;

		private Worker_Related_Persons_DataType payee_Related_Person_dataField;

		private Payee_Qualification_DataType payee_Qualification_DataField;

		private Payee_Costing_Allocation_DataType[] payee_Costing_Allocation_DataField;

		private System_User_for_Worker_DataType user_Account_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Payee_Reference
		{
			get
			{
				return this.payee_ReferenceField;
			}
			set
			{
				this.payee_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Universal_IdentifierObjectType Universal_Identifier_Reference
		{
			get
			{
				return this.universal_Identifier_ReferenceField;
			}
			set
			{
				this.universal_Identifier_ReferenceField = value;
				this.RaisePropertyChanged("Universal_Identifier_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Personal_Information_DataType Payee_Personal_Data
		{
			get
			{
				return this.payee_Personal_DataField;
			}
			set
			{
				this.payee_Personal_DataField = value;
				this.RaisePropertyChanged("Payee_Personal_Data");
			}
		}

		[XmlElement("Payee_Job_Data", Order = 3)]
		public Payee_Job_DataType[] Payee_Job_Data
		{
			get
			{
				return this.payee_Job_DataField;
			}
			set
			{
				this.payee_Job_DataField = value;
				this.RaisePropertyChanged("Payee_Job_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Worker_Status_Detail_DataType Payee_Status_Data
		{
			get
			{
				return this.payee_Status_DataField;
			}
			set
			{
				this.payee_Status_DataField = value;
				this.RaisePropertyChanged("Payee_Status_Data");
			}
		}

		[XmlElement("Payee_Pay_Group_Earnings_and_Deductions_Data", Order = 5)]
		public Payee_Pay_Group_Earnings_and_Deductions_DataType[] Payee_Pay_Group_Earnings_and_Deductions_Data
		{
			get
			{
				return this.payee_Pay_Group_Earnings_and_Deductions_DataField;
			}
			set
			{
				this.payee_Pay_Group_Earnings_and_Deductions_DataField = value;
				this.RaisePropertyChanged("Payee_Pay_Group_Earnings_and_Deductions_Data");
			}
		}

		[XmlElement("Payee_Earnings_and_Deductions_Summary_Data", Order = 6)]
		public Payee_Earnings_and_Deductions_Summary_DataType[] Payee_Earnings_and_Deductions_Summary_Data
		{
			get
			{
				return this.payee_Earnings_and_Deductions_Summary_DataField;
			}
			set
			{
				this.payee_Earnings_and_Deductions_Summary_DataField = value;
				this.RaisePropertyChanged("Payee_Earnings_and_Deductions_Summary_Data");
			}
		}

		[XmlArray(Order = 7), XmlArrayItem("Transaction_Log_Entry", typeof(Transaction_Log_EntryType), IsNullable = false)]
		public Transaction_Log_EntryType[] Payee_Transaction_Log_Entry_Data
		{
			get
			{
				return this.payee_Transaction_Log_Entry_DataField;
			}
			set
			{
				this.payee_Transaction_Log_Entry_DataField = value;
				this.RaisePropertyChanged("Payee_Transaction_Log_Entry_Data");
			}
		}

		[XmlArray(Order = 8), XmlArrayItem("Corrected_Or_Rescinded_Transaction_Log_Data", typeof(Corrected_Or_Rescinded_Transaction_DataType), IsNullable = false)]
		public Corrected_Or_Rescinded_Transaction_DataType[] Payee_Transaction_Log_Corrected_And_Rescinded_Data
		{
			get
			{
				return this.payee_Transaction_Log_Corrected_And_Rescinded_DataField;
			}
			set
			{
				this.payee_Transaction_Log_Corrected_And_Rescinded_DataField = value;
				this.RaisePropertyChanged("Payee_Transaction_Log_Corrected_And_Rescinded_Data");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Payment_Election_Enrollment_Data", typeof(Payment_Election_Enrollment_Election_DataType), IsNullable = false)]
		public Payment_Election_Enrollment_Election_DataType[] Payee_Payment_Election_Data
		{
			get
			{
				return this.payee_Payment_Election_DataField;
			}
			set
			{
				this.payee_Payment_Election_DataField = value;
				this.RaisePropertyChanged("Payee_Payment_Election_Data");
			}
		}

		[XmlElement("Payee_Tax_Withholding_Data", Order = 10)]
		public Payee_Tax_Withholding_DataType[] Payee_Tax_Withholding_Data
		{
			get
			{
				return this.payee_Tax_Withholding_DataField;
			}
			set
			{
				this.payee_Tax_Withholding_DataField = value;
				this.RaisePropertyChanged("Payee_Tax_Withholding_Data");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 11)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
			}
		}

		[XmlArray(Order = 12), XmlArrayItem("Employee_Contract_Data", IsNullable = false)]
		public Employee_Contract_DataType[] Payee_Contracts_Data
		{
			get
			{
				return this.payee_Contracts_DataField;
			}
			set
			{
				this.payee_Contracts_DataField = value;
				this.RaisePropertyChanged("Payee_Contracts_Data");
			}
		}

		[XmlArray(Order = 13), XmlArrayItem("Extended_Employee_Contract_Data", IsNullable = false), XmlArrayItem("Employee_Contract_Data", IsNullable = false, NestingLevel = 1)]
		public Employee_Contract_DataType[] Extended_Employee_Contracts_Data
		{
			get
			{
				return this.extended_Employee_Contracts_DataField;
			}
			set
			{
				this.extended_Employee_Contracts_DataField = value;
				this.RaisePropertyChanged("Extended_Employee_Contracts_Data");
			}
		}

		[XmlElement(Order = 14)]
		public Worker_Related_Persons_DataType Payee_Related_Person_data
		{
			get
			{
				return this.payee_Related_Person_dataField;
			}
			set
			{
				this.payee_Related_Person_dataField = value;
				this.RaisePropertyChanged("Payee_Related_Person_data");
			}
		}

		[XmlElement(Order = 15)]
		public Payee_Qualification_DataType Payee_Qualification_Data
		{
			get
			{
				return this.payee_Qualification_DataField;
			}
			set
			{
				this.payee_Qualification_DataField = value;
				this.RaisePropertyChanged("Payee_Qualification_Data");
			}
		}

		[XmlElement("Payee_Costing_Allocation_Data", Order = 16)]
		public Payee_Costing_Allocation_DataType[] Payee_Costing_Allocation_Data
		{
			get
			{
				return this.payee_Costing_Allocation_DataField;
			}
			set
			{
				this.payee_Costing_Allocation_DataField = value;
				this.RaisePropertyChanged("Payee_Costing_Allocation_Data");
			}
		}

		[XmlElement(Order = 17)]
		public System_User_for_Worker_DataType User_Account_Data
		{
			get
			{
				return this.user_Account_DataField;
			}
			set
			{
				this.user_Account_DataField = value;
				this.RaisePropertyChanged("User_Account_Data");
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
