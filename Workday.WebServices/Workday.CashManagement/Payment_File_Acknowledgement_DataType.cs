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
	public class Payment_File_Acknowledgement_DataType : INotifyPropertyChanged
	{
		private string original_Payment_Message_IDField;

		private Payment_Acknowledgement_StatusObjectType payment_Status_ReferenceField;

		private string status_Reason_CodeField;

		private string status_Reason_Code_DescriptionField;

		private DateTime original_Payment_Message_DateField;

		private bool original_Payment_Message_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Original_Payment_Message_ID
		{
			get
			{
				return this.original_Payment_Message_IDField;
			}
			set
			{
				this.original_Payment_Message_IDField = value;
				this.RaisePropertyChanged("Original_Payment_Message_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Payment_Acknowledgement_StatusObjectType Payment_Status_Reference
		{
			get
			{
				return this.payment_Status_ReferenceField;
			}
			set
			{
				this.payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Status_Reason_Code
		{
			get
			{
				return this.status_Reason_CodeField;
			}
			set
			{
				this.status_Reason_CodeField = value;
				this.RaisePropertyChanged("Status_Reason_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Status_Reason_Code_Description
		{
			get
			{
				return this.status_Reason_Code_DescriptionField;
			}
			set
			{
				this.status_Reason_Code_DescriptionField = value;
				this.RaisePropertyChanged("Status_Reason_Code_Description");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Original_Payment_Message_Date
		{
			get
			{
				return this.original_Payment_Message_DateField;
			}
			set
			{
				this.original_Payment_Message_DateField = value;
				this.RaisePropertyChanged("Original_Payment_Message_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Payment_Message_DateSpecified
		{
			get
			{
				return this.original_Payment_Message_DateFieldSpecified;
			}
			set
			{
				this.original_Payment_Message_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Payment_Message_DateSpecified");
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
