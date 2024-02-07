using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Probation_Period_Detail_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType employee_Probation_Period_Event_ReferenceField;

		private Employee_Probation_PeriodObjectType employee_Probation_Period_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Employee_Probation_Period_TypeObjectType probation_Type_ReferenceField;

		private Employee_Probation_Period_ReasonObjectType probation_Reason_ReferenceField;

		private DateTime extended_End_DateField;

		private bool extended_End_DateFieldSpecified;

		private string noteField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Employee_Probation_Period_Event_Reference
		{
			get
			{
				return this.employee_Probation_Period_Event_ReferenceField;
			}
			set
			{
				this.employee_Probation_Period_Event_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Probation_Period_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Probation_PeriodObjectType Employee_Probation_Period_Reference
		{
			get
			{
				return this.employee_Probation_Period_ReferenceField;
			}
			set
			{
				this.employee_Probation_Period_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Probation_Period_Reference");
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

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Employee_Probation_Period_TypeObjectType Probation_Type_Reference
		{
			get
			{
				return this.probation_Type_ReferenceField;
			}
			set
			{
				this.probation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Probation_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Employee_Probation_Period_ReasonObjectType Probation_Reason_Reference
		{
			get
			{
				return this.probation_Reason_ReferenceField;
			}
			set
			{
				this.probation_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Probation_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Extended_End_Date
		{
			get
			{
				return this.extended_End_DateField;
			}
			set
			{
				this.extended_End_DateField = value;
				this.RaisePropertyChanged("Extended_End_Date");
			}
		}

		[XmlIgnore]
		public bool Extended_End_DateSpecified
		{
			get
			{
				return this.extended_End_DateFieldSpecified;
			}
			set
			{
				this.extended_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Extended_End_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
				this.RaisePropertyChanged("Note");
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
