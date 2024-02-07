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
	public class Student_Articulation_Rule_Request_CriteriaType : INotifyPropertyChanged
	{
		private Academic_UnitObjectType institution_Academic_Unit_ReferenceField;

		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_UnitObjectType Institution_Academic_Unit_Reference
		{
			get
			{
				return this.institution_Academic_Unit_ReferenceField;
			}
			set
			{
				this.institution_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Institution_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Educational_InstitutionObjectType Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
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
