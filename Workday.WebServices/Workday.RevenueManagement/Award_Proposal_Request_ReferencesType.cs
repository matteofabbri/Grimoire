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
	public class Award_Proposal_Request_ReferencesType : INotifyPropertyChanged
	{
		private Award_ProposalObjectType[] award_Proposal_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Award_Proposal_Reference", Order = 0)]
		public Award_ProposalObjectType[] Award_Proposal_Reference
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
