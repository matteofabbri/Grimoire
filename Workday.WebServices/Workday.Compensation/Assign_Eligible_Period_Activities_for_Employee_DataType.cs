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
	public class Assign_Eligible_Period_Activities_for_Employee_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime eligible_Activity_DateField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Period_Activity_Eligibility_Entry_DataType[] eligible_Period_Activities_Sub_DataField;

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
		public DateTime Eligible_Activity_Date
		{
			get
			{
				return this.eligible_Activity_DateField;
			}
			set
			{
				this.eligible_Activity_DateField = value;
				this.RaisePropertyChanged("Eligible_Activity_Date");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Eligible_Period_Activities_Sub_Data", Order = 4)]
		public Period_Activity_Eligibility_Entry_DataType[] Eligible_Period_Activities_Sub_Data
		{
			get
			{
				return this.eligible_Period_Activities_Sub_DataField;
			}
			set
			{
				this.eligible_Period_Activities_Sub_DataField = value;
				this.RaisePropertyChanged("Eligible_Period_Activities_Sub_Data");
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
