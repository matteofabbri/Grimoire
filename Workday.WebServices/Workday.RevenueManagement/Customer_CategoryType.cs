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
	public class Customer_CategoryType : INotifyPropertyChanged
	{
		private Customer_CategoryObjectType customer_Category_ReferenceField;

		private Customer_Category_DataType[] customer_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_CategoryObjectType Customer_Category_Reference
		{
			get
			{
				return this.customer_Category_ReferenceField;
			}
			set
			{
				this.customer_Category_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Category_Reference");
			}
		}

		[XmlElement("Customer_Category_Data", Order = 1)]
		public Customer_Category_DataType[] Customer_Category_Data
		{
			get
			{
				return this.customer_Category_DataField;
			}
			set
			{
				this.customer_Category_DataField = value;
				this.RaisePropertyChanged("Customer_Category_Data");
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
