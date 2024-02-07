using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Dependent_Coverage_DataType : INotifyPropertyChanged
	{
		private DependentObjectType dependent_ReferenceField;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private DateTime original_Coverage_Begin_Date_for_Benefit_Coverage_TypeField;

		private bool original_Coverage_Begin_Date_for_Benefit_Coverage_TypeFieldSpecified;

		private DateTime first_Date_Covered_by_Benefit_PlanField;

		private bool first_Date_Covered_by_Benefit_PlanFieldSpecified;

		private DateTime first_Date_Covered_by_Benefit_ProviderField;

		private bool first_Date_Covered_by_Benefit_ProviderFieldSpecified;

		private string provider_IDField;

		private COBRA_Eligibility_DataType[] cOBRA_Eligibility_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DependentObjectType Dependent_Reference
		{
			get
			{
				return this.dependent_ReferenceField;
			}
			set
			{
				this.dependent_ReferenceField = value;
				this.RaisePropertyChanged("Dependent_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.original_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Original_Coverage_Begin_Date_for_Benefit_Coverage_Type
		{
			get
			{
				return this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeField;
			}
			set
			{
				this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date_for_Benefit_Coverage_Type");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_Date_for_Benefit_Coverage_TypeSpecified
		{
			get
			{
				return this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date_for_Benefit_Coverage_TypeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime First_Date_Covered_by_Benefit_Plan
		{
			get
			{
				return this.first_Date_Covered_by_Benefit_PlanField;
			}
			set
			{
				this.first_Date_Covered_by_Benefit_PlanField = value;
				this.RaisePropertyChanged("First_Date_Covered_by_Benefit_Plan");
			}
		}

		[XmlIgnore]
		public bool First_Date_Covered_by_Benefit_PlanSpecified
		{
			get
			{
				return this.first_Date_Covered_by_Benefit_PlanFieldSpecified;
			}
			set
			{
				this.first_Date_Covered_by_Benefit_PlanFieldSpecified = value;
				this.RaisePropertyChanged("First_Date_Covered_by_Benefit_PlanSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime First_Date_Covered_by_Benefit_Provider
		{
			get
			{
				return this.first_Date_Covered_by_Benefit_ProviderField;
			}
			set
			{
				this.first_Date_Covered_by_Benefit_ProviderField = value;
				this.RaisePropertyChanged("First_Date_Covered_by_Benefit_Provider");
			}
		}

		[XmlIgnore]
		public bool First_Date_Covered_by_Benefit_ProviderSpecified
		{
			get
			{
				return this.first_Date_Covered_by_Benefit_ProviderFieldSpecified;
			}
			set
			{
				this.first_Date_Covered_by_Benefit_ProviderFieldSpecified = value;
				this.RaisePropertyChanged("First_Date_Covered_by_Benefit_ProviderSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Provider_ID
		{
			get
			{
				return this.provider_IDField;
			}
			set
			{
				this.provider_IDField = value;
				this.RaisePropertyChanged("Provider_ID");
			}
		}

		[XmlElement("COBRA_Eligibility_Data", Order = 7)]
		public COBRA_Eligibility_DataType[] COBRA_Eligibility_Data
		{
			get
			{
				return this.cOBRA_Eligibility_DataField;
			}
			set
			{
				this.cOBRA_Eligibility_DataField = value;
				this.RaisePropertyChanged("COBRA_Eligibility_Data");
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
