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
	public class Payment_Election_OptionType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payment_Election_Option_ReferenceField;

		private Payment_Election_Option_DataType[] payment_Election_Option_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payment_Election_Option_Reference
		{
			get
			{
				return this.payment_Election_Option_ReferenceField;
			}
			set
			{
				this.payment_Election_Option_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Election_Option_Reference");
			}
		}

		[XmlElement("Payment_Election_Option_Data", Order = 1)]
		public Payment_Election_Option_DataType[] Payment_Election_Option_Data
		{
			get
			{
				return this.payment_Election_Option_DataField;
			}
			set
			{
				this.payment_Election_Option_DataField = value;
				this.RaisePropertyChanged("Payment_Election_Option_Data");
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
