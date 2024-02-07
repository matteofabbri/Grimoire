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
	public class Import_ProcessType : INotifyPropertyChanged
	{
		private Web_Service_Background_Process_RuntimeObjectType import_Process_ReferenceField;

		private Import_Process_DataType import_Process_DataField;

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
		public Import_Process_DataType Import_Process_Data
		{
			get
			{
				return this.import_Process_DataField;
			}
			set
			{
				this.import_Process_DataField = value;
				this.RaisePropertyChanged("Import_Process_Data");
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
