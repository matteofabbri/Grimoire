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
	public class Additional_Benefits_Election_DataType : INotifyPropertyChanged
	{
		private Additional_Benefits_PlanObjectType additional_Benefits_Plan_ReferenceField;

		private Additional_Benefits_Coverage_TargetObjectType additional_Benefits_Coverage_Target_ReferenceField;

		private decimal itemField;

		private ItemChoiceType4 itemElementNameField;

		private Benefit_Individual_Rate_Data_for_Change_Benefits_for_Life_EventType benefit_Individual_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Additional_Benefits_PlanObjectType Additional_Benefits_Plan_Reference
		{
			get
			{
				return this.additional_Benefits_Plan_ReferenceField;
			}
			set
			{
				this.additional_Benefits_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Benefits_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Additional_Benefits_Coverage_TargetObjectType Additional_Benefits_Coverage_Target_Reference
		{
			get
			{
				return this.additional_Benefits_Coverage_Target_ReferenceField;
			}
			set
			{
				this.additional_Benefits_Coverage_Target_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Benefits_Coverage_Target_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Additional_Benefits_Flat_Contribution_Amount", typeof(decimal), Order = 2), XmlElement("Additional_Benefits_Percentage_Contribution_Value", typeof(decimal), Order = 2)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 3), XmlIgnore]
		public ItemChoiceType4 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
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
