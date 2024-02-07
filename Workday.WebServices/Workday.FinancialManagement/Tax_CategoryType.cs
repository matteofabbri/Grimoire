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
	public class Tax_CategoryType : INotifyPropertyChanged
	{
		private Tax_CategoryObjectType tax_Category_ReferenceField;

		private Tax_Category_DataType[] tax_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_CategoryObjectType Tax_Category_Reference
		{
			get
			{
				return this.tax_Category_ReferenceField;
			}
			set
			{
				this.tax_Category_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Category_Reference");
			}
		}

		[XmlElement("Tax_Category_Data", Order = 1)]
		public Tax_Category_DataType[] Tax_Category_Data
		{
			get
			{
				return this.tax_Category_DataField;
			}
			set
			{
				this.tax_Category_DataField = value;
				this.RaisePropertyChanged("Tax_Category_Data");
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
