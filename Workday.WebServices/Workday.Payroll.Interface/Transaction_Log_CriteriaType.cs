using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Transaction_Log_CriteriaType : INotifyPropertyChanged
	{
		private Effective_And_Updated_DateTime_DataType transaction_Date_Range_DataField;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Effective_And_Updated_DateTime_DataType Transaction_Date_Range_Data
		{
			get
			{
				return this.transaction_Date_Range_DataField;
			}
			set
			{
				this.transaction_Date_Range_DataField = value;
				this.RaisePropertyChanged("Transaction_Date_Range_Data");
			}
		}

		[XmlElement("Subscriber_Reference", typeof(SubscriberObjectType), Order = 1), XmlElement("Transaction_Type_References", typeof(Transaction_Type_ReferencesType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
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
