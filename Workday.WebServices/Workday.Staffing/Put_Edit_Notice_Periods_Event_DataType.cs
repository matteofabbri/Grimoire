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
	public class Put_Edit_Notice_Periods_Event_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private DateTime effective_DateField;

		private Employer_Notice_Period_DataType employer_Notice_Period_DataField;

		private Employee_Notice_Period_DataType employee_Notice_Period_DataField;

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

		[XmlElement(Order = 2)]
		public Employer_Notice_Period_DataType Employer_Notice_Period_Data
		{
			get
			{
				return this.employer_Notice_Period_DataField;
			}
			set
			{
				this.employer_Notice_Period_DataField = value;
				this.RaisePropertyChanged("Employer_Notice_Period_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_Notice_Period_DataType Employee_Notice_Period_Data
		{
			get
			{
				return this.employee_Notice_Period_DataField;
			}
			set
			{
				this.employee_Notice_Period_DataField = value;
				this.RaisePropertyChanged("Employee_Notice_Period_Data");
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
