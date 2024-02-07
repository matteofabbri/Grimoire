using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Prospective_Student_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Person_DataField;

		private bool include_Person_DataFieldSpecified;

		private bool include_Personal_Portfolio_DataField;

		private bool include_Personal_Portfolio_DataFieldSpecified;

		private bool include_Personal_Information_DataField;

		private bool include_Personal_Information_DataFieldSpecified;

		private bool include_School_DataField;

		private bool include_School_DataFieldSpecified;

		private bool include_Recruitment_DataField;

		private bool include_Recruitment_DataFieldSpecified;

		private bool include_Application_DataField;

		private bool include_Application_DataFieldSpecified;

		private bool include_Education_Test_DataField;

		private bool include_Education_Test_DataFieldSpecified;

		private bool include_Transcript_DataField;

		private bool include_Transcript_DataFieldSpecified;

		private bool include_Proxy_DataField;

		private bool include_Proxy_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Person_Data
		{
			get
			{
				return this.include_Person_DataField;
			}
			set
			{
				this.include_Person_DataField = value;
				this.RaisePropertyChanged("Include_Person_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Person_DataSpecified
		{
			get
			{
				return this.include_Person_DataFieldSpecified;
			}
			set
			{
				this.include_Person_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Person_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Personal_Portfolio_Data
		{
			get
			{
				return this.include_Personal_Portfolio_DataField;
			}
			set
			{
				this.include_Personal_Portfolio_DataField = value;
				this.RaisePropertyChanged("Include_Personal_Portfolio_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Personal_Portfolio_DataSpecified
		{
			get
			{
				return this.include_Personal_Portfolio_DataFieldSpecified;
			}
			set
			{
				this.include_Personal_Portfolio_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Personal_Portfolio_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Personal_Information_Data
		{
			get
			{
				return this.include_Personal_Information_DataField;
			}
			set
			{
				this.include_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Include_Personal_Information_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Personal_Information_DataSpecified
		{
			get
			{
				return this.include_Personal_Information_DataFieldSpecified;
			}
			set
			{
				this.include_Personal_Information_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Personal_Information_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_School_Data
		{
			get
			{
				return this.include_School_DataField;
			}
			set
			{
				this.include_School_DataField = value;
				this.RaisePropertyChanged("Include_School_Data");
			}
		}

		[XmlIgnore]
		public bool Include_School_DataSpecified
		{
			get
			{
				return this.include_School_DataFieldSpecified;
			}
			set
			{
				this.include_School_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_School_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Recruitment_Data
		{
			get
			{
				return this.include_Recruitment_DataField;
			}
			set
			{
				this.include_Recruitment_DataField = value;
				this.RaisePropertyChanged("Include_Recruitment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Recruitment_DataSpecified
		{
			get
			{
				return this.include_Recruitment_DataFieldSpecified;
			}
			set
			{
				this.include_Recruitment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Recruitment_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Application_Data
		{
			get
			{
				return this.include_Application_DataField;
			}
			set
			{
				this.include_Application_DataField = value;
				this.RaisePropertyChanged("Include_Application_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Application_DataSpecified
		{
			get
			{
				return this.include_Application_DataFieldSpecified;
			}
			set
			{
				this.include_Application_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Application_DataSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Include_Education_Test_Data
		{
			get
			{
				return this.include_Education_Test_DataField;
			}
			set
			{
				this.include_Education_Test_DataField = value;
				this.RaisePropertyChanged("Include_Education_Test_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Education_Test_DataSpecified
		{
			get
			{
				return this.include_Education_Test_DataFieldSpecified;
			}
			set
			{
				this.include_Education_Test_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Education_Test_DataSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_Transcript_Data
		{
			get
			{
				return this.include_Transcript_DataField;
			}
			set
			{
				this.include_Transcript_DataField = value;
				this.RaisePropertyChanged("Include_Transcript_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Transcript_DataSpecified
		{
			get
			{
				return this.include_Transcript_DataFieldSpecified;
			}
			set
			{
				this.include_Transcript_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Transcript_DataSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Include_Proxy_Data
		{
			get
			{
				return this.include_Proxy_DataField;
			}
			set
			{
				this.include_Proxy_DataField = value;
				this.RaisePropertyChanged("Include_Proxy_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Proxy_DataSpecified
		{
			get
			{
				return this.include_Proxy_DataFieldSpecified;
			}
			set
			{
				this.include_Proxy_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Proxy_DataSpecified");
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
