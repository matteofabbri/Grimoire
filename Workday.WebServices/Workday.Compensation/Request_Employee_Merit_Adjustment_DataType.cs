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
	public class Request_Employee_Merit_Adjustment_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime merit_Increase_Effective_DateField;

		private Merit_Percent_PlanObjectType merit_Plan_ReferenceField;

		private Event_Classification_SubcategoryObjectType merit_Reason_ReferenceField;

		private Employee_Merit_Adjustment_DataType[] employee_Merit_Adjustment_Sub_DataField;

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
		public DateTime Merit_Increase_Effective_Date
		{
			get
			{
				return this.merit_Increase_Effective_DateField;
			}
			set
			{
				this.merit_Increase_Effective_DateField = value;
				this.RaisePropertyChanged("Merit_Increase_Effective_Date");
			}
		}

		[XmlElement(Order = 3)]
		public Merit_Percent_PlanObjectType Merit_Plan_Reference
		{
			get
			{
				return this.merit_Plan_ReferenceField;
			}
			set
			{
				this.merit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Merit_Plan_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Event_Classification_SubcategoryObjectType Merit_Reason_Reference
		{
			get
			{
				return this.merit_Reason_ReferenceField;
			}
			set
			{
				this.merit_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Merit_Reason_Reference");
			}
		}

		[XmlElement("Employee_Merit_Adjustment_Sub_Data", Order = 5)]
		public Employee_Merit_Adjustment_DataType[] Employee_Merit_Adjustment_Sub_Data
		{
			get
			{
				return this.employee_Merit_Adjustment_Sub_DataField;
			}
			set
			{
				this.employee_Merit_Adjustment_Sub_DataField = value;
				this.RaisePropertyChanged("Employee_Merit_Adjustment_Sub_Data");
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
