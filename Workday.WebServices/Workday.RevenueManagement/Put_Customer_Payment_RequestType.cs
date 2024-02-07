using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Customer_Payment_RequestType : INotifyPropertyChanged
	{
		private Customer_Payment_for_InvoicesObjectType customer_Payment_for_Invoices_ReferenceField;

		private Customer_Payment_for_Invoices_WWS_DataType customer_Payment_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Payment_for_InvoicesObjectType Customer_Payment_for_Invoices_Reference
		{
			get
			{
				return this.customer_Payment_for_Invoices_ReferenceField;
			}
			set
			{
				this.customer_Payment_for_Invoices_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Payment_for_Invoices_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Payment_for_Invoices_WWS_DataType Customer_Payment_Data
		{
			get
			{
				return this.customer_Payment_DataField;
			}
			set
			{
				this.customer_Payment_DataField = value;
				this.RaisePropertyChanged("Customer_Payment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
