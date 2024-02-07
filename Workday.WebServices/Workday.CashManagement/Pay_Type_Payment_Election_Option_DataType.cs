using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Pay_Type_Payment_Election_Option_DataType : INotifyPropertyChanged
	{
		private Payment_Election_RuleObjectType payment_Election_Rule_ReferenceField;

		private Pay_Type_Payment_Election_Option_Line_DataType[] pay_Type_Payment_Election_Option_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_Election_RuleObjectType Payment_Election_Rule_Reference
		{
			get
			{
				return this.payment_Election_Rule_ReferenceField;
			}
			set
			{
				this.payment_Election_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Election_Rule_Reference");
			}
		}

		[XmlElement("Pay_Type_Payment_Election_Option_Line_Replacement_Data", Order = 1)]
		public Pay_Type_Payment_Election_Option_Line_DataType[] Pay_Type_Payment_Election_Option_Line_Replacement_Data
		{
			get
			{
				return this.pay_Type_Payment_Election_Option_Line_Replacement_DataField;
			}
			set
			{
				this.pay_Type_Payment_Election_Option_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Pay_Type_Payment_Election_Option_Line_Replacement_Data");
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
