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
	public class Customer_Category_DataType : INotifyPropertyChanged
	{
		private string customer_Category_IDField;

		private string customer_Category_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Category_ID
		{
			get
			{
				return this.customer_Category_IDField;
			}
			set
			{
				this.customer_Category_IDField = value;
				this.RaisePropertyChanged("Customer_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Category_Name
		{
			get
			{
				return this.customer_Category_NameField;
			}
			set
			{
				this.customer_Category_NameField = value;
				this.RaisePropertyChanged("Customer_Category_Name");
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
