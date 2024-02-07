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
	public class Tax_Rule_Exception_Group_DataType : INotifyPropertyChanged
	{
		private string tax_Rule_Exception_Group_IDField;

		private string tax_Rule_Exception_Group_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Rule_Exception_Group_ID
		{
			get
			{
				return this.tax_Rule_Exception_Group_IDField;
			}
			set
			{
				this.tax_Rule_Exception_Group_IDField = value;
				this.RaisePropertyChanged("Tax_Rule_Exception_Group_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Rule_Exception_Group_Name
		{
			get
			{
				return this.tax_Rule_Exception_Group_NameField;
			}
			set
			{
				this.tax_Rule_Exception_Group_NameField = value;
				this.RaisePropertyChanged("Tax_Rule_Exception_Group_Name");
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
