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
	public class Supervisory_Organization_Pool_Data__HV_Type : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Supervisory_Organization_Pool_Allocation__HV_Type[] budget_PoolField;

		private Supervisory_Organization_Holdback__HV_Type[] holdbackField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
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

		[XmlElement("Budget_Pool", Order = 1)]
		public Supervisory_Organization_Pool_Allocation__HV_Type[] Budget_Pool
		{
			get
			{
				return this.budget_PoolField;
			}
			set
			{
				this.budget_PoolField = value;
				this.RaisePropertyChanged("Budget_Pool");
			}
		}

		[XmlElement("Holdback", Order = 2)]
		public Supervisory_Organization_Holdback__HV_Type[] Holdback
		{
			get
			{
				return this.holdbackField;
			}
			set
			{
				this.holdbackField = value;
				this.RaisePropertyChanged("Holdback");
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
