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
	public class Import_Process_MessageType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType import_Process_Message_ReferenceField;

		private Background_Process_Message_Data_WSType import_Process_Message_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Import_Process_Message_Reference
		{
			get
			{
				return this.import_Process_Message_ReferenceField;
			}
			set
			{
				this.import_Process_Message_ReferenceField = value;
				this.RaisePropertyChanged("Import_Process_Message_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Background_Process_Message_Data_WSType Import_Process_Message_Data
		{
			get
			{
				return this.import_Process_Message_DataField;
			}
			set
			{
				this.import_Process_Message_DataField = value;
				this.RaisePropertyChanged("Import_Process_Message_Data");
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
