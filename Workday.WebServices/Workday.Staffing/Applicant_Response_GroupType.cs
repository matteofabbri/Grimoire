using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Applicant_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Personal_InformationField;

		private bool include_Personal_InformationFieldSpecified;

		private bool include_Recruiting_InformationField;

		private bool include_Recruiting_InformationFieldSpecified;

		private bool include_Qualification_ProfileField;

		private bool include_Qualification_ProfileFieldSpecified;

		private bool include_ResumeField;

		private bool include_ResumeFieldSpecified;

		private bool include_Background_CheckField;

		private bool include_Background_CheckFieldSpecified;

		private bool include_External_Integration_ID_DataField;

		private bool include_External_Integration_ID_DataFieldSpecified;

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
		public bool Include_Personal_Information
		{
			get
			{
				return this.include_Personal_InformationField;
			}
			set
			{
				this.include_Personal_InformationField = value;
				this.RaisePropertyChanged("Include_Personal_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Personal_InformationSpecified
		{
			get
			{
				return this.include_Personal_InformationFieldSpecified;
			}
			set
			{
				this.include_Personal_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Personal_InformationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Recruiting_Information
		{
			get
			{
				return this.include_Recruiting_InformationField;
			}
			set
			{
				this.include_Recruiting_InformationField = value;
				this.RaisePropertyChanged("Include_Recruiting_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Recruiting_InformationSpecified
		{
			get
			{
				return this.include_Recruiting_InformationFieldSpecified;
			}
			set
			{
				this.include_Recruiting_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Recruiting_InformationSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Qualification_Profile
		{
			get
			{
				return this.include_Qualification_ProfileField;
			}
			set
			{
				this.include_Qualification_ProfileField = value;
				this.RaisePropertyChanged("Include_Qualification_Profile");
			}
		}

		[XmlIgnore]
		public bool Include_Qualification_ProfileSpecified
		{
			get
			{
				return this.include_Qualification_ProfileFieldSpecified;
			}
			set
			{
				this.include_Qualification_ProfileFieldSpecified = value;
				this.RaisePropertyChanged("Include_Qualification_ProfileSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Resume
		{
			get
			{
				return this.include_ResumeField;
			}
			set
			{
				this.include_ResumeField = value;
				this.RaisePropertyChanged("Include_Resume");
			}
		}

		[XmlIgnore]
		public bool Include_ResumeSpecified
		{
			get
			{
				return this.include_ResumeFieldSpecified;
			}
			set
			{
				this.include_ResumeFieldSpecified = value;
				this.RaisePropertyChanged("Include_ResumeSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Background_Check
		{
			get
			{
				return this.include_Background_CheckField;
			}
			set
			{
				this.include_Background_CheckField = value;
				this.RaisePropertyChanged("Include_Background_Check");
			}
		}

		[XmlIgnore]
		public bool Include_Background_CheckSpecified
		{
			get
			{
				return this.include_Background_CheckFieldSpecified;
			}
			set
			{
				this.include_Background_CheckFieldSpecified = value;
				this.RaisePropertyChanged("Include_Background_CheckSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_External_Integration_ID_Data
		{
			get
			{
				return this.include_External_Integration_ID_DataField;
			}
			set
			{
				this.include_External_Integration_ID_DataField = value;
				this.RaisePropertyChanged("Include_External_Integration_ID_Data");
			}
		}

		[XmlIgnore]
		public bool Include_External_Integration_ID_DataSpecified
		{
			get
			{
				return this.include_External_Integration_ID_DataFieldSpecified;
			}
			set
			{
				this.include_External_Integration_ID_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_External_Integration_ID_DataSpecified");
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
