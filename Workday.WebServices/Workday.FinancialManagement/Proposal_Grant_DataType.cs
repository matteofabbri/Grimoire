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
	public class Proposal_Grant_DataType : INotifyPropertyChanged
	{
		private string proposal_Grant_Reference_IDField;

		private string proposal_Grant_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Proposal_Grant_Reference_ID
		{
			get
			{
				return this.proposal_Grant_Reference_IDField;
			}
			set
			{
				this.proposal_Grant_Reference_IDField = value;
				this.RaisePropertyChanged("Proposal_Grant_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Proposal_Grant_Name
		{
			get
			{
				return this.proposal_Grant_NameField;
			}
			set
			{
				this.proposal_Grant_NameField = value;
				this.RaisePropertyChanged("Proposal_Grant_Name");
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
