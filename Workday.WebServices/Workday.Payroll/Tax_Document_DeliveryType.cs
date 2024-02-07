using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_Document_DeliveryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType tax_Document_Delivery_ReferenceField;

		private Tax_Document_Delivery_DataType[] tax_Document_Delivery_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Tax_Document_Delivery_Reference
		{
			get
			{
				return this.tax_Document_Delivery_ReferenceField;
			}
			set
			{
				this.tax_Document_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Document_Delivery_Reference");
			}
		}

		[XmlElement("Tax_Document_Delivery_Data", Order = 1)]
		public Tax_Document_Delivery_DataType[] Tax_Document_Delivery_Data
		{
			get
			{
				return this.tax_Document_Delivery_DataField;
			}
			set
			{
				this.tax_Document_Delivery_DataField = value;
				this.RaisePropertyChanged("Tax_Document_Delivery_Data");
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
