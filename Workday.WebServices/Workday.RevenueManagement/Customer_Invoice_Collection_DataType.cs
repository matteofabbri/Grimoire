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
	public class Customer_Invoice_Collection_DataType : INotifyPropertyChanged
	{
		private DateTime collection_DateField;

		private decimal payment_Amount_PromisedField;

		private bool payment_Amount_PromisedFieldSpecified;

		private Collection_CodeObjectType collection_Code_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Collection_Date
		{
			get
			{
				return this.collection_DateField;
			}
			set
			{
				this.collection_DateField = value;
				this.RaisePropertyChanged("Collection_Date");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Payment_Amount_Promised
		{
			get
			{
				return this.payment_Amount_PromisedField;
			}
			set
			{
				this.payment_Amount_PromisedField = value;
				this.RaisePropertyChanged("Payment_Amount_Promised");
			}
		}

		[XmlIgnore]
		public bool Payment_Amount_PromisedSpecified
		{
			get
			{
				return this.payment_Amount_PromisedFieldSpecified;
			}
			set
			{
				this.payment_Amount_PromisedFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Amount_PromisedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Collection_CodeObjectType Collection_Code_Reference
		{
			get
			{
				return this.collection_Code_ReferenceField;
			}
			set
			{
				this.collection_Code_ReferenceField = value;
				this.RaisePropertyChanged("Collection_Code_Reference");
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
