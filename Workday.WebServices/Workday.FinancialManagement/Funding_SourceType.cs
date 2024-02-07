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
	public class Funding_SourceType : INotifyPropertyChanged
	{
		private Funding_SourceObjectType funding_Source_ReferenceField;

		private Funding_Source_DataType funding_Source_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Funding_SourceObjectType Funding_Source_Reference
		{
			get
			{
				return this.funding_Source_ReferenceField;
			}
			set
			{
				this.funding_Source_ReferenceField = value;
				this.RaisePropertyChanged("Funding_Source_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Funding_Source_DataType Funding_Source_Data
		{
			get
			{
				return this.funding_Source_DataField;
			}
			set
			{
				this.funding_Source_DataField = value;
				this.RaisePropertyChanged("Funding_Source_Data");
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
