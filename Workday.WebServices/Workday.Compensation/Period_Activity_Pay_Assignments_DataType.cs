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
	public class Period_Activity_Pay_Assignments_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Period_Activity_Rate_MatrixObjectType period_Activity_Rate_Matrix_ReferenceField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Period_Activity_Pay_Assignment_DataType[] period_Activity_Pay_AssignmentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement("Period_Activity_Pay_Assignment", Order = 6)]
		public Period_Activity_Pay_Assignment_DataType[] Period_Activity_Pay_Assignment
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
