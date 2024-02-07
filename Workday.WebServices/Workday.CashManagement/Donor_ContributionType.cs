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
	public class Donor_ContributionType : INotifyPropertyChanged
	{
		private Donor_ContributionObjectType donor_Contribution_ReferenceField;

		private Donor_Contribution_DataType[] donor_Contribution_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Donor_ContributionObjectType Donor_Contribution_Reference
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

		[XmlElement("Donor_Contribution_Data", Order = 1)]
		public Donor_Contribution_DataType[] Donor_Contribution_Data
		{
			get
			{
				return this.donor_Contribution_DataField;
			}
			set
			{
				this.donor_Contribution_DataField = value;
				this.RaisePropertyChanged("Donor_Contribution_Data");
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
