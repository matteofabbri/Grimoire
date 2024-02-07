using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Pay_GroupType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType external_Pay_Group_ReferenceField;

		private External_Pay_Group_DataType[] external_Pay_Group_DataField;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal frequency_FactorField;

		private bool frequency_FactorFieldSpecified;

		private PeriodObjectType last_Completed_Period_ReferenceField;

		private PeriodObjectType current_Period_ReferenceField;

		private PeriodObjectType next_Period_ReferenceField;

		private Period_Content_DataType[] period_Content_DataField;

		private External_Pay_ComponentType[] external_Pay_ComponentField;

		private Benefit_Plan_Year_Definition_Year_End_DataType[] benefits_DataField;

		private Last_PI_Extract_Created_DataType[] last_Extract_Created_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_GroupObjectType External_Pay_Group_Reference
		{
			get
			{
				return this.external_Pay_Group_ReferenceField;
			}
			set
			{
				this.external_Pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("External_Pay_Group_Reference");
			}
		}

		[XmlElement("External_Pay_Group_Data", Order = 1)]
		public External_Pay_Group_DataType[] External_Pay_Group_Data
		{
			get
			{
				return this.external_Pay_Group_DataField;
			}
			set
			{
				this.external_Pay_Group_DataField = value;
				this.RaisePropertyChanged("External_Pay_Group_Data");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Frequency_Factor
		{
			get
			{
				return this.frequency_FactorField;
			}
			set
			{
				this.frequency_FactorField = value;
				this.RaisePropertyChanged("Frequency_Factor");
			}
		}

		[XmlIgnore]
		public bool Frequency_FactorSpecified
		{
			get
			{
				return this.frequency_FactorFieldSpecified;
			}
			set
			{
				this.frequency_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Frequency_FactorSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public PeriodObjectType Last_Completed_Period_Reference
		{
			get
			{
				return this.last_Completed_Period_ReferenceField;
			}
			set
			{
				this.last_Completed_Period_ReferenceField = value;
				this.RaisePropertyChanged("Last_Completed_Period_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public PeriodObjectType Current_Period_Reference
		{
			get
			{
				return this.current_Period_ReferenceField;
			}
			set
			{
				this.current_Period_ReferenceField = value;
				this.RaisePropertyChanged("Current_Period_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public PeriodObjectType Next_Period_Reference
		{
			get
			{
				return this.next_Period_ReferenceField;
			}
			set
			{
				this.next_Period_ReferenceField = value;
				this.RaisePropertyChanged("Next_Period_Reference");
			}
		}

		[XmlElement("Period_Content_Data", Order = 7)]
		public Period_Content_DataType[] Period_Content_Data
		{
			get
			{
				return this.period_Content_DataField;
			}
			set
			{
				this.period_Content_DataField = value;
				this.RaisePropertyChanged("Period_Content_Data");
			}
		}

		[XmlElement("External_Pay_Component", Order = 8)]
		public External_Pay_ComponentType[] External_Pay_Component
		{
			get
			{
				return this.external_Pay_ComponentField;
			}
			set
			{
				this.external_Pay_ComponentField = value;
				this.RaisePropertyChanged("External_Pay_Component");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Benefit_Plan_Data", IsNullable = false)]
		public Benefit_Plan_Year_Definition_Year_End_DataType[] Benefits_Data
		{
			get
			{
				return this.benefits_DataField;
			}
			set
			{
				this.benefits_DataField = value;
				this.RaisePropertyChanged("Benefits_Data");
			}
		}

		[XmlElement("Last_Extract_Created_Data", Order = 10)]
		public Last_PI_Extract_Created_DataType[] Last_Extract_Created_Data
		{
			get
			{
				return this.last_Extract_Created_DataField;
			}
			set
			{
				this.last_Extract_Created_DataField = value;
				this.RaisePropertyChanged("Last_Extract_Created_Data");
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
