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
	public class Employee_Contract_DataType : INotifyPropertyChanged
	{
		private Employee_ContractObjectType employee_Contract_ReferenceField;

		private Employee_Contract_ReasonObjectType[] employee_Contract_Reason_ReferenceField;

		private string employee_Contract_IDField;

		private DateTime effective_DateField;

		private string contract_IDField;

		private Employee_Contract_TypeObjectType contract_Type_ReferenceField;

		private DateTime contract_Start_DateField;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private Collective_AgreementObjectType[] employee_Contract_Collective_Agreement_ReferenceField;

		private decimal maximum_Weekly_HoursField;

		private bool maximum_Weekly_HoursFieldSpecified;

		private decimal minimum_Weekly_HoursField;

		private bool minimum_Weekly_HoursFieldSpecified;

		private Employee_Contract_StatusObjectType contract_Status_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private string contract_DescriptionField;

		private DateTime date_Employee_SignedField;

		private bool date_Employee_SignedFieldSpecified;

		private DateTime date_Employer_SignedField;

		private bool date_Employer_SignedFieldSpecified;

		private Worker_DocumentObjectType[] worker_Document_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Employee_ContractObjectType Employee_Contract_Reference
		{
			get
			{
				return this.employee_Contract_ReferenceField;
			}
			set
			{
				this.employee_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Contract_Reference");
			}
		}

		[XmlElement("Employee_Contract_Reason_Reference", Order = 1)]
		public Employee_Contract_ReasonObjectType[] Employee_Contract_Reason_Reference
		{
			get
			{
				return this.employee_Contract_Reason_ReferenceField;
			}
			set
			{
				this.employee_Contract_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Contract_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Employee_Contract_ID
		{
			get
			{
				return this.employee_Contract_IDField;
			}
			set
			{
				this.employee_Contract_IDField = value;
				this.RaisePropertyChanged("Employee_Contract_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Employee_Contract_TypeObjectType Contract_Type_Reference
		{
			get
			{
				return this.contract_Type_ReferenceField;
			}
			set
			{
				this.contract_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Type_Reference");
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

		[XmlElement("Employee_Contract_Collective_Agreement_Reference", Order = 8)]
		public Collective_AgreementObjectType[] Employee_Contract_Collective_Agreement_Reference
		{
			get
			{
				return this.employee_Contract_Collective_Agreement_ReferenceField;
			}
			set
			{
				this.employee_Contract_Collective_Agreement_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Contract_Collective_Agreement_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Maximum_Weekly_Hours
		{
			get
			{
				return this.maximum_Weekly_HoursField;
			}
			set
			{
				this.maximum_Weekly_HoursField = value;
				this.RaisePropertyChanged("Maximum_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Maximum_Weekly_HoursSpecified
		{
			get
			{
				return this.maximum_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.maximum_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Minimum_Weekly_Hours
		{
			get
			{
				return this.minimum_Weekly_HoursField;
			}
			set
			{
				this.minimum_Weekly_HoursField = value;
				this.RaisePropertyChanged("Minimum_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Minimum_Weekly_HoursSpecified
		{
			get
			{
				return this.minimum_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.minimum_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Employee_Contract_StatusObjectType Contract_Status_Reference
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

		[XmlElement(Order = 12)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public string Contract_Description
		{
			get
			{
				return this.contract_DescriptionField;
			}
			set
			{
				this.contract_DescriptionField = value;
				this.RaisePropertyChanged("Contract_Description");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Date_Employee_Signed
		{
			get
			{
				return this.date_Employee_SignedField;
			}
			set
			{
				this.date_Employee_SignedField = value;
				this.RaisePropertyChanged("Date_Employee_Signed");
			}
		}

		[XmlIgnore]
		public bool Date_Employee_SignedSpecified
		{
			get
			{
				return this.date_Employee_SignedFieldSpecified;
			}
			set
			{
				this.date_Employee_SignedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Employee_SignedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Date_Employer_Signed
		{
			get
			{
				return this.date_Employer_SignedField;
			}
			set
			{
				this.date_Employer_SignedField = value;
				this.RaisePropertyChanged("Date_Employer_Signed");
			}
		}

		[XmlIgnore]
		public bool Date_Employer_SignedSpecified
		{
			get
			{
				return this.date_Employer_SignedFieldSpecified;
			}
			set
			{
				this.date_Employer_SignedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Employer_SignedSpecified");
			}
		}

		[XmlElement("Worker_Document_Reference", Order = 16)]
		public Worker_DocumentObjectType[] Worker_Document_Reference
		{
			get
			{
				return this.worker_Document_ReferenceField;
			}
			set
			{
				this.worker_Document_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Document_Reference");
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
