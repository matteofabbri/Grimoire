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
	public class Customer_Invoice_Dispute_DataType : INotifyPropertyChanged
	{
		private DateTime dispute_DateField;

		private decimal dispute_AmountField;

		private bool dispute_AmountFieldSpecified;

		private Dispute_ReasonObjectType[] dispute_Reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Dispute_Date
		{
			get
			{
				return this.dispute_DateField;
			}
			set
			{
				this.dispute_DateField = value;
				this.RaisePropertyChanged("Dispute_Date");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Dispute_Amount
		{
			get
			{
				return this.dispute_AmountField;
			}
			set
			{
				this.dispute_AmountField = value;
				this.RaisePropertyChanged("Dispute_Amount");
			}
		}

		[XmlIgnore]
		public bool Dispute_AmountSpecified
		{
			get
			{
				return this.dispute_AmountFieldSpecified;
			}
			set
			{
				this.dispute_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Dispute_AmountSpecified");
			}
		}

		[XmlElement("Dispute_Reason_Reference", Order = 2)]
		public Dispute_ReasonObjectType[] Dispute_Reason_Reference
		{
			get
			{
				return this.dispute_Reason_ReferenceField;
			}
			set
			{
				this.dispute_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Dispute_Reason_Reference");
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
