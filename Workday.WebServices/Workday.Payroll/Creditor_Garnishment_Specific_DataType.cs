using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Creditor_Garnishment_Specific_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType creditor_Garnishment_Type_ReferenceField;

		private bool head_of_HouseholdField;

		private bool head_of_HouseholdFieldSpecified;

		private decimal number_of_DependentsField;

		private bool number_of_DependentsFieldSpecified;

		private bool worker_is_Laborer_or_MechanicField;

		private bool worker_is_Laborer_or_MechanicFieldSpecified;

		private decimal good_Cause_Limit_PercentField;

		private bool good_Cause_Limit_PercentFieldSpecified;

		private decimal expected_Annual_EarningsField;

		private bool expected_Annual_EarningsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Creditor_Garnishment_Type_Reference
		{
			get
			{
				return this.creditor_Garnishment_Type_ReferenceField;
			}
			set
			{
				this.creditor_Garnishment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Creditor_Garnishment_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Head_of_Household
		{
			get
			{
				return this.head_of_HouseholdField;
			}
			set
			{
				this.head_of_HouseholdField = value;
				this.RaisePropertyChanged("Head_of_Household");
			}
		}

		[XmlIgnore]
		public bool Head_of_HouseholdSpecified
		{
			get
			{
				return this.head_of_HouseholdFieldSpecified;
			}
			set
			{
				this.head_of_HouseholdFieldSpecified = value;
				this.RaisePropertyChanged("Head_of_HouseholdSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Number_of_Dependents
		{
			get
			{
				return this.number_of_DependentsField;
			}
			set
			{
				this.number_of_DependentsField = value;
				this.RaisePropertyChanged("Number_of_Dependents");
			}
		}

		[XmlIgnore]
		public bool Number_of_DependentsSpecified
		{
			get
			{
				return this.number_of_DependentsFieldSpecified;
			}
			set
			{
				this.number_of_DependentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_DependentsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Worker_is_Laborer_or_Mechanic
		{
			get
			{
				return this.worker_is_Laborer_or_MechanicField;
			}
			set
			{
				this.worker_is_Laborer_or_MechanicField = value;
				this.RaisePropertyChanged("Worker_is_Laborer_or_Mechanic");
			}
		}

		[XmlIgnore]
		public bool Worker_is_Laborer_or_MechanicSpecified
		{
			get
			{
				return this.worker_is_Laborer_or_MechanicFieldSpecified;
			}
			set
			{
				this.worker_is_Laborer_or_MechanicFieldSpecified = value;
				this.RaisePropertyChanged("Worker_is_Laborer_or_MechanicSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Good_Cause_Limit_Percent
		{
			get
			{
				return this.good_Cause_Limit_PercentField;
			}
			set
			{
				this.good_Cause_Limit_PercentField = value;
				this.RaisePropertyChanged("Good_Cause_Limit_Percent");
			}
		}

		[XmlIgnore]
		public bool Good_Cause_Limit_PercentSpecified
		{
			get
			{
				return this.good_Cause_Limit_PercentFieldSpecified;
			}
			set
			{
				this.good_Cause_Limit_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Good_Cause_Limit_PercentSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Expected_Annual_Earnings
		{
			get
			{
				return this.expected_Annual_EarningsField;
			}
			set
			{
				this.expected_Annual_EarningsField = value;
				this.RaisePropertyChanged("Expected_Annual_Earnings");
			}
		}

		[XmlIgnore]
		public bool Expected_Annual_EarningsSpecified
		{
			get
			{
				return this.expected_Annual_EarningsFieldSpecified;
			}
			set
			{
				this.expected_Annual_EarningsFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Annual_EarningsSpecified");
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
