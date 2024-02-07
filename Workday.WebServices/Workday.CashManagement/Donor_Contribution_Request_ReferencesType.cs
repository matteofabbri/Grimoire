using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Donor_Contribution_Request_ReferencesType : INotifyPropertyChanged
	{
		private Donor_ContributionObjectType[] donor_Contribution_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Donor_Contribution_Reference", Order = 0)]
		public Donor_ContributionObjectType[] Donor_Contribution_Reference
		{
			get
			{
				return this.donor_Contribution_ReferenceField;
			}
			set
			{
				this.donor_Contribution_ReferenceField = value;
				this.RaisePropertyChanged("Donor_Contribution_Reference");
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
