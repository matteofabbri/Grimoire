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
	public class Salary_DataType : INotifyPropertyChanged
	{
		private bool combine_All_Jobs_for_Salary_SourceField;

		private bool combine_All_Jobs_for_Salary_SourceFieldSpecified;

		private Benefit_Salary_SourceObjectType benefit_Salary_Source_ReferenceField;

		private Compensation_Pay_EarningObjectType[] compensation_Element_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private Benefit_Annual_Rate_TypeObjectType benefit_Annual_Rate_Type_ReferenceField;

		private As_Of_Date_DataType as_Of_Date_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Combine_All_Jobs_for_Salary_Source
		{
			get
			{
				return this.combine_All_Jobs_for_Salary_SourceField;
			}
			set
			{
				this.combine_All_Jobs_for_Salary_SourceField = value;
				this.RaisePropertyChanged("Combine_All_Jobs_for_Salary_Source");
			}
		}

		[XmlIgnore]
		public bool Combine_All_Jobs_for_Salary_SourceSpecified
		{
			get
			{
				return this.combine_All_Jobs_for_Salary_SourceFieldSpecified;
			}
			set
			{
				this.combine_All_Jobs_for_Salary_SourceFieldSpecified = value;
				this.RaisePropertyChanged("Combine_All_Jobs_for_Salary_SourceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Benefit_Salary_SourceObjectType Benefit_Salary_Source_Reference
		{
			get
			{
				return this.benefit_Salary_Source_ReferenceField;
			}
			set
			{
				this.benefit_Salary_Source_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Salary_Source_Reference");
			}
		}

		[XmlElement("Compensation_Element_Reference", Order = 2)]
		public Compensation_Pay_EarningObjectType[] Compensation_Element_Reference
		{
			get
			{
				return this.compensation_Element_ReferenceField;
			}
			set
			{
				this.compensation_Element_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Element_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
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

		[XmlElement(Order = 5)]
		public As_Of_Date_DataType As_Of_Date_Data
		{
			get
			{
				return this.as_Of_Date_DataField;
			}
			set
			{
				this.as_Of_Date_DataField = value;
				this.RaisePropertyChanged("As_Of_Date_Data");
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
