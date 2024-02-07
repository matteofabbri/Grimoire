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
	public class Student_Request_CriteriaType : INotifyPropertyChanged
	{
		private Academic_UnitObjectType[] academic_Unit_ReferenceField;

		private Academic_LevelObjectType[] academic_Level_ReferenceField;

		private Program_of_StudyObjectType[] program_of_Study_ReferenceField;

		private string universal_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Academic_Unit_Reference", Order = 0)]
		public Academic_UnitObjectType[] Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement("Academic_Level_Reference", Order = 1)]
		public Academic_LevelObjectType[] Academic_Level_Reference
		{
			get
			{
				return this.academic_Level_ReferenceField;
			}
			set
			{
				this.academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Level_Reference");
			}
		}

		[XmlElement("Program_of_Study_Reference", Order = 2)]
		public Program_of_StudyObjectType[] Program_of_Study_Reference
		{
			get
			{
				return this.program_of_Study_ReferenceField;
			}
			set
			{
				this.program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Universal_ID
		{
			get
			{
				return this.universal_IDField;
			}
			set
			{
				this.universal_IDField = value;
				this.RaisePropertyChanged("Universal_ID");
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
