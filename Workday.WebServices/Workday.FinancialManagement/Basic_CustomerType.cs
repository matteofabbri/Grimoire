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
	public class Basic_CustomerType : INotifyPropertyChanged
	{
		private CustomerObjectType customer_ReferenceField;

		private Basic_Customer_DataType basic_Customer_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Basic_Customer_DataType Basic_Customer_Data
		{
			get
			{
				return this.basic_Customer_DataField;
			}
			set
			{
				this.basic_Customer_DataField = value;
				this.RaisePropertyChanged("Basic_Customer_Data");
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
