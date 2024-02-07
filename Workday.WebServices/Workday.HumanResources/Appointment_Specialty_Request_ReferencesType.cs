using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Appointment_Specialty_Request_ReferencesType : INotifyPropertyChanged
	{
		private Appointment_SpecialtyObjectType[] appointment_Specialty_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Appointment_Specialty_Reference", Order = 0)]
		public Appointment_SpecialtyObjectType[] Appointment_Specialty_Reference
		{
			get
			{
				return this.appointment_Specialty_ReferenceField;
			}
			set
			{
				this.appointment_Specialty_ReferenceField = value;
				this.RaisePropertyChanged("Appointment_Specialty_Reference");
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
