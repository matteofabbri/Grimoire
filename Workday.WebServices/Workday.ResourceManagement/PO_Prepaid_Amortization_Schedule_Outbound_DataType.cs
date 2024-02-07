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
	public class PO_Prepaid_Amortization_Schedule_Outbound_DataType : INotifyPropertyChanged
	{
		private Frequency_BehaviorObjectType frequency_ReferenceField;

		private decimal number_of_Prepayment_InstallmentsField;

		private bool number_of_Prepayment_InstallmentsFieldSpecified;

		private bool use_Invoice_DateField;

		private bool use_Invoice_DateFieldSpecified;

		private DateTime specified_DateField;

		private bool specified_DateFieldSpecified;

		private Purchase_Order_LineObjectType[] purchase_Order_Line_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Frequency_BehaviorObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Number_of_Prepayment_Installments
		{
			get
			{
				return this.number_of_Prepayment_InstallmentsField;
			}
			set
			{
				this.number_of_Prepayment_InstallmentsField = value;
				this.RaisePropertyChanged("Number_of_Prepayment_Installments");
			}
		}

		[XmlIgnore]
		public bool Number_of_Prepayment_InstallmentsSpecified
		{
			get
			{
				return this.number_of_Prepayment_InstallmentsFieldSpecified;
			}
			set
			{
				this.number_of_Prepayment_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Prepayment_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Use_Invoice_Date
		{
			get
			{
				return this.use_Invoice_DateField;
			}
			set
			{
				this.use_Invoice_DateField = value;
				this.RaisePropertyChanged("Use_Invoice_Date");
			}
		}

		[XmlIgnore]
		public bool Use_Invoice_DateSpecified
		{
			get
			{
				return this.use_Invoice_DateFieldSpecified;
			}
			set
			{
				this.use_Invoice_DateFieldSpecified = value;
				this.RaisePropertyChanged("Use_Invoice_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Specified_Date
		{
			get
			{
				return this.specified_DateField;
			}
			set
			{
				this.specified_DateField = value;
				this.RaisePropertyChanged("Specified_Date");
			}
		}

		[XmlIgnore]
		public bool Specified_DateSpecified
		{
			get
			{
				return this.specified_DateFieldSpecified;
			}
			set
			{
				this.specified_DateFieldSpecified = value;
				this.RaisePropertyChanged("Specified_DateSpecified");
			}
		}

		[XmlElement("Purchase_Order_Line_Reference", Order = 4)]
		public Purchase_Order_LineObjectType[] Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
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
