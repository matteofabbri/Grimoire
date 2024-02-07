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
	public class Benefit_Coverage_Type_for_Retirement_Savings_Elections_DataType : INotifyPropertyChanged
	{
		private Benefit_Coverage_TypeObjectType benefit_Coverage_Type_ReferenceField;

		private decimal itemField;

		private ItemChoiceType5 itemElementNameField;

		private Retirement_Savings_Election_for_Coverage_Type_DataType[] retirement_Savings_Election_for_Coverage_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_Coverage_TypeObjectType Benefit_Coverage_Type_Reference
		{
			get
			{
				return this.benefit_Coverage_Type_ReferenceField;
			}
			set
			{
				this.benefit_Coverage_Type_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Coverage_Type_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Employee_Contribution_Amount", typeof(decimal), Order = 1), XmlElement("Employee_Contribution_Percentage", typeof(decimal), Order = 1)]
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
		public ItemChoiceType5 ItemElementName
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

		[XmlElement("Retirement_Savings_Election_for_Coverage_Type_Data", Order = 3)]
		public Retirement_Savings_Election_for_Coverage_Type_DataType[] Retirement_Savings_Election_for_Coverage_Type_Data
		{
			get
			{
				return this.retirement_Savings_Election_for_Coverage_Type_DataField;
			}
			set
			{
				this.retirement_Savings_Election_for_Coverage_Type_DataField = value;
				this.RaisePropertyChanged("Retirement_Savings_Election_for_Coverage_Type_Data");
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
