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
	public class Supplier_Account_Options_DataType : INotifyPropertyChanged
	{
		private bool allow_Different_Invoicing_and_Purchasing_SupplierField;

		private bool allow_Different_Invoicing_and_Purchasing_SupplierFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Allow_Different_Invoicing_and_Purchasing_Supplier
		{
			get
			{
				return this.allow_Different_Invoicing_and_Purchasing_SupplierField;
			}
			set
			{
				this.allow_Different_Invoicing_and_Purchasing_SupplierField = value;
				this.RaisePropertyChanged("Allow_Different_Invoicing_and_Purchasing_Supplier");
			}
		}

		[XmlIgnore]
		public bool Allow_Different_Invoicing_and_Purchasing_SupplierSpecified
		{
			get
			{
				return this.allow_Different_Invoicing_and_Purchasing_SupplierFieldSpecified;
			}
			set
			{
				this.allow_Different_Invoicing_and_Purchasing_SupplierFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Different_Invoicing_and_Purchasing_SupplierSpecified");
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
