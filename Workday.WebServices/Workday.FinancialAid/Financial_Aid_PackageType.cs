using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Financial_Aid_PackageType : INotifyPropertyChanged
	{
		private Financial_Aid_PackageObjectType financial_Aid_Package_ReferenceField;

		private Financial_Aid_Package_DataType[] financial_Aid_Package_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Financial_Aid_PackageObjectType Financial_Aid_Package_Reference
		{
			get
			{
				return this.financial_Aid_Package_ReferenceField;
			}
			set
			{
				this.financial_Aid_Package_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Aid_Package_Reference");
			}
		}

		[XmlElement("Financial_Aid_Package_Data", Order = 1)]
		public Financial_Aid_Package_DataType[] Financial_Aid_Package_Data
		{
			get
			{
				return this.financial_Aid_Package_DataField;
			}
			set
			{
				this.financial_Aid_Package_DataField = value;
				this.RaisePropertyChanged("Financial_Aid_Package_Data");
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
