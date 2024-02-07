using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Allowance_Plan_Percent_DataType : INotifyPropertyChanged
	{
		private decimal percentageField;

		private bool percentageFieldSpecified;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		private decimal ceiling_AmountField;

		private bool ceiling_AmountFieldSpecified;

		private CurrencyObjectType ceiling_Currency_ReferenceField;

		private Allowance_Plan_Percent_Based_Profile_Replacement_DataType[] allowance_Plan_Percent_Based_Profile_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
				this.RaisePropertyChanged("Percentage");
			}
		}

		[XmlIgnore]
		public bool PercentageSpecified
		{
			get
			{
				return this.percentageFieldSpecified;
			}
			set
			{
				this.percentageFieldSpecified = value;
				this.RaisePropertyChanged("PercentageSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_BasisObjectType Compensation_Basis_Reference
		{
			get
			{
				return this.compensation_Basis_ReferenceField;
			}
			set
			{
				this.compensation_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Basis_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Ceiling_Amount
		{
			get
			{
				return this.ceiling_AmountField;
			}
			set
			{
				this.ceiling_AmountField = value;
				this.RaisePropertyChanged("Ceiling_Amount");
			}
		}

		[XmlIgnore]
		public bool Ceiling_AmountSpecified
		{
			get
			{
				return this.ceiling_AmountFieldSpecified;
			}
			set
			{
				this.ceiling_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Ceiling_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Ceiling_Currency_Reference
		{
			get
			{
				return this.ceiling_Currency_ReferenceField;
			}
			set
			{
				this.ceiling_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Ceiling_Currency_Reference");
			}
		}

		[XmlElement("Allowance_Plan_Percent_Based_Profile_Replacement_Data", Order = 4)]
		public Allowance_Plan_Percent_Based_Profile_Replacement_DataType[] Allowance_Plan_Percent_Based_Profile_Replacement_Data
		{
			get
			{
				return this.allowance_Plan_Percent_Based_Profile_Replacement_DataField;
			}
			set
			{
				this.allowance_Plan_Percent_Based_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_Percent_Based_Profile_Replacement_Data");
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
