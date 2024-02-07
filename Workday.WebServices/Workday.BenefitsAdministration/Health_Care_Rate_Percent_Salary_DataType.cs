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
	public class Health_Care_Rate_Percent_Salary_DataType : INotifyPropertyChanged
	{
		private Salary_DataType[] benefit_Rate_Salary_Source_DataField;

		private Benefit_Rounding_Rule_Final_DataType[] benefit_Rounding_Rule_Final_DataField;

		private Health_Care_Rate_Percent_of_Salary_DataType[] health_Care_Rate_Percent_of_Salary_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Salary_Data", typeof(Salary_DataType), IsNullable = false)]
		public Salary_DataType[] Benefit_Rate_Salary_Source_Data
		{
			get
			{
				return this.benefit_Rate_Salary_Source_DataField;
			}
			set
			{
				this.benefit_Rate_Salary_Source_DataField = value;
				this.RaisePropertyChanged("Benefit_Rate_Salary_Source_Data");
			}
		}

		[XmlElement("Benefit_Rounding_Rule_Final_Data", Order = 1)]
		public Benefit_Rounding_Rule_Final_DataType[] Benefit_Rounding_Rule_Final_Data
		{
			get
			{
				return this.benefit_Rounding_Rule_Final_DataField;
			}
			set
			{
				this.benefit_Rounding_Rule_Final_DataField = value;
				this.RaisePropertyChanged("Benefit_Rounding_Rule_Final_Data");
			}
		}

		[XmlElement("Health_Care_Rate_Percent_of_Salary_Data", Order = 2)]
		public Health_Care_Rate_Percent_of_Salary_DataType[] Health_Care_Rate_Percent_of_Salary_Data
		{
			get
			{
				return this.health_Care_Rate_Percent_of_Salary_DataField;
			}
			set
			{
				this.health_Care_Rate_Percent_of_Salary_DataField = value;
				this.RaisePropertyChanged("Health_Care_Rate_Percent_of_Salary_Data");
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
