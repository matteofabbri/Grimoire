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
	public class State_Tax_Levy_Federal_DataType : INotifyPropertyChanged
	{
		private DateTime part_3_Effective_DateField;

		private bool part_3_Effective_DateFieldSpecified;

		private decimal pay_Period_Exemption_Override_AmountField;

		private bool pay_Period_Exemption_Override_AmountFieldSpecified;

		private Payroll_Marital_Status_ReferenceType payroll_Marital_Status_ReferenceField;

		private decimal personal_ExemptionsField;

		private bool personal_ExemptionsFieldSpecified;

		private decimal additional_65__or_Blind_ExemptionsField;

		private bool additional_65__or_Blind_ExemptionsFieldSpecified;

		private DateTime termination_DateField;

		private bool termination_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Part_3_Effective_Date
		{
			get
			{
				return this.part_3_Effective_DateField;
			}
			set
			{
				this.part_3_Effective_DateField = value;
				this.RaisePropertyChanged("Part_3_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Part_3_Effective_DateSpecified
		{
			get
			{
				return this.part_3_Effective_DateFieldSpecified;
			}
			set
			{
				this.part_3_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Part_3_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Pay_Period_Exemption_Override_Amount
		{
			get
			{
				return this.pay_Period_Exemption_Override_AmountField;
			}
			set
			{
				this.pay_Period_Exemption_Override_AmountField = value;
				this.RaisePropertyChanged("Pay_Period_Exemption_Override_Amount");
			}
		}

		[XmlIgnore]
		public bool Pay_Period_Exemption_Override_AmountSpecified
		{
			get
			{
				return this.pay_Period_Exemption_Override_AmountFieldSpecified;
			}
			set
			{
				this.pay_Period_Exemption_Override_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Period_Exemption_Override_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Marital_Status_ReferenceType Payroll_Marital_Status_Reference
		{
			get
			{
				return this.payroll_Marital_Status_ReferenceField;
			}
			set
			{
				this.payroll_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Personal_Exemptions
		{
			get
			{
				return this.personal_ExemptionsField;
			}
			set
			{
				this.personal_ExemptionsField = value;
				this.RaisePropertyChanged("Personal_Exemptions");
			}
		}

		[XmlIgnore]
		public bool Personal_ExemptionsSpecified
		{
			get
			{
				return this.personal_ExemptionsFieldSpecified;
			}
			set
			{
				this.personal_ExemptionsFieldSpecified = value;
				this.RaisePropertyChanged("Personal_ExemptionsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Additional_65__or_Blind_Exemptions
		{
			get
			{
				return this.additional_65__or_Blind_ExemptionsField;
			}
			set
			{
				this.additional_65__or_Blind_ExemptionsField = value;
				this.RaisePropertyChanged("Additional_65__or_Blind_Exemptions");
			}
		}

		[XmlIgnore]
		public bool Additional_65__or_Blind_ExemptionsSpecified
		{
			get
			{
				return this.additional_65__or_Blind_ExemptionsFieldSpecified;
			}
			set
			{
				this.additional_65__or_Blind_ExemptionsFieldSpecified = value;
				this.RaisePropertyChanged("Additional_65__or_Blind_ExemptionsSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Termination_Date
		{
			get
			{
				return this.termination_DateField;
			}
			set
			{
				this.termination_DateField = value;
				this.RaisePropertyChanged("Termination_Date");
			}
		}

		[XmlIgnore]
		public bool Termination_DateSpecified
		{
			get
			{
				return this.termination_DateFieldSpecified;
			}
			set
			{
				this.termination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Termination_DateSpecified");
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
