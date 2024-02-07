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
	public class Insurance_Election_Data_Change_BenefitsType : INotifyPropertyChanged
	{
		private Insurance_Coverage_PlanObjectType insurance_Coverage_Plan_ReferenceField;

		private DependentObjectType[] dependent_ReferenceField;

		private Insurance_Coverage_Master_AmountObjectType coverage_Amount_ReferenceField;

		private Beneficiary_Allocation_for_Change_Benefits_DataType[] beneficiary_Allocation_DataField;

		private Benefit_Individual_Rate_Data_for_Change_Benefits_for_Life_EventType benefit_Individual_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Insurance_Coverage_PlanObjectType Insurance_Coverage_Plan_Reference
		{
			get
			{
				return this.insurance_Coverage_Plan_ReferenceField;
			}
			set
			{
				this.insurance_Coverage_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Insurance_Coverage_Plan_Reference");
			}
		}

		[XmlElement("Dependent_Reference", Order = 1)]
		public DependentObjectType[] Dependent_Reference
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

		[XmlElement(Order = 2)]
		public Insurance_Coverage_Master_AmountObjectType Coverage_Amount_Reference
		{
			get
			{
				return this.coverage_Amount_ReferenceField;
			}
			set
			{
				this.coverage_Amount_ReferenceField = value;
				this.RaisePropertyChanged("Coverage_Amount_Reference");
			}
		}

		[XmlElement("Beneficiary_Allocation_Data", Order = 3)]
		public Beneficiary_Allocation_for_Change_Benefits_DataType[] Beneficiary_Allocation_Data
		{
			get
			{
				return this.beneficiary_Allocation_DataField;
			}
			set
			{
				this.beneficiary_Allocation_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Allocation_Data");
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
