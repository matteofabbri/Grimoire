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
	public class Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_for_Tax_Election_ReferenceField;

		private DateTime effective_DateField;

		private CompanyObjectType company_for_Tax_Election_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_for_Tax_Election_Reference
		{
			get
			{
				return this.worker_for_Tax_Election_ReferenceField;
			}
			set
			{
				this.worker_for_Tax_Election_ReferenceField = value;
				this.RaisePropertyChanged("Worker_for_Tax_Election_Reference");
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
		public CompanyObjectType Company_for_Tax_Election_Reference
		{
			get
			{
				return this.company_for_Tax_Election_ReferenceField;
			}
			set
			{
				this.company_for_Tax_Election_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Tax_Election_Reference");
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
