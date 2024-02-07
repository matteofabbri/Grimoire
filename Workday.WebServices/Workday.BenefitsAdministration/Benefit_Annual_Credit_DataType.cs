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
	public class Benefit_Annual_Credit_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private WorkerObjectType worker_ReferenceField;

		private decimal benefit_Annual_CreditField;

		private bool benefit_Annual_CreditFieldSpecified;

		private CurrencyObjectType benefit_Annual_Credit_Currency_ReferenceField;

		private Benefit_Annual_Credit_TypeObjectType benefit_Annual_Credit_Type_ReferenceField;

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
		public decimal Benefit_Annual_Credit
		{
			get
			{
				return this.benefit_Annual_CreditField;
			}
			set
			{
				this.benefit_Annual_CreditField = value;
				this.RaisePropertyChanged("Benefit_Annual_Credit");
			}
		}

		[XmlIgnore]
		public bool Benefit_Annual_CreditSpecified
		{
			get
			{
				return this.benefit_Annual_CreditFieldSpecified;
			}
			set
			{
				this.benefit_Annual_CreditFieldSpecified = value;
				this.RaisePropertyChanged("Benefit_Annual_CreditSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Benefit_Annual_Credit_Currency_Reference
		{
			get
			{
				return this.benefit_Annual_Credit_Currency_ReferenceField;
			}
			set
			{
				this.benefit_Annual_Credit_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Annual_Credit_Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Benefit_Annual_Credit_TypeObjectType Benefit_Annual_Credit_Type_Reference
		{
			get
			{
				return this.benefit_Annual_Credit_Type_ReferenceField;
			}
			set
			{
				this.benefit_Annual_Credit_Type_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Annual_Credit_Type_Reference");
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
