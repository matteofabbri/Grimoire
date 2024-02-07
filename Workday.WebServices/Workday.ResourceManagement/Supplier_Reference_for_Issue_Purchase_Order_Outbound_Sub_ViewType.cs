using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Reference_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private string dUNSField;

		private string supplierIDField;

		private string supplierNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string DUNS
		{
			get
			{
				return this.dUNSField;
			}
			set
			{
				this.dUNSField = value;
				this.RaisePropertyChanged("DUNS");
			}
		}

		[XmlElement(Order = 1)]
		public string SupplierID
		{
			get
			{
				return this.supplierIDField;
			}
			set
			{
				this.supplierIDField = value;
				this.RaisePropertyChanged("SupplierID");
			}
		}

		[XmlElement(Order = 2)]
		public string SupplierName
		{
			get
			{
				return this.supplierNameField;
			}
			set
			{
				this.supplierNameField = value;
				this.RaisePropertyChanged("SupplierName");
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
