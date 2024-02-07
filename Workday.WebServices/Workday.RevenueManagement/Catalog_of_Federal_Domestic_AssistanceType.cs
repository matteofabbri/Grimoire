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
	public class Catalog_of_Federal_Domestic_AssistanceType : INotifyPropertyChanged
	{
		private Catalog_of_Federal_Domestic_AssistanceObjectType catalog_of_Federal_Domestic_Assistance_ReferenceField;

		private Catalog_of_Federal_Domestic_Assistance_DataType[] catalog_of_Federal_Domestic_Assistance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Catalog_of_Federal_Domestic_AssistanceObjectType Catalog_of_Federal_Domestic_Assistance_Reference
		{
			get
			{
				return this.catalog_of_Federal_Domestic_Assistance_ReferenceField;
			}
			set
			{
				this.catalog_of_Federal_Domestic_Assistance_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_of_Federal_Domestic_Assistance_Reference");
			}
		}

		[XmlElement("Catalog_of_Federal_Domestic_Assistance_Data", Order = 1)]
		public Catalog_of_Federal_Domestic_Assistance_DataType[] Catalog_of_Federal_Domestic_Assistance_Data
		{
			get
			{
				return this.catalog_of_Federal_Domestic_Assistance_DataField;
			}
			set
			{
				this.catalog_of_Federal_Domestic_Assistance_DataField = value;
				this.RaisePropertyChanged("Catalog_of_Federal_Domestic_Assistance_Data");
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
