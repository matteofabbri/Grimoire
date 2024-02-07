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
	public class Prepaid_Spend_Amortization_Schedule_DataType : INotifyPropertyChanged
	{
		private string itemField;

		private ItemChoiceType4 itemElementNameField;

		private Prepaid_Spend_Amortization_Installment_DataType[] prepaid_Spend_Amortization_Installment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Prepaid_Spend_Amortization_Schedule_ID", typeof(string), Order = 0), XmlElement("Supplier_Invoice_ID", typeof(string), Order = 0)]
		public string Item
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

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType4 ItemElementName
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

		[XmlElement("Prepaid_Spend_Amortization_Installment_Data", Order = 2)]
		public Prepaid_Spend_Amortization_Installment_DataType[] Prepaid_Spend_Amortization_Installment_Data
		{
			get
			{
				return this.prepaid_Spend_Amortization_Installment_DataField;
			}
			set
			{
				this.prepaid_Spend_Amortization_Installment_DataField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Installment_Data");
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
