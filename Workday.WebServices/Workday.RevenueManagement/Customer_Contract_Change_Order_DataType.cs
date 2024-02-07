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
	public class Customer_Contract_Change_Order_DataType : INotifyPropertyChanged
	{
		private Contract_Amendment_TypeObjectType active_Amendment_Type_ReferenceField;

		private DateTime amendment_Effective_DateField;

		private string amendment_NumberField;

		private DateTime amendment_Signed_DateField;

		private bool amendment_Signed_DateFieldSpecified;

		private string amendment_DescriptionField;

		private Customer_Contract_Line_Change_Order_DataType[] customer_Contract_Line_Change_Order_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private decimal total_Customer_Contract_AmountField;

		private bool total_Customer_Contract_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contract_Amendment_TypeObjectType Active_Amendment_Type_Reference
		{
			get
			{
				return this.active_Amendment_Type_ReferenceField;
			}
			set
			{
				this.active_Amendment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Active_Amendment_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Amendment_Effective_Date
		{
			get
			{
				return this.amendment_Effective_DateField;
			}
			set
			{
				this.amendment_Effective_DateField = value;
				this.RaisePropertyChanged("Amendment_Effective_Date");
			}
		}

		[XmlElement(Order = 2)]
		public string Amendment_Number
		{
			get
			{
				return this.amendment_NumberField;
			}
			set
			{
				this.amendment_NumberField = value;
				this.RaisePropertyChanged("Amendment_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Amendment_Signed_Date
		{
			get
			{
				return this.amendment_Signed_DateField;
			}
			set
			{
				this.amendment_Signed_DateField = value;
				this.RaisePropertyChanged("Amendment_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Amendment_Signed_DateSpecified
		{
			get
			{
				return this.amendment_Signed_DateFieldSpecified;
			}
			set
			{
				this.amendment_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Amendment_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Amendment_Description
		{
			get
			{
				return this.amendment_DescriptionField;
			}
			set
			{
				this.amendment_DescriptionField = value;
				this.RaisePropertyChanged("Amendment_Description");
			}
		}

		[XmlElement("Customer_Contract_Line_Change_Order_Data", Order = 5)]
		public Customer_Contract_Line_Change_Order_DataType[] Customer_Contract_Line_Change_Order_Data
		{
			get
			{
				return this.customer_Contract_Line_Change_Order_DataField;
			}
			set
			{
				this.customer_Contract_Line_Change_Order_DataField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Change_Order_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 6)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Total_Customer_Contract_Amount
		{
			get
			{
				return this.total_Customer_Contract_AmountField;
			}
			set
			{
				this.total_Customer_Contract_AmountField = value;
				this.RaisePropertyChanged("Total_Customer_Contract_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Customer_Contract_AmountSpecified
		{
			get
			{
				return this.total_Customer_Contract_AmountFieldSpecified;
			}
			set
			{
				this.total_Customer_Contract_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Customer_Contract_AmountSpecified");
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
