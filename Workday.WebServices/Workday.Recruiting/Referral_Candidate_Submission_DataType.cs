using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Referral_Candidate_Submission_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType referred_By_Worker_ReferenceField;

		private Candidate_Name_DataType name_DataField;

		private Candidate_Contact_DataType contact_DataField;

		private Referral_Details_DataType referral_Details_DataField;

		private Candidate_Social_Media_Account_DataType[] social_Media_Account_DataField;

		private Refer_a_Candidate_Attachment_DataType[] resume_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Referred_By_Worker_Reference
		{
			get
			{
				return this.referred_By_Worker_ReferenceField;
			}
			set
			{
				this.referred_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Referred_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Candidate_Name_DataType Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Candidate_Contact_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Referral_Details_DataType Referral_Details_Data
		{
			get
			{
				return this.referral_Details_DataField;
			}
			set
			{
				this.referral_Details_DataField = value;
				this.RaisePropertyChanged("Referral_Details_Data");
			}
		}

		[XmlElement("Social_Media_Account_Data", Order = 4)]
		public Candidate_Social_Media_Account_DataType[] Social_Media_Account_Data
		{
			get
			{
				return this.social_Media_Account_DataField;
			}
			set
			{
				this.social_Media_Account_DataField = value;
				this.RaisePropertyChanged("Social_Media_Account_Data");
			}
		}

		[XmlElement("Resume_Attachment_Data", Order = 5)]
		public Refer_a_Candidate_Attachment_DataType[] Resume_Attachment_Data
		{
			get
			{
				return this.resume_Attachment_DataField;
			}
			set
			{
				this.resume_Attachment_DataField = value;
				this.RaisePropertyChanged("Resume_Attachment_Data");
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
