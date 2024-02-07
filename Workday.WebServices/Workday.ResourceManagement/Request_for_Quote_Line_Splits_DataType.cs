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
	public class Request_for_Quote_Line_Splits_DataType : INotifyPropertyChanged
	{
		private Business_Document_Line_SplitObjectType request_for_Quote_Line_Split_ReferenceField;

		private string request_for_Quote_Line_Split_IDField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private string memoField;

		private Business_Document_Line_SplitObjectType line_Split_Allocation_ReferenceField;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Document_Line_SplitObjectType Request_for_Quote_Line_Split_Reference
		{
			get
			{
				return this.request_for_Quote_Line_Split_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Line_Split_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_Split_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Request_for_Quote_Line_Split_ID
		{
			get
			{
				return this.request_for_Quote_Line_Split_IDField;
			}
			set
			{
				this.request_for_Quote_Line_Split_IDField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_Split_ID");
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

		[XmlElement(Order = 5)]
		public Business_Document_Line_SplitObjectType Line_Split_Allocation_Reference
		{
			get
			{
				return this.line_Split_Allocation_ReferenceField;
			}
			set
			{
				this.line_Split_Allocation_ReferenceField = value;
				this.RaisePropertyChanged("Line_Split_Allocation_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 6)]
		public Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
