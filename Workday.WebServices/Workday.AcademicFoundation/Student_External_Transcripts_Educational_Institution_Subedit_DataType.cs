using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_Transcripts_Educational_Institution_Subedit_DataType : INotifyPropertyChanged
	{
		private string nameField;

		private Educational_Institution_School_LevelObjectType educational_Institution_School_Level_ReferenceField;

		private Educational_Institution_w25_ID_DataType[] educational_Institution_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 1)]
		public Educational_Institution_School_LevelObjectType Educational_Institution_School_Level_Reference
		{
			get
			{
				return this.educational_Institution_School_Level_ReferenceField;
			}
			set
			{
				this.educational_Institution_School_Level_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_School_Level_Reference");
			}
		}

		[XmlElement("Educational_Institution_ID_Data", Order = 2)]
		public Educational_Institution_w25_ID_DataType[] Educational_Institution_ID_Data
		{
			get
			{
				return this.educational_Institution_ID_DataField;
			}
			set
			{
				this.educational_Institution_ID_DataField = value;
				this.RaisePropertyChanged("Educational_Institution_ID_Data");
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
