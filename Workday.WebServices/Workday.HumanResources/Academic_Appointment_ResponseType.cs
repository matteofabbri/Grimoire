using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Appointment_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType event_ReferenceField;

		private Academic_Appointee_EnabledObjectType academic_Appointee_ReferenceField;

		private Academic_Appointment_TrackObjectType academic_Appointment_Track_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Event_Reference
		{
			get
			{
				return this.event_ReferenceField;
			}
			set
			{
				this.event_ReferenceField = value;
				this.RaisePropertyChanged("Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
