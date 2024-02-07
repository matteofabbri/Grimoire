using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Change_Benefits_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_ReferenceField;

		private Benefit_Event_TypeObjectType[] benefit_Event_Type_ReferenceField;

		private DateTime event_DateField;

		private decimal benefit_Deduction_Periods_RemainingField;

		private bool benefit_Deduction_Periods_RemainingFieldSpecified;

		private FrequencyObjectType remaining_Period_Frequency_ReferenceField;

		private decimal excess_Credits_to_HSAField;

		private bool excess_Credits_to_HSAFieldSpecified;

		private bool has_Existing_Medical_CoverageField;

		private bool has_Existing_Medical_CoverageFieldSpecified;

		private DateTime enrollment_Signature_DateField;

		private bool enrollment_Signature_DateFieldSpecified;

		private WorkerObjectType signing_Worker_ReferenceField;

		private Benefit_Election_Change_Benefits_DataType[] benefit_Election_DataField;

		private Benefit_Coverage_Type_for_Retirement_Savings_Elections_DataType[] retirement_Savings_Coverage_Type_DataField;

		private Biographic_DataType[] biographic_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Employee_Reference
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

		[XmlElement("Benefit_Event_Type_Reference", Order = 1)]
		public Benefit_Event_TypeObjectType[] Benefit_Event_Type_Reference
		{
			get
			{
				return this.benefit_Event_Type_ReferenceField;
			}
			set
			{
				this.benefit_Event_Type_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Event_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Event_Date
		{
			get
			{
				return this.event_DateField;
			}
			set
			{
				this.event_DateField = value;
				this.RaisePropertyChanged("Event_Date");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Benefit_Deduction_Periods_Remaining
		{
			get
			{
				return this.benefit_Deduction_Periods_RemainingField;
			}
			set
			{
				this.benefit_Deduction_Periods_RemainingField = value;
				this.RaisePropertyChanged("Benefit_Deduction_Periods_Remaining");
			}
		}

		[XmlIgnore]
		public bool Benefit_Deduction_Periods_RemainingSpecified
		{
			get
			{
				return this.benefit_Deduction_Periods_RemainingFieldSpecified;
			}
			set
			{
				this.benefit_Deduction_Periods_RemainingFieldSpecified = value;
				this.RaisePropertyChanged("Benefit_Deduction_Periods_RemainingSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public FrequencyObjectType Remaining_Period_Frequency_Reference
		{
			get
			{
				return this.remaining_Period_Frequency_ReferenceField;
			}
			set
			{
				this.remaining_Period_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Remaining_Period_Frequency_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Excess_Credits_to_HSA
		{
			get
			{
				return this.excess_Credits_to_HSAField;
			}
			set
			{
				this.excess_Credits_to_HSAField = value;
				this.RaisePropertyChanged("Excess_Credits_to_HSA");
			}
		}

		[XmlIgnore]
		public bool Excess_Credits_to_HSASpecified
		{
			get
			{
				return this.excess_Credits_to_HSAFieldSpecified;
			}
			set
			{
				this.excess_Credits_to_HSAFieldSpecified = value;
				this.RaisePropertyChanged("Excess_Credits_to_HSASpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Has_Existing_Medical_Coverage
		{
			get
			{
				return this.has_Existing_Medical_CoverageField;
			}
			set
			{
				this.has_Existing_Medical_CoverageField = value;
				this.RaisePropertyChanged("Has_Existing_Medical_Coverage");
			}
		}

		[XmlIgnore]
		public bool Has_Existing_Medical_CoverageSpecified
		{
			get
			{
				return this.has_Existing_Medical_CoverageFieldSpecified;
			}
			set
			{
				this.has_Existing_Medical_CoverageFieldSpecified = value;
				this.RaisePropertyChanged("Has_Existing_Medical_CoverageSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Enrollment_Signature_Date
		{
			get
			{
				return this.enrollment_Signature_DateField;
			}
			set
			{
				this.enrollment_Signature_DateField = value;
				this.RaisePropertyChanged("Enrollment_Signature_Date");
			}
		}

		[XmlIgnore]
		public bool Enrollment_Signature_DateSpecified
		{
			get
			{
				return this.enrollment_Signature_DateFieldSpecified;
			}
			set
			{
				this.enrollment_Signature_DateFieldSpecified = value;
				this.RaisePropertyChanged("Enrollment_Signature_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public WorkerObjectType Signing_Worker_Reference
		{
			get
			{
				return this.signing_Worker_ReferenceField;
			}
			set
			{
				this.signing_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Signing_Worker_Reference");
			}
		}

		[XmlElement("Benefit_Election_Data", Order = 9)]
		public Benefit_Election_Change_Benefits_DataType[] Benefit_Election_Data
		{
			get
			{
				return this.benefit_Election_DataField;
			}
			set
			{
				this.benefit_Election_DataField = value;
				this.RaisePropertyChanged("Benefit_Election_Data");
			}
		}

		[XmlElement("Retirement_Savings_Coverage_Type_Data", Order = 10)]
		public Benefit_Coverage_Type_for_Retirement_Savings_Elections_DataType[] Retirement_Savings_Coverage_Type_Data
		{
			get
			{
				return this.retirement_Savings_Coverage_Type_DataField;
			}
			set
			{
				this.retirement_Savings_Coverage_Type_DataField = value;
				this.RaisePropertyChanged("Retirement_Savings_Coverage_Type_Data");
			}
		}

		[XmlElement("Biographic_Data", Order = 11)]
		public Biographic_DataType[] Biographic_Data
		{
			get
			{
				return this.biographic_DataField;
			}
			set
			{
				this.biographic_DataField = value;
				this.RaisePropertyChanged("Biographic_Data");
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
