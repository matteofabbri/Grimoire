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
	public class Contingent_Worker_Receipt_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private Purchase_Order_LineObjectType purchase_Order_Line_ReferenceField;

		private DateTime period_Start_DateField;

		private DateTime period_End_DateField;

		private Hours_Worked_DataType[] hours_Worked_DataField;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private decimal amount_to_ReceiveField;

		private bool amount_to_ReceiveFieldSpecified;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_Order_LineObjectType Purchase_Order_Line_Reference
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlElement("Hours_Worked_Data", Order = 3)]
		public Hours_Worked_DataType[] Hours_Worked_Data
		{
			get
			{
				return this.hours_Worked_DataField;
			}
			set
			{
				this.hours_Worked_DataField = value;
				this.RaisePropertyChanged("Hours_Worked_Data");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Additional_Amount
		{
			get
			{
				return this.additional_AmountField;
			}
			set
			{
				this.additional_AmountField = value;
				this.RaisePropertyChanged("Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_AmountSpecified
		{
			get
			{
				return this.additional_AmountFieldSpecified;
			}
			set
			{
				this.additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Amount_to_Receive
		{
			get
			{
				return this.amount_to_ReceiveField;
			}
			set
			{
				this.amount_to_ReceiveField = value;
				this.RaisePropertyChanged("Amount_to_Receive");
			}
		}

		[XmlIgnore]
		public bool Amount_to_ReceiveSpecified
		{
			get
			{
				return this.amount_to_ReceiveFieldSpecified;
			}
			set
			{
				this.amount_to_ReceiveFieldSpecified = value;
				this.RaisePropertyChanged("Amount_to_ReceiveSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
