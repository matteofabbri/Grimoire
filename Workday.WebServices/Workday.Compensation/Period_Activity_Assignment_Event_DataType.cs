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
	public class Period_Activity_Assignment_Event_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType period_Activity_Assignment_Event_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private EmployeeObjectType employee__ReferenceField;

		private PositionObjectType position_ReferenceField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Period_Activity_Rate_MatrixObjectType period_Activity_Rate_Matrix_ReferenceField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Period_Activity_Assignment_Version_DataType[] period_Activity_Pay_AssignmentField;

		private Period_Activity_Assignment_Deleted_DataType[] period_Activity_Pay_Assignment_RemovedField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Period_Activity_Assignment_Event_Reference
		{
			get
			{
				return this.period_Activity_Assignment_Event_ReferenceField;
			}
			set
			{
				this.period_Activity_Assignment_Event_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Assignment_Event_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
		public EmployeeObjectType Employee__Reference
		{
			get
			{
				return this.employee__ReferenceField;
			}
			set
			{
				this.employee__ReferenceField = value;
				this.RaisePropertyChanged("Employee__Reference");
			}
		}

		[XmlElement(Order = 3)]
		public PositionObjectType Position_Reference
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

		[XmlElement(Order = 4)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Period_Activity_Rate_MatrixObjectType Period_Activity_Rate_Matrix_Reference
		{
			get
			{
				return this.period_Activity_Rate_Matrix_ReferenceField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement("Period_Activity_Pay_Assignment", Order = 7)]
		public Period_Activity_Assignment_Version_DataType[] Period_Activity_Pay_Assignment
		{
			get
			{
				return this.period_Activity_Pay_AssignmentField;
			}
			set
			{
				this.period_Activity_Pay_AssignmentField = value;
				this.RaisePropertyChanged("Period_Activity_Pay_Assignment");
			}
		}

		[XmlElement("Period_Activity_Pay_Assignment_Removed", Order = 8)]
		public Period_Activity_Assignment_Deleted_DataType[] Period_Activity_Pay_Assignment_Removed
		{
			get
			{
				return this.period_Activity_Pay_Assignment_RemovedField;
			}
			set
			{
				this.period_Activity_Pay_Assignment_RemovedField = value;
				this.RaisePropertyChanged("Period_Activity_Pay_Assignment_Removed");
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
