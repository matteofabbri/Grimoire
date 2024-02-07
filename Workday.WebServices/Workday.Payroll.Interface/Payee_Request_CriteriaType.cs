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
	public class Payee_Request_CriteriaType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType pay_Group_ReferenceField;

		private PeriodObjectType pay_Period_ReferenceField;

		private bool return_Benefits_as_of_Payment_DateField;

		private bool return_Benefits_as_of_Payment_DateFieldSpecified;

		private bool include_Terminated_PayeesField;

		private bool include_Terminated_PayeesFieldSpecified;

		private Include_Transfers_Out_Of_Pay_GroupType include_Transfers_Out_Of_Pay_GroupField;

		private EmployeeObjectType[] payee_ReferenceField;

		private EmployeeObjectType[] exclude_Payee_ReferenceField;

		private Transaction_Log_CriteriaType[] transaction_Log_Criteria_DataField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		private bool include_Costing_Allocation_DataField;

		private bool include_Costing_Allocation_DataFieldSpecified;

		private bool use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateField;

		private bool use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateFieldSpecified;

		private DateTime as_of_Effective_Date_for_Management_ChainField;

		private bool as_of_Effective_Date_for_Management_ChainFieldSpecified;

		private bool use_Pay_Period_for_Payroll_Input_Start_and_End_DateField;

		private bool use_Pay_Period_for_Payroll_Input_Start_and_End_DateFieldSpecified;

		private bool include_Purged_PayeesField;

		private bool include_Purged_PayeesFieldSpecified;

		private Universal_IdentifierObjectType[] universal_ID_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_GroupObjectType Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public PeriodObjectType Pay_Period_Reference
		{
			get
			{
				return this.pay_Period_ReferenceField;
			}
			set
			{
				this.pay_Period_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Period_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Return_Benefits_as_of_Payment_Date
		{
			get
			{
				return this.return_Benefits_as_of_Payment_DateField;
			}
			set
			{
				this.return_Benefits_as_of_Payment_DateField = value;
				this.RaisePropertyChanged("Return_Benefits_as_of_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Return_Benefits_as_of_Payment_DateSpecified
		{
			get
			{
				return this.return_Benefits_as_of_Payment_DateFieldSpecified;
			}
			set
			{
				this.return_Benefits_as_of_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Return_Benefits_as_of_Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Terminated_Payees
		{
			get
			{
				return this.include_Terminated_PayeesField;
			}
			set
			{
				this.include_Terminated_PayeesField = value;
				this.RaisePropertyChanged("Include_Terminated_Payees");
			}
		}

		[XmlIgnore]
		public bool Include_Terminated_PayeesSpecified
		{
			get
			{
				return this.include_Terminated_PayeesFieldSpecified;
			}
			set
			{
				this.include_Terminated_PayeesFieldSpecified = value;
				this.RaisePropertyChanged("Include_Terminated_PayeesSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Include_Transfers_Out_Of_Pay_GroupType Include_Transfers_Out_Of_Pay_Group
		{
			get
			{
				return this.include_Transfers_Out_Of_Pay_GroupField;
			}
			set
			{
				this.include_Transfers_Out_Of_Pay_GroupField = value;
				this.RaisePropertyChanged("Include_Transfers_Out_Of_Pay_Group");
			}
		}

		[XmlElement("Payee_Reference", Order = 5)]
		public EmployeeObjectType[] Payee_Reference
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

		[XmlElement("Exclude_Payee_Reference", Order = 6)]
		public EmployeeObjectType[] Exclude_Payee_Reference
		{
			get
			{
				return this.exclude_Payee_ReferenceField;
			}
			set
			{
				this.exclude_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Exclude_Payee_Reference");
			}
		}

		[XmlElement("Transaction_Log_Criteria_Data", Order = 7)]
		public Transaction_Log_CriteriaType[] Transaction_Log_Criteria_Data
		{
			get
			{
				return this.transaction_Log_Criteria_DataField;
			}
			set
			{
				this.transaction_Log_Criteria_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Criteria_Data");
			}
		}

		[XmlArray(Order = 8), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
			}
		}

		[XmlElement(Order = 9)]
		public bool Include_Costing_Allocation_Data
		{
			get
			{
				return this.include_Costing_Allocation_DataField;
			}
			set
			{
				this.include_Costing_Allocation_DataField = value;
				this.RaisePropertyChanged("Include_Costing_Allocation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Costing_Allocation_DataSpecified
		{
			get
			{
				return this.include_Costing_Allocation_DataFieldSpecified;
			}
			set
			{
				this.include_Costing_Allocation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Costing_Allocation_DataSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_Date
		{
			get
			{
				return this.use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateField;
			}
			set
			{
				this.use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateField = value;
				this.RaisePropertyChanged("Use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_Date");
			}
		}

		[XmlIgnore]
		public bool Use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateSpecified
		{
			get
			{
				return this.use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateFieldSpecified;
			}
			set
			{
				this.use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Use_Pay_Period_for_Time_Off_Period_Start_Date_and_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime As_of_Effective_Date_for_Management_Chain
		{
			get
			{
				return this.as_of_Effective_Date_for_Management_ChainField;
			}
			set
			{
				this.as_of_Effective_Date_for_Management_ChainField = value;
				this.RaisePropertyChanged("As_of_Effective_Date_for_Management_Chain");
			}
		}

		[XmlIgnore]
		public bool As_of_Effective_Date_for_Management_ChainSpecified
		{
			get
			{
				return this.as_of_Effective_Date_for_Management_ChainFieldSpecified;
			}
			set
			{
				this.as_of_Effective_Date_for_Management_ChainFieldSpecified = value;
				this.RaisePropertyChanged("As_of_Effective_Date_for_Management_ChainSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Use_Pay_Period_for_Payroll_Input_Start_and_End_Date
		{
			get
			{
				return this.use_Pay_Period_for_Payroll_Input_Start_and_End_DateField;
			}
			set
			{
				this.use_Pay_Period_for_Payroll_Input_Start_and_End_DateField = value;
				this.RaisePropertyChanged("Use_Pay_Period_for_Payroll_Input_Start_and_End_Date");
			}
		}

		[XmlIgnore]
		public bool Use_Pay_Period_for_Payroll_Input_Start_and_End_DateSpecified
		{
			get
			{
				return this.use_Pay_Period_for_Payroll_Input_Start_and_End_DateFieldSpecified;
			}
			set
			{
				this.use_Pay_Period_for_Payroll_Input_Start_and_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Use_Pay_Period_for_Payroll_Input_Start_and_End_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Include_Purged_Payees
		{
			get
			{
				return this.include_Purged_PayeesField;
			}
			set
			{
				this.include_Purged_PayeesField = value;
				this.RaisePropertyChanged("Include_Purged_Payees");
			}
		}

		[XmlIgnore]
		public bool Include_Purged_PayeesSpecified
		{
			get
			{
				return this.include_Purged_PayeesFieldSpecified;
			}
			set
			{
				this.include_Purged_PayeesFieldSpecified = value;
				this.RaisePropertyChanged("Include_Purged_PayeesSpecified");
			}
		}

		[XmlElement("Universal_ID_Reference", Order = 14)]
		public Universal_IdentifierObjectType[] Universal_ID_Reference
		{
			get
			{
				return this.universal_ID_ReferenceField;
			}
			set
			{
				this.universal_ID_ReferenceField = value;
				this.RaisePropertyChanged("Universal_ID_Reference");
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
