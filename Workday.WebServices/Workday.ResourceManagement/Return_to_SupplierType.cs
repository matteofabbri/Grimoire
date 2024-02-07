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
	public class Return_to_SupplierType : INotifyPropertyChanged
	{
		private Return_to_SupplierObjectType return_ReferenceField;

		private Return_to_Supplier_DataType return_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Return_to_SupplierObjectType Return_Reference
		{
			get
			{
				return this.return_ReferenceField;
			}
			set
			{
				this.return_ReferenceField = value;
				this.RaisePropertyChanged("Return_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Return_to_Supplier_DataType Return_Data
		{
			get
			{
				return this.return_DataField;
			}
			set
			{
				this.return_DataField = value;
				this.RaisePropertyChanged("Return_Data");
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
