using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Import_Process_ResponseType : INotifyPropertyChanged
	{
		private Web_Service_Background_Process_RuntimeObjectType import_Process_ReferenceField;

		private InstanceObjectType header_Instance_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Web_Service_Background_Process_RuntimeObjectType Import_Process_Reference
		{
			get
			{
				return this.import_Process_ReferenceField;
			}
			set
			{
				this.import_Process_ReferenceField = value;
				this.RaisePropertyChanged("Import_Process_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public InstanceObjectType Header_Instance_Reference
		{
			get
			{
				return this.header_Instance_ReferenceField;
			}
			set
			{
				this.header_Instance_ReferenceField = value;
				this.RaisePropertyChanged("Header_Instance_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
