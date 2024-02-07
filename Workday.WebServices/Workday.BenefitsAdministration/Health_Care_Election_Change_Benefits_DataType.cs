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
	public class Health_Care_Election_Change_Benefits_DataType : INotifyPropertyChanged
	{
		private Health_Care_Coverage_PlanObjectType health_Care_Coverage_Plan_ReferenceField;

		private Health_Care_Coverage_TargetObjectType health_Care_Coverage_Target_ReferenceField;

		private string provider_IDField;

		private Dependent_Election_DataType[] dependent_Election_DataField;

		private Benefit_Individual_Rate_Data_for_Change_Benefits_for_Life_EventType benefit_Individual_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Health_Care_Coverage_PlanObjectType Health_Care_Coverage_Plan_Reference
		{
			get
			{
				return this.health_Care_Coverage_Plan_ReferenceField;
			}
			set
			{
				this.health_Care_Coverage_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Health_Care_Coverage_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement("Dependent_Election_Data", Order = 3)]
		public Dependent_Election_DataType[] Dependent_Election_Data
		{
			get
			{
				return this.dependent_Election_DataField;
			}
			set
			{
				this.dependent_Election_DataField = value;
				this.RaisePropertyChanged("Dependent_Election_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Benefit_Individual_Rate_Data_for_Change_Benefits_for_Life_EventType Benefit_Individual_Rate_Data
		{
			get
			{
				return this.benefit_Individual_Rate_DataField;
			}
			set
			{
				this.benefit_Individual_Rate_DataField = value;
				this.RaisePropertyChanged("Benefit_Individual_Rate_Data");
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
