using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposal_Grant_Request_ReferencesType : INotifyPropertyChanged
	{
		private Proposal_GrantObjectType[] proposal_Grant_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Proposal_Grant_Reference", Order = 0)]
		public Proposal_GrantObjectType[] Proposal_Grant_Reference
		{
			get
			{
				return this.proposal_Grant_ReferenceField;
			}
			set
			{
				this.proposal_Grant_ReferenceField = value;
				this.RaisePropertyChanged("Proposal_Grant_Reference");
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
