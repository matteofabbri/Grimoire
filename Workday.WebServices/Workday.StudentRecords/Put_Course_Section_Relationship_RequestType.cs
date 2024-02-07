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
	public class Put_Course_Section_Relationship_RequestType : INotifyPropertyChanged
	{
		private Student_Course_Section_ClusterObjectType course_Section_Relationship_ReferenceField;

		private Student_Course_Section_Cluster_DataType course_Section_Relationship_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Course_Section_ClusterObjectType Course_Section_Relationship_Reference
		{
			get
			{
				return this.course_Section_Relationship_ReferenceField;
			}
			set
			{
				this.course_Section_Relationship_ReferenceField = value;
				this.RaisePropertyChanged("Course_Section_Relationship_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Course_Section_Cluster_DataType Course_Section_Relationship_Data
		{
			get
			{
				return this.course_Section_Relationship_DataField;
			}
			set
			{
				this.course_Section_Relationship_DataField = value;
				this.RaisePropertyChanged("Course_Section_Relationship_Data");
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
