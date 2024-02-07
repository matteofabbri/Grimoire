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
	public class Referral_Details_DataType : INotifyPropertyChanged
	{
		private Job_Requisition_EnabledObjectType[] job_Requisition_ReferenceField;

		private Job_FamilyObjectType[] job_Areas_ReferenceField;

		private Referral_RelationshipObjectType referral_Relationship_ReferenceField;

		private string commentField;

		private bool referral_Consent_GivenField;

		private bool referral_Consent_GivenFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Job_Requisition_Reference", Order = 0)]
		public Job_Requisition_EnabledObjectType[] Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement("Job_Areas_Reference", Order = 1)]
		public Job_FamilyObjectType[] Job_Areas_Reference
		{
			get
			{
				return this.job_Areas_ReferenceField;
			}
			set
			{
				this.job_Areas_ReferenceField = value;
				this.RaisePropertyChanged("Job_Areas_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Referral_RelationshipObjectType Referral_Relationship_Reference
		{
			get
			{
				return this.referral_Relationship_ReferenceField;
			}
			set
			{
				this.referral_Relationship_ReferenceField = value;
				this.RaisePropertyChanged("Referral_Relationship_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement(Order = 4)]
		public bool Referral_Consent_Given
		{
			get
			{
				return this.referral_Consent_GivenField;
			}
			set
			{
				this.referral_Consent_GivenField = value;
				this.RaisePropertyChanged("Referral_Consent_Given");
			}
		}

		[XmlIgnore]
		public bool Referral_Consent_GivenSpecified
		{
			get
			{
				return this.referral_Consent_GivenFieldSpecified;
			}
			set
			{
				this.referral_Consent_GivenFieldSpecified = value;
				this.RaisePropertyChanged("Referral_Consent_GivenSpecified");
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
