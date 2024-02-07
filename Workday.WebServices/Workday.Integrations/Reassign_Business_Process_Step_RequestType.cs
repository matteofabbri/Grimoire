using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Reassign_Business_Process_Step_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType event_Record_ReferenceField;

		private Reassign_Business_Process_Step_DataType reassign_Business_Process_Step_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Event_Record_Reference
		{
			get
			{
				return this.event_Record_ReferenceField;
			}
			set
			{
				this.event_Record_ReferenceField = value;
				this.RaisePropertyChanged("Event_Record_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Reassign_Business_Process_Step_DataType Reassign_Business_Process_Step_Data
		{
			get
			{
				return this.reassign_Business_Process_Step_DataField;
			}
			set
			{
				this.reassign_Business_Process_Step_DataField = value;
				this.RaisePropertyChanged("Reassign_Business_Process_Step_Data");
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
