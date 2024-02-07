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
	public class Federal_Student_Loan_Specific_DataType : INotifyPropertyChanged
	{
		private bool department_of_Education_Student_LoanField;

		private bool department_of_Education_Student_LoanFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Department_of_Education_Student_Loan
		{
			get
			{
				return this.department_of_Education_Student_LoanField;
			}
			set
			{
				this.department_of_Education_Student_LoanField = value;
				this.RaisePropertyChanged("Department_of_Education_Student_Loan");
			}
		}

		[XmlIgnore]
		public bool Department_of_Education_Student_LoanSpecified
		{
			get
			{
				return this.department_of_Education_Student_LoanFieldSpecified;
			}
			set
			{
				this.department_of_Education_Student_LoanFieldSpecified = value;
				this.RaisePropertyChanged("Department_of_Education_Student_LoanSpecified");
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
