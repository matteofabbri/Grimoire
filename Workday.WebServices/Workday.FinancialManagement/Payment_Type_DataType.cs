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
	public class Payment_Type_DataType : INotifyPropertyChanged
	{
		private string payment_Type_IDField;

		private string payment_Type_NameField;

		private Payment_MethodObjectType payment_Method_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payment_Type_ID
		{
			get
			{
				return this.payment_Type_IDField;
			}
			set
			{
				this.payment_Type_IDField = value;
				this.RaisePropertyChanged("Payment_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Payment_Type_Name
		{
			get
			{
				return this.payment_Type_NameField;
			}
			set
			{
				this.payment_Type_NameField = value;
				this.RaisePropertyChanged("Payment_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Payment_MethodObjectType Payment_Method_Reference
		{
			get
			{
				return this.payment_Method_ReferenceField;
			}
			set
			{
				this.payment_Method_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Method_Reference");
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
