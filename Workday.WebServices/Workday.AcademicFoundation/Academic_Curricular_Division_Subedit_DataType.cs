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
	public class Academic_Curricular_Division_Subedit_DataType : INotifyPropertyChanged
	{
		private Academic_LevelObjectType academic_Level_ReferenceField;

		private Academic_Curricular_DivisionObjectType academic_Unit_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_LevelObjectType Academic_Level_Reference
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

		[XmlElement(Order = 1)]
		public Academic_Curricular_DivisionObjectType Academic_Unit_Reference
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
