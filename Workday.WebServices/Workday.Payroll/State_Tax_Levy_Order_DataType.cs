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
	public class State_Tax_Levy_Order_DataType : INotifyPropertyChanged
	{
		private decimal number_of_DependentsField;

		private bool number_of_DependentsFieldSpecified;

		private bool worker_is_Laborer_or_MechanicField;

		private bool worker_is_Laborer_or_MechanicFieldSpecified;

		private State_Tax_Levy_Federal_DataType state_Tax_Levy_Federal_DataField;

		private Federal_Tax_Levy_Dependent_ReferenceType[] state_Tax_Levy_Dependant_ReferenceField;

		private decimal good_Cause_Limit_PercentField;

		private bool good_Cause_Limit_PercentFieldSpecified;

		private Withholding_Order_Override_Completion_CriteriaObjectType process_Until_ReferenceField;

		private DateTime prorate_Until_DateField;

		private bool prorate_Until_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public State_Tax_Levy_Federal_DataType State_Tax_Levy_Federal_Data
		{
			get
			{
				return this.state_Tax_Levy_Federal_DataField;
			}
			set
			{
				this.state_Tax_Levy_Federal_DataField = value;
				this.RaisePropertyChanged("State_Tax_Levy_Federal_Data");
			}
		}

		[XmlElement("State_Tax_Levy_Dependant_Reference", Order = 3)]
		public Federal_Tax_Levy_Dependent_ReferenceType[] State_Tax_Levy_Dependant_Reference
		{
			get
			{
				return this.state_Tax_Levy_Dependant_ReferenceField;
			}
			set
			{
				this.state_Tax_Levy_Dependant_ReferenceField = value;
				this.RaisePropertyChanged("State_Tax_Levy_Dependant_Reference");
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
		public Withholding_Order_Override_Completion_CriteriaObjectType Process_Until_Reference
		{
			get
			{
				return this.process_Until_ReferenceField;
			}
			set
			{
				this.process_Until_ReferenceField = value;
				this.RaisePropertyChanged("Process_Until_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Prorate_Until_Date
		{
			get
			{
				return this.prorate_Until_DateField;
			}
			set
			{
				this.prorate_Until_DateField = value;
				this.RaisePropertyChanged("Prorate_Until_Date");
			}
		}

		[XmlIgnore]
		public bool Prorate_Until_DateSpecified
		{
			get
			{
				return this.prorate_Until_DateFieldSpecified;
			}
			set
			{
				this.prorate_Until_DateFieldSpecified = value;
				this.RaisePropertyChanged("Prorate_Until_DateSpecified");
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
