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
	public class Student_Course_Registration_Record_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Course_SectionObjectType section_Listing_ReferenceField;

		private Registration_Record_StatusObjectType registration_Record_Status_ReferenceField;

		private DateTime registered_DateField;

		private bool registered_DateFieldSpecified;

		private DateTime waitlist_DateField;

		private bool waitlist_DateFieldSpecified;

		private DateTime unregistered_DateField;

		private bool unregistered_DateFieldSpecified;

		private DateTime withdrawal_DateField;

		private bool withdrawal_DateFieldSpecified;

		private DateTime completed_DateField;

		private bool completed_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Course_SectionObjectType Section_Listing_Reference
		{
			get
			{
				return this.section_Listing_ReferenceField;
			}
			set
			{
				this.section_Listing_ReferenceField = value;
				this.RaisePropertyChanged("Section_Listing_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Registration_Record_StatusObjectType Registration_Record_Status_Reference
		{
			get
			{
				return this.registration_Record_Status_ReferenceField;
			}
			set
			{
				this.registration_Record_Status_ReferenceField = value;
				this.RaisePropertyChanged("Registration_Record_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Registered_Date
		{
			get
			{
				return this.registered_DateField;
			}
			set
			{
				this.registered_DateField = value;
				this.RaisePropertyChanged("Registered_Date");
			}
		}

		[XmlIgnore]
		public bool Registered_DateSpecified
		{
			get
			{
				return this.registered_DateFieldSpecified;
			}
			set
			{
				this.registered_DateFieldSpecified = value;
				this.RaisePropertyChanged("Registered_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public DateTime Waitlist_Date
		{
			get
			{
				return this.waitlist_DateField;
			}
			set
			{
				this.waitlist_DateField = value;
				this.RaisePropertyChanged("Waitlist_Date");
			}
		}

		[XmlIgnore]
		public bool Waitlist_DateSpecified
		{
			get
			{
				return this.waitlist_DateFieldSpecified;
			}
			set
			{
				this.waitlist_DateFieldSpecified = value;
				this.RaisePropertyChanged("Waitlist_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Unregistered_Date
		{
			get
			{
				return this.unregistered_DateField;
			}
			set
			{
				this.unregistered_DateField = value;
				this.RaisePropertyChanged("Unregistered_Date");
			}
		}

		[XmlIgnore]
		public bool Unregistered_DateSpecified
		{
			get
			{
				return this.unregistered_DateFieldSpecified;
			}
			set
			{
				this.unregistered_DateFieldSpecified = value;
				this.RaisePropertyChanged("Unregistered_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Withdrawal_Date
		{
			get
			{
				return this.withdrawal_DateField;
			}
			set
			{
				this.withdrawal_DateField = value;
				this.RaisePropertyChanged("Withdrawal_Date");
			}
		}

		[XmlIgnore]
		public bool Withdrawal_DateSpecified
		{
			get
			{
				return this.withdrawal_DateFieldSpecified;
			}
			set
			{
				this.withdrawal_DateFieldSpecified = value;
				this.RaisePropertyChanged("Withdrawal_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Completed_Date
		{
			get
			{
				return this.completed_DateField;
			}
			set
			{
				this.completed_DateField = value;
				this.RaisePropertyChanged("Completed_Date");
			}
		}

		[XmlIgnore]
		public bool Completed_DateSpecified
		{
			get
			{
				return this.completed_DateFieldSpecified;
			}
			set
			{
				this.completed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completed_DateSpecified");
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
