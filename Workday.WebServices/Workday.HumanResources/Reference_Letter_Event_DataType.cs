using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Reference_Letter_Event_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private User_LanguageObjectType document_Language_ReferenceField;

		private Reference_Letter_TemplateObjectType template_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public User_LanguageObjectType Document_Language_Reference
		{
			get
			{
				return this.document_Language_ReferenceField;
			}
			set
			{
				this.document_Language_ReferenceField = value;
				this.RaisePropertyChanged("Document_Language_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Reference_Letter_TemplateObjectType Template_Reference
		{
			get
			{
				return this.template_ReferenceField;
			}
			set
			{
				this.template_ReferenceField = value;
				this.RaisePropertyChanged("Template_Reference");
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
