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
	public class Expense_Report_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Expense_Report_DataField;

		private bool include_Expense_Report_DataFieldSpecified;

		private bool include_Credit_Card_Transaction_DataField;

		private bool include_Credit_Card_Transaction_DataFieldSpecified;

		private bool include_Attachment_DataField;

		private bool include_Attachment_DataFieldSpecified;

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
		public bool Include_Expense_Report_Data
		{
			get
			{
				return this.include_Expense_Report_DataField;
			}
			set
			{
				this.include_Expense_Report_DataField = value;
				this.RaisePropertyChanged("Include_Expense_Report_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Expense_Report_DataSpecified
		{
			get
			{
				return this.include_Expense_Report_DataFieldSpecified;
			}
			set
			{
				this.include_Expense_Report_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Expense_Report_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Credit_Card_Transaction_Data
		{
			get
			{
				return this.include_Credit_Card_Transaction_DataField;
			}
			set
			{
				this.include_Credit_Card_Transaction_DataField = value;
				this.RaisePropertyChanged("Include_Credit_Card_Transaction_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Credit_Card_Transaction_DataSpecified
		{
			get
			{
				return this.include_Credit_Card_Transaction_DataFieldSpecified;
			}
			set
			{
				this.include_Credit_Card_Transaction_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Credit_Card_Transaction_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Attachment_Data
		{
			get
			{
				return this.include_Attachment_DataField;
			}
			set
			{
				this.include_Attachment_DataField = value;
				this.RaisePropertyChanged("Include_Attachment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Attachment_DataSpecified
		{
			get
			{
				return this.include_Attachment_DataFieldSpecified;
			}
			set
			{
				this.include_Attachment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Attachment_DataSpecified");
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
