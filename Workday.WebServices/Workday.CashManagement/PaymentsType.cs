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
	public class PaymentsType : INotifyPropertyChanged
	{
		private Reporting_TransactionObjectType payment_ReferenceField;

		private Payment_WWS_DataType[] payment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Reporting_TransactionObjectType Payment_Reference
		{
			get
			{
				return this.payment_ReferenceField;
			}
			set
			{
				this.payment_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Reference");
			}
		}

		[XmlElement("Payment_Data", Order = 1)]
		public Payment_WWS_DataType[] Payment_Data
		{
			get
			{
				return this.payment_DataField;
			}
			set
			{
				this.payment_DataField = value;
				this.RaisePropertyChanged("Payment_Data");
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
