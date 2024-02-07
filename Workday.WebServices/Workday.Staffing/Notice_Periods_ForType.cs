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
	public class Notice_Periods_ForType : INotifyPropertyChanged
	{
		private bool employerField;

		private bool employerFieldSpecified;

		private bool employeeField;

		private bool employeeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Employer
		{
			get
			{
				return this.employerField;
			}
			set
			{
				this.employerField = value;
				this.RaisePropertyChanged("Employer");
			}
		}

		[XmlIgnore]
		public bool EmployerSpecified
		{
			get
			{
				return this.employerFieldSpecified;
			}
			set
			{
				this.employerFieldSpecified = value;
				this.RaisePropertyChanged("EmployerSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Employee
		{
			get
			{
				return this.employeeField;
			}
			set
			{
				this.employeeField = value;
				this.RaisePropertyChanged("Employee");
			}
		}

		[XmlIgnore]
		public bool EmployeeSpecified
		{
			get
			{
				return this.employeeFieldSpecified;
			}
			set
			{
				this.employeeFieldSpecified = value;
				this.RaisePropertyChanged("EmployeeSpecified");
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
