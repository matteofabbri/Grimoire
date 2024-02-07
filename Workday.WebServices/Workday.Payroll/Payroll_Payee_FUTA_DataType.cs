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
	public class Payroll_Payee_FUTA_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private DateTime effective_As_OfField;

		private bool exempt_IndicatorField;

		private bool exempt_IndicatorFieldSpecified;

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
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
			}
		}

		[XmlElement(Order = 3)]
		public bool Exempt_Indicator
		{
			get
			{
				return this.exempt_IndicatorField;
			}
			set
			{
				this.exempt_IndicatorField = value;
				this.RaisePropertyChanged("Exempt_Indicator");
			}
		}

		[XmlIgnore]
		public bool Exempt_IndicatorSpecified
		{
			get
			{
				return this.exempt_IndicatorFieldSpecified;
			}
			set
			{
				this.exempt_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_IndicatorSpecified");
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
