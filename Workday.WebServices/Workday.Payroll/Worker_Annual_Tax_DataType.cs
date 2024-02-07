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
	public class Worker_Annual_Tax_DataType : INotifyPropertyChanged
	{
		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private decimal social_Security_TipsField;

		private bool social_Security_TipsFieldSpecified;

		private decimal allocated_TipsField;

		private bool allocated_TipsFieldSpecified;

		private decimal dependent_Care_BenefitsField;

		private bool dependent_Care_BenefitsFieldSpecified;

		private bool print_Workers_Tax_DocumentsField;

		private bool print_Workers_Tax_DocumentsFieldSpecified;

		private NonQualified_Pension_DataType nonQualified_Pension_DataField;

		private Deferred_and_Other_Compensation_DataType[] deferred_and_Other_Compensation_DataField;

		private Additional_DataType additional_DataField;

		private Other_DataType[] other_Data_WrapperField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Third_Party_Sick_Pay
		{
			get
			{
				return this.third_Party_Sick_PayField;
			}
			set
			{
				this.third_Party_Sick_PayField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_PaySpecified
		{
			get
			{
				return this.third_Party_Sick_PayFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_PayFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_PaySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Social_Security_Tips
		{
			get
			{
				return this.social_Security_TipsField;
			}
			set
			{
				this.social_Security_TipsField = value;
				this.RaisePropertyChanged("Social_Security_Tips");
			}
		}

		[XmlIgnore]
		public bool Social_Security_TipsSpecified
		{
			get
			{
				return this.social_Security_TipsFieldSpecified;
			}
			set
			{
				this.social_Security_TipsFieldSpecified = value;
				this.RaisePropertyChanged("Social_Security_TipsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Allocated_Tips
		{
			get
			{
				return this.allocated_TipsField;
			}
			set
			{
				this.allocated_TipsField = value;
				this.RaisePropertyChanged("Allocated_Tips");
			}
		}

		[XmlIgnore]
		public bool Allocated_TipsSpecified
		{
			get
			{
				return this.allocated_TipsFieldSpecified;
			}
			set
			{
				this.allocated_TipsFieldSpecified = value;
				this.RaisePropertyChanged("Allocated_TipsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Dependent_Care_Benefits
		{
			get
			{
				return this.dependent_Care_BenefitsField;
			}
			set
			{
				this.dependent_Care_BenefitsField = value;
				this.RaisePropertyChanged("Dependent_Care_Benefits");
			}
		}

		[XmlIgnore]
		public bool Dependent_Care_BenefitsSpecified
		{
			get
			{
				return this.dependent_Care_BenefitsFieldSpecified;
			}
			set
			{
				this.dependent_Care_BenefitsFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_Care_BenefitsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Print_Workers_Tax_Documents
		{
			get
			{
				return this.print_Workers_Tax_DocumentsField;
			}
			set
			{
				this.print_Workers_Tax_DocumentsField = value;
				this.RaisePropertyChanged("Print_Workers_Tax_Documents");
			}
		}

		[XmlIgnore]
		public bool Print_Workers_Tax_DocumentsSpecified
		{
			get
			{
				return this.print_Workers_Tax_DocumentsFieldSpecified;
			}
			set
			{
				this.print_Workers_Tax_DocumentsFieldSpecified = value;
				this.RaisePropertyChanged("Print_Workers_Tax_DocumentsSpecified");
			}
		}

		[XmlElement("Non-Qualified_Pension_Data", Order = 5)]
		public NonQualified_Pension_DataType NonQualified_Pension_Data
		{
			get
			{
				return this.nonQualified_Pension_DataField;
			}
			set
			{
				this.nonQualified_Pension_DataField = value;
				this.RaisePropertyChanged("NonQualified_Pension_Data");
			}
		}

		[XmlElement("Deferred_and_Other_Compensation_Data", Order = 6)]
		public Deferred_and_Other_Compensation_DataType[] Deferred_and_Other_Compensation_Data
		{
			get
			{
				return this.deferred_and_Other_Compensation_DataField;
			}
			set
			{
				this.deferred_and_Other_Compensation_DataField = value;
				this.RaisePropertyChanged("Deferred_and_Other_Compensation_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Additional_DataType Additional_Data
		{
			get
			{
				return this.additional_DataField;
			}
			set
			{
				this.additional_DataField = value;
				this.RaisePropertyChanged("Additional_Data");
			}
		}

		[XmlArray(Order = 8), XmlArrayItem("Other_Data", typeof(Other_DataType), IsNullable = false)]
		public Other_DataType[] Other_Data_Wrapper
		{
			get
			{
				return this.other_Data_WrapperField;
			}
			set
			{
				this.other_Data_WrapperField = value;
				this.RaisePropertyChanged("Other_Data_Wrapper");
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
