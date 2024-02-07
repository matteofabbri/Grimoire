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
	public class Retirement_Savings_Election_DataType : INotifyPropertyChanged
	{
		private Retirement_Savings_PlanObjectType retirement_Savings_Plan_ReferenceField;

		private decimal itemField;

		private ItemChoiceType3 itemElementNameField;

		private Beneficiary_Allocation_for_Change_Benefits_DataType[] beneficiary_Allocation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Retirement_Savings_PlanObjectType Retirement_Savings_Plan_Reference
		{
			get
			{
				return this.retirement_Savings_Plan_ReferenceField;
			}
			set
			{
				this.retirement_Savings_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Retirement_Savings_Plan_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Election_Amount", typeof(decimal), Order = 1), XmlElement("Election_Percentage", typeof(decimal), Order = 1)]
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

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType3 ItemElementName
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
