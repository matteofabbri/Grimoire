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
	public class Position_Future_Payment_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime assignment_DateField;

		private bool assignment_DateFieldSpecified;

		private Future_Payment_Plan_Assignment_DataType[] future_Payment_Plan_Assignment_DataField;

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
		public DateTime Assignment_Date
		{
			get
			{
				return this.assignment_DateField;
			}
			set
			{
				this.assignment_DateField = value;
				this.RaisePropertyChanged("Assignment_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_DateSpecified
		{
			get
			{
				return this.assignment_DateFieldSpecified;
			}
			set
			{
				this.assignment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_DateSpecified");
			}
		}

		[XmlElement("Future_Payment_Plan_Assignment_Data", Order = 3)]
		public Future_Payment_Plan_Assignment_DataType[] Future_Payment_Plan_Assignment_Data
		{
			get
			{
				return this.future_Payment_Plan_Assignment_DataField;
			}
			set
			{
				this.future_Payment_Plan_Assignment_DataField = value;
				this.RaisePropertyChanged("Future_Payment_Plan_Assignment_Data");
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
