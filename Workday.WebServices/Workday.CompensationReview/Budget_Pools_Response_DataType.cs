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
	public class Budget_Pools_Response_DataType : INotifyPropertyChanged
	{
		private Compensation_Review_EventObjectType compensation_Review_Event_ReferenceField;

		private Supervisory_Organization_Pool_DataType[] supervisory_Organization_Pool_DataField;

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

		[XmlElement("Supervisory_Organization_Pool_Data", Order = 1)]
		public Supervisory_Organization_Pool_DataType[] Supervisory_Organization_Pool_Data
		{
			get
			{
				return this.supervisory_Organization_Pool_DataField;
			}
			set
			{
				this.supervisory_Organization_Pool_DataField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Pool_Data");
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
