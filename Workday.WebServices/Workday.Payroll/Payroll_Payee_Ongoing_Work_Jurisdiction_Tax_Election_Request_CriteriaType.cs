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
	public class Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request_CriteriaType : INotifyPropertyChanged
	{
		private WorkerObjectType[] worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private DateTime effective_as_OfField;

		private bool effective_as_OfFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Reference", Order = 0)]
		public WorkerObjectType[] Worker_Reference
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
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Effective_as_Of
		{
			get
			{
				return this.effective_as_OfField;
			}
			set
			{
				this.effective_as_OfField = value;
				this.RaisePropertyChanged("Effective_as_Of");
			}
		}

		[XmlIgnore]
		public bool Effective_as_OfSpecified
		{
			get
			{
				return this.effective_as_OfFieldSpecified;
			}
			set
			{
				this.effective_as_OfFieldSpecified = value;
				this.RaisePropertyChanged("Effective_as_OfSpecified");
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
