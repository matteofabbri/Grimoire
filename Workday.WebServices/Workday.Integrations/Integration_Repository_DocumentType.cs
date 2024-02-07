using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Repository_DocumentType : INotifyPropertyChanged
	{
		private Integration_Repository_DocumentObjectType integration_Repository_Document_ReferenceField;

		private Integration_Repository_Document_DataType integration_Repository_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Repository_DocumentObjectType Integration_Repository_Document_Reference
		{
			get
			{
				return this.integration_Repository_Document_ReferenceField;
			}
			set
			{
				this.integration_Repository_Document_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Repository_Document_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_Repository_Document_DataType Integration_Repository_Document_Data
		{
			get
			{
				return this.integration_Repository_Document_DataField;
			}
			set
			{
				this.integration_Repository_Document_DataField = value;
				this.RaisePropertyChanged("Integration_Repository_Document_Data");
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
