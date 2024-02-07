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
	public class Default_Funding_Source_Request_ReferencesType : INotifyPropertyChanged
	{
		private Default_Funding_SourceObjectType[] default_Funding_Source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Default_Funding_Source_Reference", Order = 0)]
		public Default_Funding_SourceObjectType[] Default_Funding_Source_Reference
		{
			get
			{
				return this.default_Funding_Source_ReferenceField;
			}
			set
			{
				this.default_Funding_Source_ReferenceField = value;
				this.RaisePropertyChanged("Default_Funding_Source_Reference");
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
