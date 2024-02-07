using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Proposal_Submission_TypeType : INotifyPropertyChanged
	{
		private Award_Proposal_Submission_TypeObjectType award_Proposal_Submission_Type_ReferenceField;

		private Award_Proposal_Submission_Type_DataType[] award_Proposal_Submission_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Proposal_Submission_TypeObjectType Award_Proposal_Submission_Type_Reference
		{
			get
			{
				return this.award_Proposal_Submission_Type_ReferenceField;
			}
			set
			{
				this.award_Proposal_Submission_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Submission_Type_Reference");
			}
		}

		[XmlElement("Award_Proposal_Submission_Type_Data", Order = 1)]
		public Award_Proposal_Submission_Type_DataType[] Award_Proposal_Submission_Type_Data
		{
			get
			{
				return this.award_Proposal_Submission_Type_DataField;
			}
			set
			{
				this.award_Proposal_Submission_Type_DataField = value;
				this.RaisePropertyChanged("Award_Proposal_Submission_Type_Data");
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
