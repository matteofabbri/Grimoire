using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_TermType : INotifyPropertyChanged
	{
		private Payment_TermsObjectType payment_Term_ReferenceField;

		private Payment_Terms_DataType payment_Term_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_TermsObjectType Payment_Term_Reference
		{
			get
			{
				return this.payment_Term_ReferenceField;
			}
			set
			{
				this.payment_Term_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Term_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payment_Terms_DataType Payment_Term_Data
		{
			get
			{
				return this.payment_Term_DataField;
			}
			set
			{
				this.payment_Term_DataField = value;
				this.RaisePropertyChanged("Payment_Term_Data");
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
