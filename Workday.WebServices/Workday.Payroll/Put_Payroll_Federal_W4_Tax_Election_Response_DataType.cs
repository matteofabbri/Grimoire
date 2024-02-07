using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Payroll_Federal_W-4_Tax_Election_Response_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Federal_W4_Tax_Election_Response_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_as_ofField;

		private CompanyObjectType company_for_Payroll_Payee_Tax_Data_ReferenceField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_as_of
		{
			get
			{
				return this.effective_as_ofField;
			}
			set
			{
				this.effective_as_ofField = value;
				this.RaisePropertyChanged("Effective_as_of");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_for_Payroll_Payee_Tax_Data_Reference
		{
			get
			{
				return this.company_for_Payroll_Payee_Tax_Data_ReferenceField;
			}
			set
			{
				this.company_for_Payroll_Payee_Tax_Data_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Payroll_Payee_Tax_Data_Reference");
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
