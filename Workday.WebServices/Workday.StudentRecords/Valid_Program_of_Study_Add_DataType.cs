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
	public class Valid_Program_of_Study_Add_DataType : INotifyPropertyChanged
	{
		private Program_of_Study_TypeObjectType program_of_Study_Type_ReferenceField;

		private Program_of_StudyObjectType program_of_Study_ReferenceField;

		private DateTime declare_DateField;

		private DateTime expected_Completion_DateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Program_of_Study_TypeObjectType Program_of_Study_Type_Reference
		{
			get
			{
				return this.program_of_Study_Type_ReferenceField;
			}
			set
			{
				this.program_of_Study_Type_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Program_of_StudyObjectType Program_of_Study_Reference
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Declare_Date
		{
			get
			{
				return this.declare_DateField;
			}
			set
			{
				this.declare_DateField = value;
				this.RaisePropertyChanged("Declare_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Expected_Completion_Date
		{
			get
			{
				return this.expected_Completion_DateField;
			}
			set
			{
				this.expected_Completion_DateField = value;
				this.RaisePropertyChanged("Expected_Completion_Date");
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
