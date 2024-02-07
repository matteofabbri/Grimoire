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
	public class Default_Funding_SourceType : INotifyPropertyChanged
	{
		private Default_Funding_SourceObjectType default_Funding_Source_ReferenceField;

		private Default_Funding_Source_DataType[] default_Funding_Source_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Default_Funding_SourceObjectType Default_Funding_Source_Reference
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

		[XmlElement("Default_Funding_Source_Data", Order = 1)]
		public Default_Funding_Source_DataType[] Default_Funding_Source_Data
		{
			get
			{
				return this.default_Funding_Source_DataField;
			}
			set
			{
				this.default_Funding_Source_DataField = value;
				this.RaisePropertyChanged("Default_Funding_Source_Data");
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
