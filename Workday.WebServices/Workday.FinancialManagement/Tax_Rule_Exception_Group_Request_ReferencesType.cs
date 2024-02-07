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
	public class Tax_Rule_Exception_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Tax_Rule_Exception_GroupObjectType[] tax_Rule_Exception_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Tax_Rule_Exception_Group_Reference", Order = 0)]
		public Tax_Rule_Exception_GroupObjectType[] Tax_Rule_Exception_Group_Reference
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
