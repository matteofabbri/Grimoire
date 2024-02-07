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
	public class Section_Listing_for_Course_Section_for_Course_Offering_Set_DataType : INotifyPropertyChanged
	{
		private Course_ListingObjectType course_Listing_ReferenceField;

		private string section_NumberField;

		private decimal offering_IDField;

		private bool offering_IDFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_ListingObjectType Course_Listing_Reference
		{
			get
			{
				return this.course_Listing_ReferenceField;
			}
			set
			{
				this.course_Listing_ReferenceField = value;
				this.RaisePropertyChanged("Course_Listing_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Section_Number
		{
			get
			{
				return this.section_NumberField;
			}
			set
			{
				this.section_NumberField = value;
				this.RaisePropertyChanged("Section_Number");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Offering_ID
		{
			get
			{
				return this.offering_IDField;
			}
			set
			{
				this.offering_IDField = value;
				this.RaisePropertyChanged("Offering_ID");
			}
		}

		[XmlIgnore]
		public bool Offering_IDSpecified
		{
			get
			{
				return this.offering_IDFieldSpecified;
			}
			set
			{
				this.offering_IDFieldSpecified = value;
				this.RaisePropertyChanged("Offering_IDSpecified");
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
