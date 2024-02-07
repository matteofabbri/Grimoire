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
	public class Course_Subject_DataType : INotifyPropertyChanged
	{
		private string abbreviationField;

		private Academic_UnitObjectType[] has_Institution_Academic_Unit_DataField;

		private string course_Subject_NameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Abbreviation
		{
			get
			{
				return this.abbreviationField;
			}
			set
			{
				this.abbreviationField = value;
				this.RaisePropertyChanged("Abbreviation");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Academic_Unit_Reference", IsNullable = false)]
		public Academic_UnitObjectType[] Has_Institution_Academic_Unit_Data
		{
			get
			{
				return this.has_Institution_Academic_Unit_DataField;
			}
			set
			{
				this.has_Institution_Academic_Unit_DataField = value;
				this.RaisePropertyChanged("Has_Institution_Academic_Unit_Data");
			}
		}

		[XmlElement(Order = 2)]
		public string Course_Subject_Name
		{
			get
			{
				return this.course_Subject_NameField;
			}
			set
			{
				this.course_Subject_NameField = value;
				this.RaisePropertyChanged("Course_Subject_Name");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
