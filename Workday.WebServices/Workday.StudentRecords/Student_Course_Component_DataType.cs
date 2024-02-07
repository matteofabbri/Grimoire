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
	public class Student_Course_Component_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType student_Course_Component_ReferenceField;

		private Instructional_FormatObjectType instructional_Format_ReferenceField;

		private bool required_Student_Course_ComponentField;

		private bool required_Student_Course_ComponentFieldSpecified;

		private Delivery_ModeObjectType[] delivery_Mode_ReferenceField;

		private bool student_Course_Component_Controls_GradingField;

		private bool student_Course_Component_Controls_GradingFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Student_Course_Component_Reference
		{
			get
			{
				return this.student_Course_Component_ReferenceField;
			}
			set
			{
				this.student_Course_Component_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Component_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Instructional_FormatObjectType Instructional_Format_Reference
		{
			get
			{
				return this.instructional_Format_ReferenceField;
			}
			set
			{
				this.instructional_Format_ReferenceField = value;
				this.RaisePropertyChanged("Instructional_Format_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Required_Student_Course_Component
		{
			get
			{
				return this.required_Student_Course_ComponentField;
			}
			set
			{
				this.required_Student_Course_ComponentField = value;
				this.RaisePropertyChanged("Required_Student_Course_Component");
			}
		}

		[XmlIgnore]
		public bool Required_Student_Course_ComponentSpecified
		{
			get
			{
				return this.required_Student_Course_ComponentFieldSpecified;
			}
			set
			{
				this.required_Student_Course_ComponentFieldSpecified = value;
				this.RaisePropertyChanged("Required_Student_Course_ComponentSpecified");
			}
		}

		[XmlElement("Delivery_Mode_Reference", Order = 3)]
		public Delivery_ModeObjectType[] Delivery_Mode_Reference
		{
			get
			{
				return this.delivery_Mode_ReferenceField;
			}
			set
			{
				this.delivery_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Mode_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Student_Course_Component_Controls_Grading
		{
			get
			{
				return this.student_Course_Component_Controls_GradingField;
			}
			set
			{
				this.student_Course_Component_Controls_GradingField = value;
				this.RaisePropertyChanged("Student_Course_Component_Controls_Grading");
			}
		}

		[XmlIgnore]
		public bool Student_Course_Component_Controls_GradingSpecified
		{
			get
			{
				return this.student_Course_Component_Controls_GradingFieldSpecified;
			}
			set
			{
				this.student_Course_Component_Controls_GradingFieldSpecified = value;
				this.RaisePropertyChanged("Student_Course_Component_Controls_GradingSpecified");
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
