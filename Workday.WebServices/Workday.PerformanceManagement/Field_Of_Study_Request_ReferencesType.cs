using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Field_Of_Study_Request_ReferencesType : INotifyPropertyChanged
	{
		private Field_of_StudyObjectType[] field_Of_Study_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Field_Of_Study_Reference", Order = 0)]
		public Field_of_StudyObjectType[] Field_Of_Study_Reference
		{
			get
			{
				return this.field_Of_Study_ReferenceField;
			}
			set
			{
				this.field_Of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Field_Of_Study_Reference");
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
