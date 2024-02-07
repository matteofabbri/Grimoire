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
	public class Retirement_Savings_Election_Data_for_Change_Retirement_Savings_PlansType : INotifyPropertyChanged
	{
		private DateTime coverage_Begin_DateField;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		private DateTime deduction_Begin_DateField;

		private bool deduction_Begin_DateFieldSpecified;

		private DateTime loaded_Original_Deduction_Begin_DateField;

		private bool loaded_Original_Deduction_Begin_DateFieldSpecified;

		private bool electField;

		private bool electFieldSpecified;

		private Retirement_Savings_PlanObjectType retirement_Savings_Plan_ReferenceField;

		private decimal itemField;

		private ItemChoiceType6 itemElementNameField;

		private Beneficiary_Allocation_for_Change_Benefits_DataType[] beneficiary_Allocation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Coverage_Begin_Date
		{
			get
			{
				return this.coverage_Begin_DateField;
			}
			set
			{
				this.coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Coverage_Begin_Date");
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
		public DateTime Deduction_Begin_Date
		{
			get
			{
				return this.deduction_Begin_DateField;
			}
			set
			{
				this.deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Deduction_Begin_DateSpecified
		{
			get
			{
				return this.deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Loaded_Original_Deduction_Begin_Date
		{
			get
			{
				return this.loaded_Original_Deduction_Begin_DateField;
			}
			set
			{
				this.loaded_Original_Deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Loaded_Original_Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Loaded_Original_Deduction_Begin_DateSpecified
		{
			get
			{
				return this.loaded_Original_Deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.loaded_Original_Deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Loaded_Original_Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Elect
		{
			get
			{
				return this.electField;
			}
			set
			{
				this.electField = value;
				this.RaisePropertyChanged("Elect");
			}
		}

		[XmlIgnore]
		public bool ElectSpecified
		{
			get
			{
				return this.electFieldSpecified;
			}
			set
			{
				this.electFieldSpecified = value;
				this.RaisePropertyChanged("ElectSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Election_Amount", typeof(decimal), Order = 6), XmlElement("Election_Percentage", typeof(decimal), Order = 6)]
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

		[XmlElement(Order = 7), XmlIgnore]
		public ItemChoiceType6 ItemElementName
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

		[XmlElement("Beneficiary_Allocation_Data", Order = 8)]
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
