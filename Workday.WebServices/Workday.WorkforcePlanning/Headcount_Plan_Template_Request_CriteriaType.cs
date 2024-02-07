using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Template_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private bool include_Subordinate_OrganizationsField;

		private bool include_Subordinate_OrganizationsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Subordinate_Organizations
		{
			get
			{
				return this.include_Subordinate_OrganizationsField;
			}
			set
			{
				this.include_Subordinate_OrganizationsField = value;
				this.RaisePropertyChanged("Include_Subordinate_Organizations");
			}
		}

		[XmlIgnore]
		public bool Include_Subordinate_OrganizationsSpecified
		{
			get
			{
				return this.include_Subordinate_OrganizationsFieldSpecified;
			}
			set
			{
				this.include_Subordinate_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subordinate_OrganizationsSpecified");
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
