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
	public class Customer_DepositType : INotifyPropertyChanged
	{
		private Customer_DepositObjectType customer_Deposit_ReferenceField;

		private Customer_Deposit_DataType[] customer_Deposit_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_DepositObjectType Customer_Deposit_Reference
		{
			get
			{
				return this.customer_Deposit_ReferenceField;
			}
			set
			{
				this.customer_Deposit_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Deposit_Reference");
			}
		}

		[XmlElement("Customer_Deposit_Data", Order = 1)]
		public Customer_Deposit_DataType[] Customer_Deposit_Data
		{
			get
			{
				return this.customer_Deposit_DataField;
			}
			set
			{
				this.customer_Deposit_DataField = value;
				this.RaisePropertyChanged("Customer_Deposit_Data");
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
