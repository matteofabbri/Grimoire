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
	public class Notice_Period_Line_Data__old_Type : INotifyPropertyChanged
	{
		private string orderField;

		private Condition_RuleObjectType notice_Period_Eligibility_Rule_ReferenceField;

		private bool has_Notice_PeriodField;

		private bool has_Notice_PeriodFieldSpecified;

		private bool for_EmployerField;

		private bool for_EmployerFieldSpecified;

		private bool for__Employee_Field;

		private bool for__Employee_FieldSpecified;

		private decimal durationField;

		private bool durationFieldSpecified;

		private Unique_IdentifierObjectType date_and_Time_Unit_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Condition_RuleObjectType Notice_Period_Eligibility_Rule_Reference
		{
			get
			{
				return this.notice_Period_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.notice_Period_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Has_Notice_Period
		{
			get
			{
				return this.has_Notice_PeriodField;
			}
			set
			{
				this.has_Notice_PeriodField = value;
				this.RaisePropertyChanged("Has_Notice_Period");
			}
		}

		[XmlIgnore]
		public bool Has_Notice_PeriodSpecified
		{
			get
			{
				return this.has_Notice_PeriodFieldSpecified;
			}
			set
			{
				this.has_Notice_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Has_Notice_PeriodSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool For_Employer
		{
			get
			{
				return this.for_EmployerField;
			}
			set
			{
				this.for_EmployerField = value;
				this.RaisePropertyChanged("For_Employer");
			}
		}

		[XmlIgnore]
		public bool For_EmployerSpecified
		{
			get
			{
				return this.for_EmployerFieldSpecified;
			}
			set
			{
				this.for_EmployerFieldSpecified = value;
				this.RaisePropertyChanged("For_EmployerSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool For__Employee_
		{
			get
			{
				return this.for__Employee_Field;
			}
			set
			{
				this.for__Employee_Field = value;
				this.RaisePropertyChanged("For__Employee_");
			}
		}

		[XmlIgnore]
		public bool For__Employee_Specified
		{
			get
			{
				return this.for__Employee_FieldSpecified;
			}
			set
			{
				this.for__Employee_FieldSpecified = value;
				this.RaisePropertyChanged("For__Employee_Specified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				this.RaisePropertyChanged("Duration");
			}
		}

		[XmlIgnore]
		public bool DurationSpecified
		{
			get
			{
				return this.durationFieldSpecified;
			}
			set
			{
				this.durationFieldSpecified = value;
				this.RaisePropertyChanged("DurationSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Unique_IdentifierObjectType Date_and_Time_Unit_Reference
		{
			get
			{
				return this.date_and_Time_Unit_ReferenceField;
			}
			set
			{
				this.date_and_Time_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Date_and_Time_Unit_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
