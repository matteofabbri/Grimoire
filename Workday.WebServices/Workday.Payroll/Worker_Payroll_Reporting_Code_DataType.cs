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
	public class Worker_Payroll_Reporting_Code_DataType : INotifyPropertyChanged
	{
		private Payroll_Reporting_TypeObjectType payroll_Reporting_Type_ReferenceField;

		private string payroll_Reporting_CodeField;

		private string formatted_Payroll_Reporting_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Reporting_TypeObjectType Payroll_Reporting_Type_Reference
		{
			get
			{
				return this.payroll_Reporting_Type_ReferenceField;
			}
			set
			{
				this.payroll_Reporting_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Reporting_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Payroll_Reporting_Code
		{
			get
			{
				return this.payroll_Reporting_CodeField;
			}
			set
			{
				this.payroll_Reporting_CodeField = value;
				this.RaisePropertyChanged("Payroll_Reporting_Code");
			}
		}

		[XmlElement(Order = 2)]
		public string Formatted_Payroll_Reporting_Code
		{
			get
			{
				return this.formatted_Payroll_Reporting_CodeField;
			}
			set
			{
				this.formatted_Payroll_Reporting_CodeField = value;
				this.RaisePropertyChanged("Formatted_Payroll_Reporting_Code");
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
