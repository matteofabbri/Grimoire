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
	public class Award_ProposalType : INotifyPropertyChanged
	{
		private Award_ProposalObjectType award_Proposal_ReferenceField;

		private Award_Proposal_DataType[] award_Proposal_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_ProposalObjectType Award_Proposal_Reference
		{
			get
			{
				return this.award_Proposal_ReferenceField;
			}
			set
			{
				this.award_Proposal_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Reference");
			}
		}

		[XmlElement("Award_Proposal_Data", Order = 1)]
		public Award_Proposal_DataType[] Award_Proposal_Data
		{
			get
			{
				return this.award_Proposal_DataField;
			}
			set
			{
				this.award_Proposal_DataField = value;
				this.RaisePropertyChanged("Award_Proposal_Data");
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
