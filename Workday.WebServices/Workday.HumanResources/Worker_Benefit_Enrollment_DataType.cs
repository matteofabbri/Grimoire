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
	public class Worker_Benefit_Enrollment_DataType : INotifyPropertyChanged
	{
		private Worker_Health_Care_Period_DataType[] health_Care_DataField;

		private Worker_Health_Savings_Account_Period_DataType[] health_Savings_Account_DataField;

		private Worker_Spending_Account_Period_DataType[] spending_Account_DataField;

		private Worker_Insurance_Period_DataType[] insurance_DataField;

		private Worker_Retirement_Savings_Period_DataType[] retirement_Savings_DataField;

		private Worker_Additional_Benefits_Period_DataType[] additional_Benefits_DataField;

		private COBRA_Eligibility_DataType[] cOBRA_Eligibility_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Health_Care_Period_Data", IsNullable = false)]
		public Worker_Health_Care_Period_DataType[] Health_Care_Data
		{
			get
			{
				return this.health_Care_DataField;
			}
			set
			{
				this.health_Care_DataField = value;
				this.RaisePropertyChanged("Health_Care_Data");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Health_Savings_Account_Period_Data", IsNullable = false)]
		public Worker_Health_Savings_Account_Period_DataType[] Health_Savings_Account_Data
		{
			get
			{
				return this.health_Savings_Account_DataField;
			}
			set
			{
				this.health_Savings_Account_DataField = value;
				this.RaisePropertyChanged("Health_Savings_Account_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Spending_Account_Period_Data", IsNullable = false)]
		public Worker_Spending_Account_Period_DataType[] Spending_Account_Data
		{
			get
			{
				return this.spending_Account_DataField;
			}
			set
			{
				this.spending_Account_DataField = value;
				this.RaisePropertyChanged("Spending_Account_Data");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Insurance_Period_Data", IsNullable = false)]
		public Worker_Insurance_Period_DataType[] Insurance_Data
		{
			get
			{
				return this.insurance_DataField;
			}
			set
			{
				this.insurance_DataField = value;
				this.RaisePropertyChanged("Insurance_Data");
			}
		}

		[XmlArray(Order = 4), XmlArrayItem("Retirement_Savings_Period_Data", IsNullable = false)]
		public Worker_Retirement_Savings_Period_DataType[] Retirement_Savings_Data
		{
			get
			{
				return this.retirement_Savings_DataField;
			}
			set
			{
				this.retirement_Savings_DataField = value;
				this.RaisePropertyChanged("Retirement_Savings_Data");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("Additional_Benefits_Period_Data", IsNullable = false)]
		public Worker_Additional_Benefits_Period_DataType[] Additional_Benefits_Data
		{
			get
			{
				return this.additional_Benefits_DataField;
			}
			set
			{
				this.additional_Benefits_DataField = value;
				this.RaisePropertyChanged("Additional_Benefits_Data");
			}
		}

		[XmlElement("COBRA_Eligibility_Data", Order = 6)]
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
