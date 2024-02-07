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
	public class Payroll_Support_Order_Lump_Sum_DataType : INotifyPropertyChanged
	{
		private bool process_in_Regular_PeriodField;

		private bool process_in_Regular_PeriodFieldSpecified;

		private string custodial_Party_NameField;

		private string remittance_ID_OverrideField;

		private bool supports_Second_FamilyField;

		private bool supports_Second_FamilyFieldSpecified;

		private Payroll_Local_County_AuthorityObjectType payroll_Local_County_Authority_ReferenceField;

		private Support_Order_Dependent_DataType[] dependants_ReferenceField;

		private Payroll_Support_Order_Detail_DataType support_Order_Detail_ReferenceField;

		private string payroll_Local_County_Authority_FIPS_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Process_in_Regular_Period
		{
			get
			{
				return this.process_in_Regular_PeriodField;
			}
			set
			{
				this.process_in_Regular_PeriodField = value;
				this.RaisePropertyChanged("Process_in_Regular_Period");
			}
		}

		[XmlIgnore]
		public bool Process_in_Regular_PeriodSpecified
		{
			get
			{
				return this.process_in_Regular_PeriodFieldSpecified;
			}
			set
			{
				this.process_in_Regular_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Process_in_Regular_PeriodSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Custodial_Party_Name
		{
			get
			{
				return this.custodial_Party_NameField;
			}
			set
			{
				this.custodial_Party_NameField = value;
				this.RaisePropertyChanged("Custodial_Party_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Remittance_ID_Override
		{
			get
			{
				return this.remittance_ID_OverrideField;
			}
			set
			{
				this.remittance_ID_OverrideField = value;
				this.RaisePropertyChanged("Remittance_ID_Override");
			}
		}

		[XmlElement(Order = 3)]
		public bool Supports_Second_Family
		{
			get
			{
				return this.supports_Second_FamilyField;
			}
			set
			{
				this.supports_Second_FamilyField = value;
				this.RaisePropertyChanged("Supports_Second_Family");
			}
		}

		[XmlIgnore]
		public bool Supports_Second_FamilySpecified
		{
			get
			{
				return this.supports_Second_FamilyFieldSpecified;
			}
			set
			{
				this.supports_Second_FamilyFieldSpecified = value;
				this.RaisePropertyChanged("Supports_Second_FamilySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_Local_County_AuthorityObjectType Payroll_Local_County_Authority_Reference
		{
			get
			{
				return this.payroll_Local_County_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Local_County_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_County_Authority_Reference");
			}
		}

		[XmlElement("Dependants_Reference", Order = 5)]
		public Support_Order_Dependent_DataType[] Dependants_Reference
		{
			get
			{
				return this.dependants_ReferenceField;
			}
			set
			{
				this.dependants_ReferenceField = value;
				this.RaisePropertyChanged("Dependants_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Payroll_Support_Order_Detail_DataType Support_Order_Detail_Reference
		{
			get
			{
				return this.support_Order_Detail_ReferenceField;
			}
			set
			{
				this.support_Order_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Support_Order_Detail_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Payroll_Local_County_Authority_FIPS_Code
		{
			get
			{
				return this.payroll_Local_County_Authority_FIPS_CodeField;
			}
			set
			{
				this.payroll_Local_County_Authority_FIPS_CodeField = value;
				this.RaisePropertyChanged("Payroll_Local_County_Authority_FIPS_Code");
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
