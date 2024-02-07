using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Time_Off_Event_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType time_Off_Event_ReferenceField;

		private Time_Off_EntryObjectType[] time_Off_Entry_ReferencesField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Time_Off_Event_Reference
		{
			get
			{
				return this.time_Off_Event_ReferenceField;
			}
			set
			{
				this.time_Off_Event_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Event_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Time_Off_Entry_Reference", typeof(Time_Off_EntryObjectType), IsNullable = false)]
		public Time_Off_EntryObjectType[] Time_Off_Entry_References
		{
			get
			{
				return this.time_Off_Entry_ReferencesField;
			}
			set
			{
				this.time_Off_Entry_ReferencesField = value;
				this.RaisePropertyChanged("Time_Off_Entry_References");
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
