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
	public class Event_DocumentsType : INotifyPropertyChanged
	{
		private Integration_Event__Abstract_ObjectType integration_Event_ReferenceField;

		private Repository_Document_Summary_DataType[] repository_DocumentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Event__Abstract_ObjectType Integration_Event_Reference
		{
			get
			{
				return this.integration_Event_ReferenceField;
			}
			set
			{
				this.integration_Event_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Event_Reference");
			}
		}

		[XmlElement("Repository_Document", Order = 1)]
		public Repository_Document_Summary_DataType[] Repository_Document
		{
			get
			{
				return this.repository_DocumentField;
			}
			set
			{
				this.repository_DocumentField = value;
				this.RaisePropertyChanged("Repository_Document");
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
