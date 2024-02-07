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
	public class Supplier_Invoice_Prepaid_Amortization_Schedule_WWS_DataType : INotifyPropertyChanged
	{
		private string prepaid_Spend_Amortization_Schedule_IDField;

		private Frequency_BehaviorObjectType frequency_ReferenceField;

		private decimal number_of_InstallmentsField;

		private object itemField;

		private object[] itemsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Prepaid_Spend_Amortization_Schedule_ID
		{
			get
			{
				return this.prepaid_Spend_Amortization_Schedule_IDField;
			}
			set
			{
				this.prepaid_Spend_Amortization_Schedule_IDField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Schedule_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Number_of_Installments
		{
			get
			{
				return this.number_of_InstallmentsField;
			}
			set
			{
				this.number_of_InstallmentsField = value;
				this.RaisePropertyChanged("Number_of_Installments");
			}
		}

		[XmlElement("From_Date", typeof(DateTime), DataType = "date", Order = 3), XmlElement("Use_Invoice_Date", typeof(bool), Order = 3)]
		public object Item
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

		[XmlElement("Include_All_Available_Prepaid_Lines", typeof(bool), Order = 4), XmlElement("Prepaid_Supplier_Invoice_Lines", typeof(Supplier_Invoice_Lines_For_Amortization_Schedule_DataType), Order = 4)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
