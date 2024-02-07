using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Course_Section_Component_for_Course_Section_for_Course_Offering_Set_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType student_Course_Section_Component_ReferenceField;

		private Standard_Meeting_PatternObjectType meeting_Pattern_ReferenceField;

		private LocationObjectType location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Student_Course_Section_Component_Reference
		{
			get
			{
				return this.student_Course_Section_Component_ReferenceField;
			}
			set
			{
				this.student_Course_Section_Component_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Section_Component_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Standard_Meeting_PatternObjectType Meeting_Pattern_Reference
		{
			get
			{
				return this.meeting_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Pattern_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
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
