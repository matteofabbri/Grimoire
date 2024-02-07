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
	public class Prepaid_Spend_Amortization_Installment_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType prepaid_Spend_Amortization_Installment_ReferenceField;

		private DateTime accounting_DateField;

		private Prepaid_Spend_Amortization_Installment_Line_DataType[] prepaid_Spend_Amortization_Installment_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Prepaid_Spend_Amortization_Installment_Reference
		{
			get
			{
				return this.prepaid_Spend_Amortization_Installment_ReferenceField;
			}
			set
			{
				this.prepaid_Spend_Amortization_Installment_ReferenceField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Installment_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Accounting_Date
		{
			get
			{
				return this.accounting_DateField;
			}
			set
			{
				this.accounting_DateField = value;
				this.RaisePropertyChanged("Accounting_Date");
			}
		}

		[XmlElement("Prepaid_Spend_Amortization_Installment_Line_Data", Order = 2)]
		public Prepaid_Spend_Amortization_Installment_Line_DataType[] Prepaid_Spend_Amortization_Installment_Line_Data
		{
			get
			{
				return this.prepaid_Spend_Amortization_Installment_Line_DataField;
			}
			set
			{
				this.prepaid_Spend_Amortization_Installment_Line_DataField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Installment_Line_Data");
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
