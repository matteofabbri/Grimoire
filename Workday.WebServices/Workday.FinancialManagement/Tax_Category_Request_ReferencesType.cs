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
	public class Tax_Category_Request_ReferencesType : INotifyPropertyChanged
	{
		private Tax_CategoryObjectType[] tax_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Tax_Category_Reference", Order = 0)]
		public Tax_CategoryObjectType[] Tax_Category_Reference
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
