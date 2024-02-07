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
	public class Student_Course_Tag_Category_Request_CriteriaType : INotifyPropertyChanged
	{
		private Academic_UnitObjectType[] academic_Unit_ReferenceField;

		private bool private_Course_Tag_CategoryField;

		private bool private_Course_Tag_CategoryFieldSpecified;

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

		[XmlElement(Order = 1)]
		public bool Private_Course_Tag_Category
		{
			get
			{
				return this.private_Course_Tag_CategoryField;
			}
			set
			{
				this.private_Course_Tag_CategoryField = value;
				this.RaisePropertyChanged("Private_Course_Tag_Category");
			}
		}

		[XmlIgnore]
		public bool Private_Course_Tag_CategorySpecified
		{
			get
			{
				return this.private_Course_Tag_CategoryFieldSpecified;
			}
			set
			{
				this.private_Course_Tag_CategoryFieldSpecified = value;
				this.RaisePropertyChanged("Private_Course_Tag_CategorySpecified");
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
