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
	public class End_Academic_Appointment_DataType : INotifyPropertyChanged
	{
		private Academic_Appointee_EnabledObjectType academic_Appointee_ReferenceField;

		private Academic_Appointment_TrackObjectType academic_Appointment_Track_ReferenceField;

		private General_Event_SubcategoryObjectType reason_ReferenceField;

		private DateTime track_End_DateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Appointee_EnabledObjectType Academic_Appointee_Reference
		{
			get
			{
				return this.academic_Appointee_ReferenceField;
			}
			set
			{
				this.academic_Appointee_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Appointee_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_Appointment_TrackObjectType Academic_Appointment_Track_Reference
		{
			get
			{
				return this.academic_Appointment_Track_ReferenceField;
			}
			set
			{
				this.academic_Appointment_Track_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Appointment_Track_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public General_Event_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Track_End_Date
		{
			get
			{
				return this.track_End_DateField;
			}
			set
			{
				this.track_End_DateField = value;
				this.RaisePropertyChanged("Track_End_Date");
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
