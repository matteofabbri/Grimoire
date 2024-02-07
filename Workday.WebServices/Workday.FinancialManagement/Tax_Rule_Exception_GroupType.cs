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
	public class Tax_Rule_Exception_GroupType : INotifyPropertyChanged
	{
		private Tax_Rule_Exception_GroupObjectType tax_Rule_Exception_Group_ReferenceField;

		private Tax_Rule_Exception_Group_DataType[] tax_Rule_Exception_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_Rule_Exception_GroupObjectType Tax_Rule_Exception_Group_Reference
		{
			get
			{
				return this.tax_Rule_Exception_Group_ReferenceField;
			}
			set
			{
				this.tax_Rule_Exception_Group_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Rule_Exception_Group_Reference");
			}
		}

		[XmlElement("Tax_Rule_Exception_Group_Data", Order = 1)]
		public Tax_Rule_Exception_Group_DataType[] Tax_Rule_Exception_Group_Data
		{
			get
			{
				return this.tax_Rule_Exception_Group_DataField;
			}
			set
			{
				this.tax_Rule_Exception_Group_DataField = value;
				this.RaisePropertyChanged("Tax_Rule_Exception_Group_Data");
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
