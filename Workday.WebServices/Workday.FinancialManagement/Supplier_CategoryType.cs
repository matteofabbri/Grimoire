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
	public class Supplier_CategoryType : INotifyPropertyChanged
	{
		private Supplier_CategoryObjectType supplier_Category_ReferenceField;

		private Supplier_Category_DataType[] supplier_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_CategoryObjectType Supplier_Category_Reference
		{
			get
			{
				return this.supplier_Category_ReferenceField;
			}
			set
			{
				this.supplier_Category_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Category_Reference");
			}
		}

		[XmlElement("Supplier_Category_Data", Order = 1)]
		public Supplier_Category_DataType[] Supplier_Category_Data
		{
			get
			{
				return this.supplier_Category_DataField;
			}
			set
			{
				this.supplier_Category_DataField = value;
				this.RaisePropertyChanged("Supplier_Category_Data");
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
