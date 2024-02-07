using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Course_Equivalency_Group_RequestType : INotifyPropertyChanged
	{
		private Course_Equivalency_GroupObjectType course_Equivalency_Group_ReferenceField;

		private Course_Equivalency_Group_DataType course_Equivalency_Group_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_Equivalency_GroupObjectType Course_Equivalency_Group_Reference
		{
			get
			{
				return this.course_Equivalency_Group_ReferenceField;
			}
			set
			{
				this.course_Equivalency_Group_ReferenceField = value;
				this.RaisePropertyChanged("Course_Equivalency_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Course_Equivalency_Group_DataType Course_Equivalency_Group_Data
		{
			get
			{
				return this.course_Equivalency_Group_DataField;
			}
			set
			{
				this.course_Equivalency_Group_DataField = value;
				this.RaisePropertyChanged("Course_Equivalency_Group_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
