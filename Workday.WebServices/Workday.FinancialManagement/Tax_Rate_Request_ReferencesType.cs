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
	public class Tax_Rate_Request_ReferencesType : INotifyPropertyChanged
	{
		private Tax_RateObjectType[] tax_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Tax_Rate_Reference", Order = 0)]
		public Tax_RateObjectType[] Tax_Rate_Reference
		{
			get
			{
				return this.tax_Rate_ReferenceField;
			}
			set
			{
				this.tax_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Rate_Reference");
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
