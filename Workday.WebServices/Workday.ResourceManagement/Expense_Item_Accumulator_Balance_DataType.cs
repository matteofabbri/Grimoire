using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Item_Accumulator_Balance_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType expense_Item_Accumulator_Balance_ReferenceField;

		private Expense_ItemObjectType expense_Item_ReferenceField;

		private decimal beginning_BalanceField;

		private DateTime balance_Application_DateField;

		private DateTime applicable_Until_DateField;

		private bool applicable_Until_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Expense_Item_Accumulator_Balance_Reference
		{
			get
			{
				return this.expense_Item_Accumulator_Balance_ReferenceField;
			}
			set
			{
				this.expense_Item_Accumulator_Balance_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Accumulator_Balance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Expense_ItemObjectType Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Beginning_Balance
		{
			get
			{
				return this.beginning_BalanceField;
			}
			set
			{
				this.beginning_BalanceField = value;
				this.RaisePropertyChanged("Beginning_Balance");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Balance_Application_Date
		{
			get
			{
				return this.balance_Application_DateField;
			}
			set
			{
				this.balance_Application_DateField = value;
				this.RaisePropertyChanged("Balance_Application_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Applicable_Until_Date
		{
			get
			{
				return this.applicable_Until_DateField;
			}
			set
			{
				this.applicable_Until_DateField = value;
				this.RaisePropertyChanged("Applicable_Until_Date");
			}
		}

		[XmlIgnore]
		public bool Applicable_Until_DateSpecified
		{
			get
			{
				return this.applicable_Until_DateFieldSpecified;
			}
			set
			{
				this.applicable_Until_DateFieldSpecified = value;
				this.RaisePropertyChanged("Applicable_Until_DateSpecified");
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
