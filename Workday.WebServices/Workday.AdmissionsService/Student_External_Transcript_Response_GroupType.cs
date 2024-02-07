using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_Transcript_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Person_DataField;

		private bool include_Person_DataFieldSpecified;

		private bool include_Postsecondary_Summary_DataField;

		private bool include_Postsecondary_Summary_DataFieldSpecified;

		private bool include_Secondary_Summary_DataField;

		private bool include_Secondary_Summary_DataFieldSpecified;

		private bool include_External_Credential_DataField;

		private bool include_External_Credential_DataFieldSpecified;

		private bool include_Course_History_DataField;

		private bool include_Course_History_DataFieldSpecified;

		private bool include_Attachment_DataField;

		private bool include_Attachment_DataFieldSpecified;

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
		public bool Include_Postsecondary_Summary_Data
		{
			get
			{
				return this.include_Postsecondary_Summary_DataField;
			}
			set
			{
				this.include_Postsecondary_Summary_DataField = value;
				this.RaisePropertyChanged("Include_Postsecondary_Summary_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Postsecondary_Summary_DataSpecified
		{
			get
			{
				return this.include_Postsecondary_Summary_DataFieldSpecified;
			}
			set
			{
				this.include_Postsecondary_Summary_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Postsecondary_Summary_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Secondary_Summary_Data
		{
			get
			{
				return this.include_Secondary_Summary_DataField;
			}
			set
			{
				this.include_Secondary_Summary_DataField = value;
				this.RaisePropertyChanged("Include_Secondary_Summary_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Secondary_Summary_DataSpecified
		{
			get
			{
				return this.include_Secondary_Summary_DataFieldSpecified;
			}
			set
			{
				this.include_Secondary_Summary_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Secondary_Summary_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_External_Credential_Data
		{
			get
			{
				return this.include_External_Credential_DataField;
			}
			set
			{
				this.include_External_Credential_DataField = value;
				this.RaisePropertyChanged("Include_External_Credential_Data");
			}
		}

		[XmlIgnore]
		public bool Include_External_Credential_DataSpecified
		{
			get
			{
				return this.include_External_Credential_DataFieldSpecified;
			}
			set
			{
				this.include_External_Credential_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_External_Credential_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Course_History_Data
		{
			get
			{
				return this.include_Course_History_DataField;
			}
			set
			{
				this.include_Course_History_DataField = value;
				this.RaisePropertyChanged("Include_Course_History_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Course_History_DataSpecified
		{
			get
			{
				return this.include_Course_History_DataFieldSpecified;
			}
			set
			{
				this.include_Course_History_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Course_History_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Attachment_Data
		{
			get
			{
				return this.include_Attachment_DataField;
			}
			set
			{
				this.include_Attachment_DataField = value;
				this.RaisePropertyChanged("Include_Attachment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Attachment_DataSpecified
		{
			get
			{
				return this.include_Attachment_DataFieldSpecified;
			}
			set
			{
				this.include_Attachment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Attachment_DataSpecified");
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
