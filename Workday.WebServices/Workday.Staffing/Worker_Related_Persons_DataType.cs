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
	public class Worker_Related_Persons_DataType : INotifyPropertyChanged
	{
		private decimal number_of_Payroll_DependentsField;

		private bool number_of_Payroll_DependentsFieldSpecified;

		private Related_PersonType[] related_PersonField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Number_of_Payroll_Dependents
		{
			get
			{
				return this.number_of_Payroll_DependentsField;
			}
			set
			{
				this.number_of_Payroll_DependentsField = value;
				this.RaisePropertyChanged("Number_of_Payroll_Dependents");
			}
		}

		[XmlIgnore]
		public bool Number_of_Payroll_DependentsSpecified
		{
			get
			{
				return this.number_of_Payroll_DependentsFieldSpecified;
			}
			set
			{
				this.number_of_Payroll_DependentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Payroll_DependentsSpecified");
			}
		}

		[XmlElement("Related_Person", Order = 1)]
		public Related_PersonType[] Related_Person
		{
			get
			{
				return this.related_PersonField;
			}
			set
			{
				this.related_PersonField = value;
				this.RaisePropertyChanged("Related_Person");
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
