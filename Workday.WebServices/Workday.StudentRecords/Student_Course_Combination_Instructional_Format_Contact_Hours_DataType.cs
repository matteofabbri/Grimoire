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
	public class Student_Course_Combination_Instructional_Format_Contact_Hours_DataType : INotifyPropertyChanged
	{
		private Instructional_FormatObjectType combination_Instructional_Format_ReferenceField;

		private decimal combination_Instructional_Format_Contact_HoursField;

		private bool combination_Instructional_Format_Contact_HoursFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Instructional_FormatObjectType Combination_Instructional_Format_Reference
		{
			get
			{
				return this.combination_Instructional_Format_ReferenceField;
			}
			set
			{
				this.combination_Instructional_Format_ReferenceField = value;
				this.RaisePropertyChanged("Combination_Instructional_Format_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Combination_Instructional_Format_Contact_Hours
		{
			get
			{
				return this.combination_Instructional_Format_Contact_HoursField;
			}
			set
			{
				this.combination_Instructional_Format_Contact_HoursField = value;
				this.RaisePropertyChanged("Combination_Instructional_Format_Contact_Hours");
			}
		}

		[XmlIgnore]
		public bool Combination_Instructional_Format_Contact_HoursSpecified
		{
			get
			{
				return this.combination_Instructional_Format_Contact_HoursFieldSpecified;
			}
			set
			{
				this.combination_Instructional_Format_Contact_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Combination_Instructional_Format_Contact_HoursSpecified");
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
