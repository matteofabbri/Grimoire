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
	public class Additional_DataType : INotifyPropertyChanged
	{
		private bool statutory_EmployeeField;

		private bool statutory_EmployeeFieldSpecified;

		private bool retirement_PlanField;

		private bool retirement_PlanFieldSpecified;

		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Statutory_Employee
		{
			get
			{
				return this.statutory_EmployeeField;
			}
			set
			{
				this.statutory_EmployeeField = value;
				this.RaisePropertyChanged("Statutory_Employee");
			}
		}

		[XmlIgnore]
		public bool Statutory_EmployeeSpecified
		{
			get
			{
				return this.statutory_EmployeeFieldSpecified;
			}
			set
			{
				this.statutory_EmployeeFieldSpecified = value;
				this.RaisePropertyChanged("Statutory_EmployeeSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Retirement_Plan
		{
			get
			{
				return this.retirement_PlanField;
			}
			set
			{
				this.retirement_PlanField = value;
				this.RaisePropertyChanged("Retirement_Plan");
			}
		}

		[XmlIgnore]
		public bool Retirement_PlanSpecified
		{
			get
			{
				return this.retirement_PlanFieldSpecified;
			}
			set
			{
				this.retirement_PlanFieldSpecified = value;
				this.RaisePropertyChanged("Retirement_PlanSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Third_Party_Sick_Pay
		{
			get
			{
				return this.third_Party_Sick_PayField;
			}
			set
			{
				this.third_Party_Sick_PayField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_PaySpecified
		{
			get
			{
				return this.third_Party_Sick_PayFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_PayFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_PaySpecified");
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
