using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supervisory_Organization_and_SubordinatesType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] supervisory_Organization_ReferenceField;

		private bool include_Subordinate_OrganizationsField;

		private bool include_Subordinate_OrganizationsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Supervisory_Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
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
