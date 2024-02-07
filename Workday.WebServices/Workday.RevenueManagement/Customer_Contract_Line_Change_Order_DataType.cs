using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Contract_Line_Change_Order_DataType : INotifyPropertyChanged
	{
		private Receivable_Contract_Line_AbstractObjectType receivable_Contract_Line_ReferenceField;

		private DateTime change_Order_Effective_DateField;

		private bool change_Order_Effective_DateFieldSpecified;

		private Contract_Amendment_TypeObjectType[] change_Order_Type_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal quantity_2Field;

		private bool quantity_2FieldSpecified;

		private decimal change_Order_AmountField;

		private bool change_Order_AmountFieldSpecified;

		private string notesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Receivable_Contract_Line_AbstractObjectType Receivable_Contract_Line_Reference
		{
			get
			{
				return this.receivable_Contract_Line_ReferenceField;
			}
			set
			{
				this.receivable_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Receivable_Contract_Line_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Change_Order_Effective_Date
		{
			get
			{
				return this.change_Order_Effective_DateField;
			}
			set
			{
				this.change_Order_Effective_DateField = value;
				this.RaisePropertyChanged("Change_Order_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Change_Order_Effective_DateSpecified
		{
			get
			{
				return this.change_Order_Effective_DateFieldSpecified;
			}
			set
			{
				this.change_Order_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Change_Order_Effective_DateSpecified");
			}
		}

		[XmlElement("Change_Order_Type_Reference", Order = 2)]
		public Contract_Amendment_TypeObjectType[] Change_Order_Type_Reference
		{
			get
			{
				return this.change_Order_Type_ReferenceField;
			}
			set
			{
				this.change_Order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Change_Order_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Quantity_2
		{
			get
			{
				return this.quantity_2Field;
			}
			set
			{
				this.quantity_2Field = value;
				this.RaisePropertyChanged("Quantity_2");
			}
		}

		[XmlIgnore]
		public bool Quantity_2Specified
		{
			get
			{
				return this.quantity_2FieldSpecified;
			}
			set
			{
				this.quantity_2FieldSpecified = value;
				this.RaisePropertyChanged("Quantity_2Specified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Change_Order_Amount
		{
			get
			{
				return this.change_Order_AmountField;
			}
			set
			{
				this.change_Order_AmountField = value;
				this.RaisePropertyChanged("Change_Order_Amount");
			}
		}

		[XmlIgnore]
		public bool Change_Order_AmountSpecified
		{
			get
			{
				return this.change_Order_AmountFieldSpecified;
			}
			set
			{
				this.change_Order_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Change_Order_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
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
