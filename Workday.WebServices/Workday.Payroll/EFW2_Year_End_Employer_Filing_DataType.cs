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
	public class EFW2_Year_End_Employer_Filing_DataType : INotifyPropertyChanged
	{
		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private string eINField;

		private string company_NameField;

		private Kind_of_Employer_for_Payroll_Tax_FilingObjectType kind_of_Employer_ReferenceField;

		private bool third_Party_Sick_Pay_IndicatorField;

		private bool third_Party_Sick_Pay_IndicatorFieldSpecified;

		private EFW2_Year_End_Submitter_DataType[] eFW2_Year_End_Submitter_DataField;

		private EFW2_Year_End_Employer_Box_DataType[] eFW2_Year_End_Employer_Box_DataField;

		private EFW2_Employer_Deferred_and_Other_Compensation_DataType[] eFW2_Deferred_and_Other_Compensation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Calendar_YearObjectType Calendar_Year_Reference
		{
			get
			{
				return this.calendar_Year_ReferenceField;
			}
			set
			{
				this.calendar_Year_ReferenceField = value;
				this.RaisePropertyChanged("Calendar_Year_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string EIN
		{
			get
			{
				return this.eINField;
			}
			set
			{
				this.eINField = value;
				this.RaisePropertyChanged("EIN");
			}
		}

		[XmlElement(Order = 2)]
		public string Company_Name
		{
			get
			{
				return this.company_NameField;
			}
			set
			{
				this.company_NameField = value;
				this.RaisePropertyChanged("Company_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Kind_of_Employer_for_Payroll_Tax_FilingObjectType Kind_of_Employer_Reference
		{
			get
			{
				return this.kind_of_Employer_ReferenceField;
			}
			set
			{
				this.kind_of_Employer_ReferenceField = value;
				this.RaisePropertyChanged("Kind_of_Employer_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Third_Party_Sick_Pay_Indicator
		{
			get
			{
				return this.third_Party_Sick_Pay_IndicatorField;
			}
			set
			{
				this.third_Party_Sick_Pay_IndicatorField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay_Indicator");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_Pay_IndicatorSpecified
		{
			get
			{
				return this.third_Party_Sick_Pay_IndicatorFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_Pay_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay_IndicatorSpecified");
			}
		}

		[XmlElement("EFW2_Year_End_Submitter_Data", Order = 5)]
		public EFW2_Year_End_Submitter_DataType[] EFW2_Year_End_Submitter_Data
		{
			get
			{
				return this.eFW2_Year_End_Submitter_DataField;
			}
			set
			{
				this.eFW2_Year_End_Submitter_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Submitter_Data");
			}
		}

		[XmlElement("EFW2_Year_End_Employer_Box_Data", Order = 6)]
		public EFW2_Year_End_Employer_Box_DataType[] EFW2_Year_End_Employer_Box_Data
		{
			get
			{
				return this.eFW2_Year_End_Employer_Box_DataField;
			}
			set
			{
				this.eFW2_Year_End_Employer_Box_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Employer_Box_Data");
			}
		}

		[XmlElement("EFW2_Deferred_and_Other_Compensation_Data", Order = 7)]
		public EFW2_Employer_Deferred_and_Other_Compensation_DataType[] EFW2_Deferred_and_Other_Compensation_Data
		{
			get
			{
				return this.eFW2_Deferred_and_Other_Compensation_DataField;
			}
			set
			{
				this.eFW2_Deferred_and_Other_Compensation_DataField = value;
				this.RaisePropertyChanged("EFW2_Deferred_and_Other_Compensation_Data");
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
