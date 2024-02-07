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
	public class Put_Worker_Tax_Treaty_Response_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Calendar_YearObjectType tax_Year_ReferenceField;

		private Payroll_Income_CodeObjectType income_Code_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Calendar_YearObjectType Tax_Year_Reference
		{
			get
			{
				return this.tax_Year_ReferenceField;
			}
			set
			{
				this.tax_Year_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Year_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Income_CodeObjectType Income_Code_Reference
		{
			get
			{
				return this.income_Code_ReferenceField;
			}
			set
			{
				this.income_Code_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_Reference");
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
