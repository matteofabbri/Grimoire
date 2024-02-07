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
	public class Payment_Acknowledgement_Message_DataType : INotifyPropertyChanged
	{
		private string payment_Acknowlegement_Message_IDField;

		private DateTime payment_Acknowledgement_Message_DateField;

		private bool payment_Acknowledgement_Message_DateFieldSpecified;

		private string originating_Bank_IDField;

		private bool payment_Acknowledgement_Message_UpdateField;

		private bool payment_Acknowledgement_Message_UpdateFieldSpecified;

		private Payment_File_Acknowledgement_DataType[] payment_File_Acknowledgement_Replacement_DataField;

		private Payment_Acknowledgement_DataType[] payment_Acknowledgement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payment_Acknowlegement_Message_ID
		{
			get
			{
				return this.payment_Acknowlegement_Message_IDField;
			}
			set
			{
				this.payment_Acknowlegement_Message_IDField = value;
				this.RaisePropertyChanged("Payment_Acknowlegement_Message_ID");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Payment_Acknowledgement_Message_Date
		{
			get
			{
				return this.payment_Acknowledgement_Message_DateField;
			}
			set
			{
				this.payment_Acknowledgement_Message_DateField = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Message_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Acknowledgement_Message_DateSpecified
		{
			get
			{
				return this.payment_Acknowledgement_Message_DateFieldSpecified;
			}
			set
			{
				this.payment_Acknowledgement_Message_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Message_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Originating_Bank_ID
		{
			get
			{
				return this.originating_Bank_IDField;
			}
			set
			{
				this.originating_Bank_IDField = value;
				this.RaisePropertyChanged("Originating_Bank_ID");
			}
		}

		[XmlElement(Order = 3)]
		public bool Payment_Acknowledgement_Message_Update
		{
			get
			{
				return this.payment_Acknowledgement_Message_UpdateField;
			}
			set
			{
				this.payment_Acknowledgement_Message_UpdateField = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Message_Update");
			}
		}

		[XmlIgnore]
		public bool Payment_Acknowledgement_Message_UpdateSpecified
		{
			get
			{
				return this.payment_Acknowledgement_Message_UpdateFieldSpecified;
			}
			set
			{
				this.payment_Acknowledgement_Message_UpdateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Message_UpdateSpecified");
			}
		}

		[XmlElement("Payment_File_Acknowledgement_Replacement_Data", Order = 4)]
		public Payment_File_Acknowledgement_DataType[] Payment_File_Acknowledgement_Replacement_Data
		{
			get
			{
				return this.payment_File_Acknowledgement_Replacement_DataField;
			}
			set
			{
				this.payment_File_Acknowledgement_Replacement_DataField = value;
				this.RaisePropertyChanged("Payment_File_Acknowledgement_Replacement_Data");
			}
		}

		[XmlElement("Payment_Acknowledgement_Data", Order = 5)]
		public Payment_Acknowledgement_DataType[] Payment_Acknowledgement_Data
		{
			get
			{
				return this.payment_Acknowledgement_DataField;
			}
			set
			{
				this.payment_Acknowledgement_DataField = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Data");
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
