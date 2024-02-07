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
	public class Employee_Award_Request_CriteriaType : INotifyPropertyChanged
	{
		private Compensation_Review_EventObjectType compensation_Review_Event_ReferenceField;

		private Supervisory_Organization_and_SubordinatesType[] supervisory_Organization_and_SubordinatesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Review_EventObjectType Compensation_Review_Event_Reference
		{
			get
			{
				return this.compensation_Review_Event_ReferenceField;
			}
			set
			{
				this.compensation_Review_Event_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Review_Event_Reference");
			}
		}

		[XmlElement("Supervisory_Organization_and_Subordinates", Order = 1)]
		public Supervisory_Organization_and_SubordinatesType[] Supervisory_Organization_and_Subordinates
		{
			get
			{
				return this.supervisory_Organization_and_SubordinatesField;
			}
			set
			{
				this.supervisory_Organization_and_SubordinatesField = value;
				this.RaisePropertyChanged("Supervisory_Organization_and_Subordinates");
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
