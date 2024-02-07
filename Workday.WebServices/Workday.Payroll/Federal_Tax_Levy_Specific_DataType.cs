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
	public class Federal_Tax_Levy_Specific_DataType : INotifyPropertyChanged
	{
		private DateTime tax_Levy_Signed_Part_3_DateField;

		private bool tax_Levy_Signed_Part_3_DateFieldSpecified;

		private Payroll_Marital_Status_ReferenceType[] payroll_Marital_Status_ReferenceField;

		private decimal personal_ExemptionsField;

		private bool personal_ExemptionsFieldSpecified;

		private decimal additional_Exemptions_65_or_BlindField;

		private bool additional_Exemptions_65_or_BlindFieldSpecified;

		private decimal exemption_Amount_OverrideField;

		private bool exemption_Amount_OverrideFieldSpecified;

		private FrequencyObjectType exemption_Frequency_ReferenceField;

		private DateTime tax_Levy_Termination_DateField;

		private bool tax_Levy_Termination_DateFieldSpecified;

		private Federal_Tax_Levy_Dependent_ReferenceType[] federal_Tax_Levy_Dependent_ReferenceField;

		private bool lock_Tax_ElectionsField;

		private bool lock_Tax_ElectionsFieldSpecified;

		private bool load_Baseline_RestrictionsField;

		private bool load_Baseline_RestrictionsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Tax_Levy_Signed_Part_3_Date
		{
			get
			{
				return this.tax_Levy_Signed_Part_3_DateField;
			}
			set
			{
				this.tax_Levy_Signed_Part_3_DateField = value;
				this.RaisePropertyChanged("Tax_Levy_Signed_Part_3_Date");
			}
		}

		[XmlIgnore]
		public bool Tax_Levy_Signed_Part_3_DateSpecified
		{
			get
			{
				return this.tax_Levy_Signed_Part_3_DateFieldSpecified;
			}
			set
			{
				this.tax_Levy_Signed_Part_3_DateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_Levy_Signed_Part_3_DateSpecified");
			}
		}

		[XmlElement("Payroll_Marital_Status_Reference", Order = 1)]
		public Payroll_Marital_Status_ReferenceType[] Payroll_Marital_Status_Reference
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Additional_Exemptions_65_or_Blind
		{
			get
			{
				return this.additional_Exemptions_65_or_BlindField;
			}
			set
			{
				this.additional_Exemptions_65_or_BlindField = value;
				this.RaisePropertyChanged("Additional_Exemptions_65_or_Blind");
			}
		}

		[XmlIgnore]
		public bool Additional_Exemptions_65_or_BlindSpecified
		{
			get
			{
				return this.additional_Exemptions_65_or_BlindFieldSpecified;
			}
			set
			{
				this.additional_Exemptions_65_or_BlindFieldSpecified = value;
				this.RaisePropertyChanged("Additional_Exemptions_65_or_BlindSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Exemption_Amount_Override
		{
			get
			{
				return this.exemption_Amount_OverrideField;
			}
			set
			{
				this.exemption_Amount_OverrideField = value;
				this.RaisePropertyChanged("Exemption_Amount_Override");
			}
		}

		[XmlIgnore]
		public bool Exemption_Amount_OverrideSpecified
		{
			get
			{
				return this.exemption_Amount_OverrideFieldSpecified;
			}
			set
			{
				this.exemption_Amount_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Exemption_Amount_OverrideSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public FrequencyObjectType Exemption_Frequency_Reference
		{
			get
			{
				return this.exemption_Frequency_ReferenceField;
			}
			set
			{
				this.exemption_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Exemption_Frequency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Tax_Levy_Termination_Date
		{
			get
			{
				return this.tax_Levy_Termination_DateField;
			}
			set
			{
				this.tax_Levy_Termination_DateField = value;
				this.RaisePropertyChanged("Tax_Levy_Termination_Date");
			}
		}

		[XmlIgnore]
		public bool Tax_Levy_Termination_DateSpecified
		{
			get
			{
				return this.tax_Levy_Termination_DateFieldSpecified;
			}
			set
			{
				this.tax_Levy_Termination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_Levy_Termination_DateSpecified");
			}
		}

		[XmlElement("Federal_Tax_Levy_Dependent_Reference", Order = 7)]
		public Federal_Tax_Levy_Dependent_ReferenceType[] Federal_Tax_Levy_Dependent_Reference
		{
			get
			{
				return this.federal_Tax_Levy_Dependent_ReferenceField;
			}
			set
			{
				this.federal_Tax_Levy_Dependent_ReferenceField = value;
				this.RaisePropertyChanged("Federal_Tax_Levy_Dependent_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Lock_Tax_Elections
		{
			get
			{
				return this.lock_Tax_ElectionsField;
			}
			set
			{
				this.lock_Tax_ElectionsField = value;
				this.RaisePropertyChanged("Lock_Tax_Elections");
			}
		}

		[XmlIgnore]
		public bool Lock_Tax_ElectionsSpecified
		{
			get
			{
				return this.lock_Tax_ElectionsFieldSpecified;
			}
			set
			{
				this.lock_Tax_ElectionsFieldSpecified = value;
				this.RaisePropertyChanged("Lock_Tax_ElectionsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Load_Baseline_Restrictions
		{
			get
			{
				return this.load_Baseline_RestrictionsField;
			}
			set
			{
				this.load_Baseline_RestrictionsField = value;
				this.RaisePropertyChanged("Load_Baseline_Restrictions");
			}
		}

		[XmlIgnore]
		public bool Load_Baseline_RestrictionsSpecified
		{
			get
			{
				return this.load_Baseline_RestrictionsFieldSpecified;
			}
			set
			{
				this.load_Baseline_RestrictionsFieldSpecified = value;
				this.RaisePropertyChanged("Load_Baseline_RestrictionsSpecified");
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
