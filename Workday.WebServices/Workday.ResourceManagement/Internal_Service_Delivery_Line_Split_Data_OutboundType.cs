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
	public class Internal_Service_Delivery_Line_Split_Data_OutboundType : INotifyPropertyChanged
	{
		private string internal_Service_Delivery_Line_Split_IDField;

		private Internal_Service_Delivery_Line_SplitObjectType internal_Service_Delivery_Line_Split_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private string memoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Internal_Service_Delivery_Line_Split_ID
		{
			get
			{
				return this.internal_Service_Delivery_Line_Split_IDField;
			}
			set
			{
				this.internal_Service_Delivery_Line_Split_IDField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_Split_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Internal_Service_Delivery_Line_SplitObjectType Internal_Service_Delivery_Line_Split_Reference
		{
			get
			{
				return this.internal_Service_Delivery_Line_Split_ReferenceField;
			}
			set
			{
				this.internal_Service_Delivery_Line_Split_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_Split_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement("Worktags_Reference", Order = 5)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
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
