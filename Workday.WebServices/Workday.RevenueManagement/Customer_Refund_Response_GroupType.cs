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
	public class Customer_Refund_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Customer_Refund_DataField;

		private bool include_Customer_Refund_DataFieldSpecified;

		private bool include_Customer_Invoice_Document_DataField;

		private bool include_Customer_Invoice_Document_DataFieldSpecified;

		private bool include_Customer_Invoice_Line_DataField;

		private bool include_Customer_Invoice_Line_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Customer_Refund_Data
		{
			get
			{
				return this.include_Customer_Refund_DataField;
			}
			set
			{
				this.include_Customer_Refund_DataField = value;
				this.RaisePropertyChanged("Include_Customer_Refund_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_Refund_DataSpecified
		{
			get
			{
				return this.include_Customer_Refund_DataFieldSpecified;
			}
			set
			{
				this.include_Customer_Refund_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_Refund_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Customer_Invoice_Document_Data
		{
			get
			{
				return this.include_Customer_Invoice_Document_DataField;
			}
			set
			{
				this.include_Customer_Invoice_Document_DataField = value;
				this.RaisePropertyChanged("Include_Customer_Invoice_Document_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_Invoice_Document_DataSpecified
		{
			get
			{
				return this.include_Customer_Invoice_Document_DataFieldSpecified;
			}
			set
			{
				this.include_Customer_Invoice_Document_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_Invoice_Document_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Customer_Invoice_Line_Data
		{
			get
			{
				return this.include_Customer_Invoice_Line_DataField;
			}
			set
			{
				this.include_Customer_Invoice_Line_DataField = value;
				this.RaisePropertyChanged("Include_Customer_Invoice_Line_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_Invoice_Line_DataSpecified
		{
			get
			{
				return this.include_Customer_Invoice_Line_DataFieldSpecified;
			}
			set
			{
				this.include_Customer_Invoice_Line_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_Invoice_Line_DataSpecified");
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
