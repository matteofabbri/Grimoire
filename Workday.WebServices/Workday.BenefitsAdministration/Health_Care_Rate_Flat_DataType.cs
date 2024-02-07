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
	public class Health_Care_Rate_Flat_DataType : INotifyPropertyChanged
	{
		private string benefit_Rate_IDField;

		private decimal minimumField;

		private bool minimumFieldSpecified;

		private decimal maximumField;

		private bool maximumFieldSpecified;

		private decimal salary_MinimumField;

		private bool salary_MinimumFieldSpecified;

		private decimal salary_MaximumField;

		private bool salary_MaximumFieldSpecified;

		private Health_Care_Coverage_TargetObjectType health_Care_Coverage_Target_ReferenceField;

		private Benefit_Rate_Value_Flat_DataType[] rate_Value_Flat_DataField;

		private Benefit_Rate_Band_Tobacco_UseObjectType tobacco_Use_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Benefit_Rate_ID
		{
			get
			{
				return this.benefit_Rate_IDField;
			}
			set
			{
				this.benefit_Rate_IDField = value;
				this.RaisePropertyChanged("Benefit_Rate_ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Minimum
		{
			get
			{
				return this.minimumField;
			}
			set
			{
				this.minimumField = value;
				this.RaisePropertyChanged("Minimum");
			}
		}

		[XmlIgnore]
		public bool MinimumSpecified
		{
			get
			{
				return this.minimumFieldSpecified;
			}
			set
			{
				this.minimumFieldSpecified = value;
				this.RaisePropertyChanged("MinimumSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Maximum
		{
			get
			{
				return this.maximumField;
			}
			set
			{
				this.maximumField = value;
				this.RaisePropertyChanged("Maximum");
			}
		}

		[XmlIgnore]
		public bool MaximumSpecified
		{
			get
			{
				return this.maximumFieldSpecified;
			}
			set
			{
				this.maximumFieldSpecified = value;
				this.RaisePropertyChanged("MaximumSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Salary_Minimum
		{
			get
			{
				return this.salary_MinimumField;
			}
			set
			{
				this.salary_MinimumField = value;
				this.RaisePropertyChanged("Salary_Minimum");
			}
		}

		[XmlIgnore]
		public bool Salary_MinimumSpecified
		{
			get
			{
				return this.salary_MinimumFieldSpecified;
			}
			set
			{
				this.salary_MinimumFieldSpecified = value;
				this.RaisePropertyChanged("Salary_MinimumSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Salary_Maximum
		{
			get
			{
				return this.salary_MaximumField;
			}
			set
			{
				this.salary_MaximumField = value;
				this.RaisePropertyChanged("Salary_Maximum");
			}
		}

		[XmlIgnore]
		public bool Salary_MaximumSpecified
		{
			get
			{
				return this.salary_MaximumFieldSpecified;
			}
			set
			{
				this.salary_MaximumFieldSpecified = value;
				this.RaisePropertyChanged("Salary_MaximumSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Health_Care_Coverage_TargetObjectType Health_Care_Coverage_Target_Reference
		{
			get
			{
				return this.health_Care_Coverage_Target_ReferenceField;
			}
			set
			{
				this.health_Care_Coverage_Target_ReferenceField = value;
				this.RaisePropertyChanged("Health_Care_Coverage_Target_Reference");
			}
		}

		[XmlElement("Rate_Value_Flat_Data", Order = 6)]
		public Benefit_Rate_Value_Flat_DataType[] Rate_Value_Flat_Data
		{
			get
			{
				return this.rate_Value_Flat_DataField;
			}
			set
			{
				this.rate_Value_Flat_DataField = value;
				this.RaisePropertyChanged("Rate_Value_Flat_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Benefit_Rate_Band_Tobacco_UseObjectType Tobacco_Use_Reference
		{
			get
			{
				return this.tobacco_Use_ReferenceField;
			}
			set
			{
				this.tobacco_Use_ReferenceField = value;
				this.RaisePropertyChanged("Tobacco_Use_Reference");
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
