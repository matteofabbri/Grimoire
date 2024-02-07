using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_Bonus_Payment_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime effective_DateField;

		private DateTime bonus_Compensation_Snapshot_DateField;

		private bool bonus_Compensation_Snapshot_DateFieldSpecified;

		private Eligible_Earnings_Override_PeriodObjectType eligible_Earnings_Override_Period_ReferenceField;

		private Event_Classification_SubcategoryObjectType bonus_Reason_ReferenceField;

		private Bonus_Payment_DataType bonus_Payment_DataField;

		private bool ignore_Plan_AssignmentField;

		private bool ignore_Plan_AssignmentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
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

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Bonus_Compensation_Snapshot_Date
		{
			get
			{
				return this.bonus_Compensation_Snapshot_DateField;
			}
			set
			{
				this.bonus_Compensation_Snapshot_DateField = value;
				this.RaisePropertyChanged("Bonus_Compensation_Snapshot_Date");
			}
		}

		[XmlIgnore]
		public bool Bonus_Compensation_Snapshot_DateSpecified
		{
			get
			{
				return this.bonus_Compensation_Snapshot_DateFieldSpecified;
			}
			set
			{
				this.bonus_Compensation_Snapshot_DateFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_Compensation_Snapshot_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Eligible_Earnings_Override_PeriodObjectType Eligible_Earnings_Override_Period_Reference
		{
			get
			{
				return this.eligible_Earnings_Override_Period_ReferenceField;
			}
			set
			{
				this.eligible_Earnings_Override_Period_ReferenceField = value;
				this.RaisePropertyChanged("Eligible_Earnings_Override_Period_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Event_Classification_SubcategoryObjectType Bonus_Reason_Reference
		{
			get
			{
				return this.bonus_Reason_ReferenceField;
			}
			set
			{
				this.bonus_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Reason_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Bonus_Payment_DataType Bonus_Payment_Data
		{
			get
			{
				return this.bonus_Payment_DataField;
			}
			set
			{
				this.bonus_Payment_DataField = value;
				this.RaisePropertyChanged("Bonus_Payment_Data");
			}
		}

		[XmlElement(Order = 7)]
		public bool Ignore_Plan_Assignment
		{
			get
			{
				return this.ignore_Plan_AssignmentField;
			}
			set
			{
				this.ignore_Plan_AssignmentField = value;
				this.RaisePropertyChanged("Ignore_Plan_Assignment");
			}
		}

		[XmlIgnore]
		public bool Ignore_Plan_AssignmentSpecified
		{
			get
			{
				return this.ignore_Plan_AssignmentFieldSpecified;
			}
			set
			{
				this.ignore_Plan_AssignmentFieldSpecified = value;
				this.RaisePropertyChanged("Ignore_Plan_AssignmentSpecified");
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
