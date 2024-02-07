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
	public class Expense_Rate_Table_DataType : INotifyPropertyChanged
	{
		private string expense_Rate_Table_IDField;

		private string expense_Rate_Table_NameField;

		private Expense_Rate_Table_TypeObjectType expense_Rate_Table_Type_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Expense_Item_Attribute_TypeObjectType expense_Item_Attribute_Type_ReferenceField;

		private DateTime expense_Rate_Table_Effective_DateField;

		private bool expense_Rate_Table_Effective_DateFieldSpecified;

		private Expense_Rate_Table_Line_DataType[] expense_Rate_Table_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Expense_Rate_Table_ID
		{
			get
			{
				return this.expense_Rate_Table_IDField;
			}
			set
			{
				this.expense_Rate_Table_IDField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Expense_Rate_Table_Name
		{
			get
			{
				return this.expense_Rate_Table_NameField;
			}
			set
			{
				this.expense_Rate_Table_NameField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Expense_Rate_Table_TypeObjectType Expense_Rate_Table_Type_Reference
		{
			get
			{
				return this.expense_Rate_Table_Type_ReferenceField;
			}
			set
			{
				this.expense_Rate_Table_Type_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Expense_Item_Attribute_TypeObjectType Expense_Item_Attribute_Type_Reference
		{
			get
			{
				return this.expense_Item_Attribute_Type_ReferenceField;
			}
			set
			{
				this.expense_Item_Attribute_Type_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Attribute_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Expense_Rate_Table_Effective_Date
		{
			get
			{
				return this.expense_Rate_Table_Effective_DateField;
			}
			set
			{
				this.expense_Rate_Table_Effective_DateField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Expense_Rate_Table_Effective_DateSpecified
		{
			get
			{
				return this.expense_Rate_Table_Effective_DateFieldSpecified;
			}
			set
			{
				this.expense_Rate_Table_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Effective_DateSpecified");
			}
		}

		[XmlElement("Expense_Rate_Table_Line_Replacement_Data", Order = 6)]
		public Expense_Rate_Table_Line_DataType[] Expense_Rate_Table_Line_Replacement_Data
		{
			get
			{
				return this.expense_Rate_Table_Line_Replacement_DataField;
			}
			set
			{
				this.expense_Rate_Table_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Line_Replacement_Data");
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
