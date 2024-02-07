using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Payment_Election_Enrollment_RequestType : INotifyPropertyChanged
	{
		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Payment_Election_Enrollment_for_Worker_DataType payment_Election_Enrollment_DataField;

		private bool retain_Unused_Worker_Bank_AccountsField;

		private bool retain_Unused_Worker_Bank_AccountsFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 1)]
		public Payment_Election_Enrollment_for_Worker_DataType Payment_Election_Enrollment_Data
		{
			get
			{
				return this.payment_Election_Enrollment_DataField;
			}
			set
			{
				this.payment_Election_Enrollment_DataField = value;
				this.RaisePropertyChanged("Payment_Election_Enrollment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Retain_Unused_Worker_Bank_Accounts
		{
			get
			{
				return this.retain_Unused_Worker_Bank_AccountsField;
			}
			set
			{
				this.retain_Unused_Worker_Bank_AccountsField = value;
				this.RaisePropertyChanged("Retain_Unused_Worker_Bank_Accounts");
			}
		}

		[XmlIgnore]
		public bool Retain_Unused_Worker_Bank_AccountsSpecified
		{
			get
			{
				return this.retain_Unused_Worker_Bank_AccountsFieldSpecified;
			}
			set
			{
				this.retain_Unused_Worker_Bank_AccountsFieldSpecified = value;
				this.RaisePropertyChanged("Retain_Unused_Worker_Bank_AccountsSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
