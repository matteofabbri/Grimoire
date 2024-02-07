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
	public class Bank_Statement_File_DataType : INotifyPropertyChanged
	{
		private string bank_Statement_File_Reference_IDField;

		private string sender_IdentificationField;

		private string receiver_IdentificationField;

		private DateTime file_Creation_DateField;

		private bool file_Creation_DateFieldSpecified;

		private string file_Identification_NumberField;

		private bool skip_ValidationsField;

		private bool skip_ValidationsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Bank_Statement_File_Reference_ID
		{
			get
			{
				return this.bank_Statement_File_Reference_IDField;
			}
			set
			{
				this.bank_Statement_File_Reference_IDField = value;
				this.RaisePropertyChanged("Bank_Statement_File_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Sender_Identification
		{
			get
			{
				return this.sender_IdentificationField;
			}
			set
			{
				this.sender_IdentificationField = value;
				this.RaisePropertyChanged("Sender_Identification");
			}
		}

		[XmlElement(Order = 2)]
		public string Receiver_Identification
		{
			get
			{
				return this.receiver_IdentificationField;
			}
			set
			{
				this.receiver_IdentificationField = value;
				this.RaisePropertyChanged("Receiver_Identification");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime File_Creation_Date
		{
			get
			{
				return this.file_Creation_DateField;
			}
			set
			{
				this.file_Creation_DateField = value;
				this.RaisePropertyChanged("File_Creation_Date");
			}
		}

		[XmlIgnore]
		public bool File_Creation_DateSpecified
		{
			get
			{
				return this.file_Creation_DateFieldSpecified;
			}
			set
			{
				this.file_Creation_DateFieldSpecified = value;
				this.RaisePropertyChanged("File_Creation_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string File_Identification_Number
		{
			get
			{
				return this.file_Identification_NumberField;
			}
			set
			{
				this.file_Identification_NumberField = value;
				this.RaisePropertyChanged("File_Identification_Number");
			}
		}

		[XmlElement(Order = 5)]
		public bool Skip_Validations
		{
			get
			{
				return this.skip_ValidationsField;
			}
			set
			{
				this.skip_ValidationsField = value;
				this.RaisePropertyChanged("Skip_Validations");
			}
		}

		[XmlIgnore]
		public bool Skip_ValidationsSpecified
		{
			get
			{
				return this.skip_ValidationsFieldSpecified;
			}
			set
			{
				this.skip_ValidationsFieldSpecified = value;
				this.RaisePropertyChanged("Skip_ValidationsSpecified");
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
