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
	public class Field_Of_StudyType : INotifyPropertyChanged
	{
		private Field_of_StudyObjectType field_Of_Study_ReferenceField;

		private Field_Of_Study_DataType field_Of_Study_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Field_of_StudyObjectType Field_Of_Study_Reference
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

		[XmlElement(Order = 1)]
		public Field_Of_Study_DataType Field_Of_Study_Data
		{
			get
			{
				return this.field_Of_Study_DataField;
			}
			set
			{
				this.field_Of_Study_DataField = value;
				this.RaisePropertyChanged("Field_Of_Study_Data");
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
