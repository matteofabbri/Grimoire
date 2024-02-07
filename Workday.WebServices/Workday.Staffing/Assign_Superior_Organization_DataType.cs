using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Superior_Organization_DataType : INotifyPropertyChanged
	{
		private Hierarchic_AssignerObjectType proposed_Supervisory_Organization_ReferenceField;

		private Supervisory_OrganizationObjectType[] subordinate_Supervisory_Organizations_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Hierarchic_AssignerObjectType Proposed_Supervisory_Organization_Reference
		{
			get
			{
				return this.proposed_Supervisory_Organization_ReferenceField;
			}
			set
			{
				this.proposed_Supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Supervisory_Organization_Reference");
			}
		}

		[XmlElement("Subordinate_Supervisory_Organizations_Reference", Order = 1)]
		public Supervisory_OrganizationObjectType[] Subordinate_Supervisory_Organizations_Reference
		{
			get
			{
				return this.subordinate_Supervisory_Organizations_ReferenceField;
			}
			set
			{
				this.subordinate_Supervisory_Organizations_ReferenceField = value;
				this.RaisePropertyChanged("Subordinate_Supervisory_Organizations_Reference");
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
