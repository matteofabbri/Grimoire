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
	public class Repository_Document_Summary_DataType : INotifyPropertyChanged
	{
		private Repository_DocumentObjectType repository_Document_ReferenceField;

		private Integration_Repository_Document_DataType[] repository_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Repository_DocumentObjectType Repository_Document_Reference
		{
			get
			{
				return this.repository_Document_ReferenceField;
			}
			set
			{
				this.repository_Document_ReferenceField = value;
				this.RaisePropertyChanged("Repository_Document_Reference");
			}
		}

		[XmlElement("Repository_Document_Data", Order = 1)]
		public Integration_Repository_Document_DataType[] Repository_Document_Data
		{
			get
			{
				return this.repository_Document_DataField;
			}
			set
			{
				this.repository_Document_DataField = value;
				this.RaisePropertyChanged("Repository_Document_Data");
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
