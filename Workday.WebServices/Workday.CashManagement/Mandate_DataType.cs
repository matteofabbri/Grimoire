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
	public class Mandate_DataType : INotifyPropertyChanged
	{
		private string identificationField;

		private DateTime date_of_SignatureField;

		private bool date_of_SignatureFieldSpecified;

		private string creditor_IdentifierField;

		private string sequence_TypeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Identification
		{
			get
			{
				return this.identificationField;
			}
			set
			{
				this.identificationField = value;
				this.RaisePropertyChanged("Identification");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date_of_Signature
		{
			get
			{
				return this.date_of_SignatureField;
			}
			set
			{
				this.date_of_SignatureField = value;
				this.RaisePropertyChanged("Date_of_Signature");
			}
		}

		[XmlIgnore]
		public bool Date_of_SignatureSpecified
		{
			get
			{
				return this.date_of_SignatureFieldSpecified;
			}
			set
			{
				this.date_of_SignatureFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_SignatureSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Creditor_Identifier
		{
			get
			{
				return this.creditor_IdentifierField;
			}
			set
			{
				this.creditor_IdentifierField = value;
				this.RaisePropertyChanged("Creditor_Identifier");
			}
		}

		[XmlElement(Order = 3)]
		public string Sequence_Type
		{
			get
			{
				return this.sequence_TypeField;
			}
			set
			{
				this.sequence_TypeField = value;
				this.RaisePropertyChanged("Sequence_Type");
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
