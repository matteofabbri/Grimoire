using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Lease_Supplier_Contract_Details_DataType : INotifyPropertyChanged
	{
		private decimal lease_TermField;

		private bool lease_TermFieldSpecified;

		private Frequency_BehaviorObjectType compound_Period_ReferenceField;

		private Frequency_BehaviorObjectType payment_Frequency_ReferenceField;

		private decimal implicit_RateField;

		private decimal number_of_PaymentsField;

		private bool number_of_PaymentsFieldSpecified;

		private decimal total_PrincipalField;

		private bool total_PrincipalFieldSpecified;

		private decimal total_InterestField;

		private bool total_InterestFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Lease_Term
		{
			get
			{
				return this.lease_TermField;
			}
			set
			{
				this.lease_TermField = value;
				this.RaisePropertyChanged("Lease_Term");
			}
		}

		[XmlIgnore]
		public bool Lease_TermSpecified
		{
			get
			{
				return this.lease_TermFieldSpecified;
			}
			set
			{
				this.lease_TermFieldSpecified = value;
				this.RaisePropertyChanged("Lease_TermSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Frequency_BehaviorObjectType Compound_Period_Reference
		{
			get
			{
				return this.compound_Period_ReferenceField;
			}
			set
			{
				this.compound_Period_ReferenceField = value;
				this.RaisePropertyChanged("Compound_Period_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Frequency_BehaviorObjectType Payment_Frequency_Reference
		{
			get
			{
				return this.payment_Frequency_ReferenceField;
			}
			set
			{
				this.payment_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Frequency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Implicit_Rate
		{
			get
			{
				return this.implicit_RateField;
			}
			set
			{
				this.implicit_RateField = value;
				this.RaisePropertyChanged("Implicit_Rate");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Number_of_Payments
		{
			get
			{
				return this.number_of_PaymentsField;
			}
			set
			{
				this.number_of_PaymentsField = value;
				this.RaisePropertyChanged("Number_of_Payments");
			}
		}

		[XmlIgnore]
		public bool Number_of_PaymentsSpecified
		{
			get
			{
				return this.number_of_PaymentsFieldSpecified;
			}
			set
			{
				this.number_of_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Total_Principal
		{
			get
			{
				return this.total_PrincipalField;
			}
			set
			{
				this.total_PrincipalField = value;
				this.RaisePropertyChanged("Total_Principal");
			}
		}

		[XmlIgnore]
		public bool Total_PrincipalSpecified
		{
			get
			{
				return this.total_PrincipalFieldSpecified;
			}
			set
			{
				this.total_PrincipalFieldSpecified = value;
				this.RaisePropertyChanged("Total_PrincipalSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Total_Interest
		{
			get
			{
				return this.total_InterestField;
			}
			set
			{
				this.total_InterestField = value;
				this.RaisePropertyChanged("Total_Interest");
			}
		}

		[XmlIgnore]
		public bool Total_InterestSpecified
		{
			get
			{
				return this.total_InterestFieldSpecified;
			}
			set
			{
				this.total_InterestFieldSpecified = value;
				this.RaisePropertyChanged("Total_InterestSpecified");
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
