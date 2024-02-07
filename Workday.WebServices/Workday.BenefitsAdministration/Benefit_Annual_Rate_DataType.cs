using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Annual_Rate_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private WorkerObjectType worker_ReferenceField;

		private decimal benefit_Annual_RateField;

		private bool benefit_Annual_RateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Benefit_Annual_Rate_TypeObjectType benefit_Annual_Rate_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Benefit_Annual_Rate
		{
			get
			{
				return this.benefit_Annual_RateField;
			}
			set
			{
				this.benefit_Annual_RateField = value;
				this.RaisePropertyChanged("Benefit_Annual_Rate");
			}
		}

		[XmlIgnore]
		public bool Benefit_Annual_RateSpecified
		{
			get
			{
				return this.benefit_Annual_RateFieldSpecified;
			}
			set
			{
				this.benefit_Annual_RateFieldSpecified = value;
				this.RaisePropertyChanged("Benefit_Annual_RateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Benefit_Annual_Rate_TypeObjectType Benefit_Annual_Rate_Type_Reference
		{
			get
			{
				return this.benefit_Annual_Rate_Type_ReferenceField;
			}
			set
			{
				this.benefit_Annual_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Annual_Rate_Type_Reference");
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
