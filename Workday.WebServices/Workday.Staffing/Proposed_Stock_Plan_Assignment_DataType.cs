using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Stock_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Stock_PlanObjectType stock_Plan_ReferenceField;

		private decimal itemField;

		private ItemChoiceType6 itemElementNameField;

		private decimal manage_by_Compensation_Basis_Override_AmountField;

		private bool manage_by_Compensation_Basis_Override_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		private bool fixed_for_Manage_by_Basis_TotalField;

		private bool fixed_for_Manage_by_Basis_TotalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_PlanObjectType Stock_Plan_Reference
		{
			get
			{
				return this.stock_Plan_ReferenceField;
			}
			set
			{
				this.stock_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Plan_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Individual_Target_Amount", typeof(decimal), Order = 1), XmlElement("Individual_Target_Percent", typeof(decimal), Order = 1), XmlElement("Individual_Target_Shares", typeof(decimal), Order = 1)]
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

		[XmlElement(Order = 3)]
		public decimal Manage_by_Compensation_Basis_Override_Amount
		{
			get
			{
				return this.manage_by_Compensation_Basis_Override_AmountField;
			}
			set
			{
				this.manage_by_Compensation_Basis_Override_AmountField = value;
				this.RaisePropertyChanged("Manage_by_Compensation_Basis_Override_Amount");
			}
		}

		[XmlIgnore]
		public bool Manage_by_Compensation_Basis_Override_AmountSpecified
		{
			get
			{
				return this.manage_by_Compensation_Basis_Override_AmountFieldSpecified;
			}
			set
			{
				this.manage_by_Compensation_Basis_Override_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Manage_by_Compensation_Basis_Override_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Actual_End_Date
		{
			get
			{
				return this.actual_End_DateField;
			}
			set
			{
				this.actual_End_DateField = value;
				this.RaisePropertyChanged("Actual_End_Date");
			}
		}

		[XmlIgnore]
		public bool Actual_End_DateSpecified
		{
			get
			{
				return this.actual_End_DateFieldSpecified;
			}
			set
			{
				this.actual_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Fixed_for_Manage_by_Basis_Total
		{
			get
			{
				return this.fixed_for_Manage_by_Basis_TotalField;
			}
			set
			{
				this.fixed_for_Manage_by_Basis_TotalField = value;
				this.RaisePropertyChanged("Fixed_for_Manage_by_Basis_Total");
			}
		}

		[XmlIgnore]
		public bool Fixed_for_Manage_by_Basis_TotalSpecified
		{
			get
			{
				return this.fixed_for_Manage_by_Basis_TotalFieldSpecified;
			}
			set
			{
				this.fixed_for_Manage_by_Basis_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Fixed_for_Manage_by_Basis_TotalSpecified");
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
